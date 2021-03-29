using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorporeRMApi.DataServer;
using CorporeRMApi.Models;
using CorporeRMApi.Models.Educacional;
using CorporeRMApi.Models.Global;
using Uniarp.Util;

namespace CorporeRMApi.Processes
{
    public class EduProcessaHorarioTurmaData
    {
        private readonly EduHorarioTurmaData _horarioTurmaData;
        private readonly EduHorarioProfessorData _horarioProfessorData;
        private readonly GlbCalendData _calendarioData;
        private readonly EduTurmaDiscData _turmaDiscData;
        private readonly EduProfessorTurmaData _professorTurmaData;
        private readonly EduPLetivoData _periodoLetivoData;
        private readonly EduAtividadeProfessorData _atividadeProfessorData;

        public EduProcessaHorarioTurmaData(
            EduHorarioTurmaData horarioTurmaData,
            EduHorarioProfessorData horarioProfessorData,
            GlbCalendData calendarioData,
            EduTurmaDiscData turmaDiscData,
            EduProfessorTurmaData professorTurmaData,
            EduPLetivoData periodoLetivoData,
            EduAtividadeProfessorData atividadeProfessorData)
        {
            _horarioTurmaData = horarioTurmaData;
            _horarioProfessorData = horarioProfessorData;
            _calendarioData = calendarioData;
            _turmaDiscData = turmaDiscData;
            _professorTurmaData = professorTurmaData;
            _periodoLetivoData = periodoLetivoData;
            _atividadeProfessorData = atividadeProfessorData;
        }

        public void SetContexto(Contexto contexto)
        {
            _horarioProfessorData.SetContexto(contexto);
            _calendarioData.SetContexto(contexto);
            _periodoLetivoData.SetContexto(contexto);
            _turmaDiscData.SetContexto(contexto);
            _professorTurmaData.SetContexto(contexto);
            _atividadeProfessorData.SetContexto(contexto);
        }

        public async Task<EduProcessaHorarioTurma> ProcessarAsync(
            EduProcessaHorarioTurmaParams parametros)
        {

            var periodoLetivo = await _periodoLetivoData.GetAsync(parametros.STurmaDisc.GetPeriodoLetivoId());
            var calendario = await _calendarioData.GetAsync(periodoLetivo.Calendario);

            var turmasProfessores =
                await GetProfessoresAsync(
                        parametros.Professores.Select(p => p.CodProf).Distinct().ToList(),
                        parametros.STurmaDisc.DtInicial.Value,
                        parametros.STurmaDisc.DtFinal.Value
                        );

            var disciplinasProfessores = await GetDisciplinasTurmaAsync(turmasProfessores.Select(tp => tp.IdTurmaDisc).Distinct().ToList());
            var atividadesProfessores =
                await GetAtividadesAsync(
                        parametros.Professores.Select(p => p.CodProf).Distinct().ToList(),
                        parametros.STurmaDisc.DtInicial.Value,
                        parametros.STurmaDisc.DtFinal.Value
                        );

            var horariosAtividadesProfessores = await GetAtividadesAsync(atividadesProfessores);

            var horariosProfessores = await GetHorariosDisciplinasAsync(turmasProfessores.Select(tp => tp.IdTurmaDisc).Distinct().ToList());
            var disciplinasTurma = await GetDisciplinasTurmaAsync(parametros.STurmaDisc.IdPerLet, parametros.STurmaDisc.CodTurma);
            var horariosDisciplina = await GetHorariosDisciplinaAsync(parametros.STurmaDisc.IdTurmaDisc);

            decimal chCadastrada = 0;
            if (horariosDisciplina != null)
            {
                chCadastrada = (decimal)horariosDisciplina.Sum(h => Formater.TimeToInt(h.HoraFinal) - Formater.TimeToInt(h.HoraInicial));
            }

            var data = parametros.STurmaDisc.DtInicial.Value;
            var contadorAula = chCadastrada;

            IList<SHorarioTurma> horariosDisciplinasTurma = null;
            if (parametros.VerificaChoqueTurma)
            {
                horariosDisciplinasTurma = await GetHorariosDisciplinasAsync(disciplinasTurma.Select(dt => dt.IdTurmaDisc).Distinct().ToList());
            }

            var choquesFeriado = new List<GFeriado>();
            var choquesHorarioTurma = new List<SHorarioTurma>();
            var choquesHorarioProfessor = new List<SHorarioTurma>();
            var choquesHorarioAtividadeProfessor = new List<SHorarioAtivProf>();
            var horariosTurma = new List<Horario>();
            bool existeChoque = false;
            bool isFeriado = false;

            while (data <= parametros.STurmaDisc.DtFinal)
            {
                foreach (var horario in parametros.Horarios)
                {
                    var horaInicial = Formater.TimeToInt(horario.HoraInicial);
                    var horaFinal = Formater.TimeToInt(horario.HoraFinal);
                    var tempoAula = horaFinal - horaInicial;

                    if (horario.DiaSemana == (int)data.DayOfWeek + 1)
                    {
                        var choqueHorarioDisciplina = SHorarioTurma.GetChoqueHorario(horariosDisciplina, data, data, horaInicial, horaFinal, horario.DiaSemana);
                        if (choqueHorarioDisciplina.Count > 0)
                        {
                            continue;
                        }

                        var choqueHorarioProfessor = SHorarioTurma.GetChoqueHorario(horariosProfessores, data, data, horaInicial, horaFinal, horario.DiaSemana);
                        if (choqueHorarioProfessor.Count > 0)
                        {
                            foreach (var choque in choqueHorarioProfessor)
                            {
                                choquesHorarioProfessor.Add(choque);
                            }
                            existeChoque = true;
                            continue;
                        }

                        foreach (var atividade in horariosAtividadesProfessores)
                        {

                            var choqueHorarioAtividadeProfessor = SAtividadeProfessor.GetChoqueAtividade(atividade.SHorarioAtivProf, data, data, horaInicial, horaFinal, horario.DiaSemana);
                            if (choqueHorarioAtividadeProfessor.Count > 0)
                            {
                                foreach (var choque in choqueHorarioAtividadeProfessor)
                                {
                                    choquesHorarioAtividadeProfessor.Add(choque);
                                }
                                existeChoque = true;
                                continue;
                            }
                        }


                        var feriado = GCalend.GetChoqueFeriado(calendario, data, horaInicial, horaFinal);
                        if (feriado != null)
                        {
                            isFeriado = true;
                            choquesFeriado.Add(feriado);
                            existeChoque = true;
                            continue;
                        } else {
                            isFeriado = false;
                        }


                        var choqueHorarioTurma = SHorarioTurma.GetChoqueHorario(horariosDisciplinasTurma, data, data, horaInicial, horaFinal, horario.DiaSemana);
                        if (choqueHorarioTurma.Count > 0)
                        {
                            foreach (var choque in choqueHorarioTurma)
                            {
                                choquesHorarioTurma.Add(choque);
                            }
                            existeChoque = true;
                            continue;
                        }


                        contadorAula += tempoAula;

                        if (contadorAula <= parametros.SDisciplina.CH)
                        {
                            horariosTurma.Add(new Horario
                            {
                                CodColigada = horario.CodColigada,
                                CodHor = horario.CodHor,
                                DataInicial = data,
                                DataFinal = data,
                                HoraInicial = horario.HoraInicial,
                                HoraFinal = horario.HoraFinal,
                                DiaSemana = (short)horario.DiaSemana,
                                ListaProfessorTurma = parametros.Professores
                                
                            });
                        }
                    }
                }

                if (contadorAula > 0)
                {
                    if ((int)data.DayOfWeek == 6)
                    {
                        if (parametros.Recorrencia == Recorrencia.Quinzenal && isFeriado == false)
                        {
                            data = data.AddDays(7);
                        }
                    }
                }

                data = data.AddDays(1);

                if (contadorAula >= parametros.SDisciplina.CH)
                {
                    break;
                }
            }


            var isCHIncompleta = (parametros.SDisciplina.CH > chCadastrada + contadorAula);
            if (isCHIncompleta == true)
            {
                existeChoque = true;
            }

            return new EduProcessaHorarioTurma
            {
                AtividadesProfessores = atividadesProfessores,
                ChoquesFeriado = choquesFeriado.Distinct().ToList(),
                choquesHorarioAtividadeProfessores = choquesHorarioAtividadeProfessor,
                choquesHorarioProfessores = choquesHorarioProfessor,
                ChoquesHorarioTurma = choquesHorarioTurma,
                CHProcessada = contadorAula / 60,
                CHDisciplina = parametros.SDisciplina.CH.Value / 60,
                CHCadastrada = chCadastrada / 60,
                TurmasProfessores = turmasProfessores,
                DisciplinasTurma = disciplinasTurma,
                DisciplinasProfessores = disciplinasProfessores,
                HorariosInclusao = horariosTurma,
                ProfessoresInclusao = parametros.Professores,
                NomeDisciplina = parametros.SDisciplina.Nome,
                ExisteChoque = existeChoque,
                IsCHIncompleta = isCHIncompleta,
                STurmaDisc = parametros.STurmaDisc
            };
        }

        public async Task<IList<SProfessorTurma>> GetProfessoresAsync(IList<string> codigosProf, DateTime dataIncial, DateTime dataFinal)
        {
            var codigos = codigosProf.Select(c => $"'{c}'").ToList();
            var filtro = $"[\"SProfessorTurma.CodProf in ({string.Join(',', codigos)}) " +
                        $"AND (SPROFESSORTURMA.DTINICIO BETWEEN '{dataIncial.ToString("s")}' AND '{dataFinal.ToString("s")}' " +
                        $"OR SPROFESSORTURMA.DTFIM BETWEEN '{dataIncial.ToString("s")}' AND '{dataFinal.ToString("s")}') \"]";
            var result = await _professorTurmaData.GetAllAsync(filter: filtro);

            if (result == null)
            {
                return new List<SProfessorTurma>();
            }
            
            return result;
        }

        private async Task<IList<STurmaDisc>> GetDisciplinasTurmaAsync(IList<int> idsTurmaDisciplina)
        {
            if (idsTurmaDisciplina.Count == 0)
            {
                return new List<STurmaDisc>();
            }
            
            var filtro = $"[\"STurmaDisc.IdTurmaDisc in ({ string.Join(',', idsTurmaDisciplina)}) \"]";
            return await _turmaDiscData.GetAllAsync(filter: filtro);
        }

        private async Task<IList<SAtividadeProfessor>> GetAtividadesAsync(IList<string> codigosProf, DateTime dataIncial, DateTime dataFinal)
        {
            var codigos = codigosProf.Select(p => $"'{p}'").ToList();
            var filtro = $"[\"SAtividadeProfessor.CodProf in ({string.Join(',', codigos)}) " +
                        $"AND (SAtividadeProfessor.DTINICIO BETWEEN '{dataIncial.ToString("s")}' AND '{dataFinal.ToString("s")}' " +
                        $"OR SAtividadeProfessor.DTTERMINO BETWEEN '{dataIncial.ToString("s")}' AND '{dataFinal.ToString("s")}') \"]";
            var result = await _atividadeProfessorData.GetAllAsync(filter: filtro);

            if (result == null)
            {
                return new List<SAtividadeProfessor>();
            }
            
            return result;
        }

        private async Task<IList<SAtividadeProfessor>> GetAtividadesAsync(IList<SAtividadeProfessor> atividades)
        {
            var atividadesRetorno = new List<SAtividadeProfessor>();

            if (atividades == null)
            {
                return atividadesRetorno;
            }

            foreach (var atividade in atividades)
            {
                var registro = await _atividadeProfessorData.GetAsync(atividade.Id);

                if (registro == null)
                {
                    continue;
                }

                atividadesRetorno.Add(registro);
            }

            return atividadesRetorno;
        }

        private async Task<IList<SHorarioTurma>> GetHorariosDisciplinasAsync(IList<int> idsTurmaDisc)
        {
            if (idsTurmaDisc.Count == 0)
            {
                return new List<SHorarioTurma>();
            }
            
            var filtro = $"[\"SHorarioTurma.IdTurmaDisc in ({string.Join(',', idsTurmaDisc)}) \"]";
            return await _horarioTurmaData.GetAllAsync(filter: filtro);
        }

        private async Task<IList<STurmaDisc>> GetDisciplinasTurmaAsync(int idPerLet, string codTurma)
        {
            var filtro = $"[\"STurmaDisc.IdPerLet = {idPerLet} AND STurmaDisc.CodTurma = '{codTurma}' \"]";
            return await _turmaDiscData.GetAllAsync(filter: filtro);
        }

        private async Task<IList<SHorarioTurma>> GetHorariosDisciplinaAsync(int idTurmaDisc)
        {
            var filtro = $"[\"SHorarioTurma.IdTurmaDisc = ${idTurmaDisc} \"]";
            return await _horarioTurmaData.GetAllAsync(filter: filtro);
        }
    }
}