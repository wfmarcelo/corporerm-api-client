using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorporeRMApi.DataServer;
using CorporeRMApi.Models;
using CorporeRMApi.Models.Educacional;
using Uniarp.Util;

namespace CorporeRMApi.Processes
{
    public class EduCadastraHorarioAtividadeProfessorData
    {
        private readonly EduAtividadeProfessorData _atividadeProfessorData;
        private readonly EduProfessorTurmaData _professorTurmaData;
        private readonly EduHorarioProfessorData _horarioProfessorData;
        private readonly EduHorarioTurmaData _horarioTurmaData;
        private readonly EduTurmaDiscData _turmaDiscData;

        public EduCadastraHorarioAtividadeProfessorData(
            EduAtividadeProfessorData atividadeProfessorData,
            EduProfessorTurmaData professorTurmaData,
            EduHorarioProfessorData horarioProfessorData,
            EduHorarioTurmaData horarioTurmaData,
            EduTurmaDiscData turmaDiscData)
        {
            _atividadeProfessorData = atividadeProfessorData;
            _professorTurmaData = professorTurmaData;
            _horarioProfessorData = horarioProfessorData;
            _horarioTurmaData = horarioTurmaData;
            _turmaDiscData = turmaDiscData;
        }

        public void SetContexto(Contexto contexto)
        {
            _atividadeProfessorData.SetContexto(contexto);
        }

        public async Task<EduProcessaHorarioAtividadeProfessor> Processar(
            SAtividadeProfessor atividadeProfessor, IList<SHorario> horarios)
        {
            var turmasProfessor = await GetProfessorTurmasAsync(atividadeProfessor.CodProf, 
                        atividadeProfessor.DtInicio.Value, atividadeProfessor.DtTermino.Value);
            var atividadesProfessor = await GetAtividadesProfessorAsync(atividadeProfessor.CodProf, 
                        atividadeProfessor.DtInicio.Value, atividadeProfessor.DtTermino.Value);
            var horariosProfessores = await GetHorariosProfessorAsync(turmasProfessor);
            var horariosTurma = await GetHorariosTurmasAsync(horariosProfessores);
            var disciplinasProfessor = await GetDisciplinasProfessorAsync(turmasProfessor);
            
            
            var choquesHorarioProfessor = new List<SHorarioTurma>();
            var choquesHorarioAtividadeProfessor = new List<SHorarioAtivProf>();
            var horariosProcessados = new List<SHorarioAtivProf>();
            bool existeChoque = false;
            bool isCargaHorariaExcedida = false;

            foreach (var horario in horarios)
            {
                var horaInicial = horario.GetHorarioInicialInt();
                var horaFinal = horario.GetHorarioFinalInt();

                var choqueHorarioProfessor = SHorarioTurma.GetChoqueHorario(horariosTurma, atividadeProfessor.DtInicio.Value, 
                        atividadeProfessor.DtTermino.Value, horaInicial, horaFinal, horario.DiaSemana);
                if (choqueHorarioProfessor.Count > 0)
                {
                    foreach (var choque in choqueHorarioProfessor)
                    {
                        choquesHorarioProfessor.Add(choque);
                    }
                    existeChoque = true;
                    continue;
                }
    
                var choqueHorarioAtividadeProfessor = SAtividadeProfessor.GetChoqueAtividade(atividadesProfessor, 
                        atividadeProfessor.DtInicio.Value, atividadeProfessor.DtTermino.Value, horaInicial, horaFinal, horario.DiaSemana);
                if (choqueHorarioAtividadeProfessor.Count > 0)
                {
                    foreach (var choque in choqueHorarioAtividadeProfessor)
                    {
                        choquesHorarioAtividadeProfessor.Add(choque);
                    }
                    existeChoque = true;
                    continue;
                }
                
                var cargaHorariaProcessada = horario.GetCargaHoraria();
                if (atividadeProfessor.GetCargaHoraria() < cargaHorariaProcessada + atividadeProfessor.CargaHorariaCadastrada)
                {
                    isCargaHorariaExcedida = true;
                    break;
                }

                var horarioProcessado = new SHorarioAtivProf
                    {
                        CodColigada = atividadeProfessor.CodColigada,
                        IdAtividadeProf = atividadeProfessor.IdAtividadeProf,
                        CodHor = horario.CodHor,
                        DiaSemana = horario.DiaSemana.ToString(),
                        DataInicio = atividadeProfessor.DtInicio.Value,
                        DataFim = atividadeProfessor.DtTermino.Value,
                        HoraInicio = horario.HoraInicial,
                        HoraFim = horario.HoraFinal,
                        DesconsideraPonto = "N"
                    };

                
                horariosProcessados.Add(horarioProcessado);
                atividadeProfessor.SHorarioAtivProf.Add(horarioProcessado);

                if (atividadeProfessor.IsCargaHorariaPreenchida())
                {
                    break;
                }
            }

            atividadeProfessor.SHorarioAtivProf = horariosProcessados;

            return new EduProcessaHorarioAtividadeProfessor
            {
                ExisteChoque = existeChoque,
                IsCargaHorariaExcedida = isCargaHorariaExcedida,
                ChoquesHorarioAtividadeProfessor = choquesHorarioAtividadeProfessor,
                ChoquesHorarioProfessor = choquesHorarioProfessor,
                AtividadeProfessor = atividadeProfessor,
                DisciplinasProfessor = disciplinasProfessor
            };
        }

        private async Task<IList<SProfessorTurma>> GetProfessorTurmasAsync(string codProf, DateTime dataInicial, DateTime dataFinal)
        {
            var filtro = new List<string>{
                @"
                    SProfessorTurma.CodProf =:CODPROF AND
                    (SProfessorTurma.DtInicio BETWEEN :DATAINICIAL AND :DATAFINAL
                    OR SProfessorTurma.DtFim BETWEEN :DATAINICIAL AND :DATAFINAL)
                ",
                codProf,
                dataInicial.ToString("s"),
                dataFinal.ToString("s")

            };

            var result = await _professorTurmaData.GetAllAsync(filter: filtro);

            return result.Data;
        }

        private async Task<IList<SHorarioAtivProf>> GetAtividadesProfessorAsync(string codProf, DateTime dataInicial, DateTime dataFinal)
        {
            var atividades = new List<SHorarioAtivProf>();
            var filtro = new List<string>{
                @"
                    SAtividadeProfessor.CodProf =:CODPROF AND
                    (SAtividadeProfessor.DtInicio BETWEEN :DATAINICIAL AND :DATAFINAL
                    OR SAtividadeProfessor.DtTermino BETWEEN :DATAINICIAL AND :DATAFINAL)
                ",
                codProf,
                dataInicial.ToString("s"),
                dataFinal.ToString("s")

            };

            var result = await _atividadeProfessorData.GetAllAsync(filter: filtro);

            foreach (var atividade in result.Data)
            {
                var atividadeProfessorAtual = await _atividadeProfessorData.GetAsync(atividade.Id);
                atividades.AddRange(atividadeProfessorAtual.Data.SHorarioAtivProf);
            }

            return atividades;
        }

        private async Task<IList<SHorarioProfessor>> GetHorariosProfessorAsync(IList<SProfessorTurma> turmasProfessor)
        {
            var idsProfessores = turmasProfessor.Select(tp => tp.IdProfessorTurma).Distinct().ToList();

            var filtro = new List<string>
            {
                $"SHorarioProfessor.IdProfessorTurma in ({ string.Join(',', idsProfessores)})"
            };

            var result = await _horarioProfessorData.GetAllAsync(filter: filtro);

            return result.Data;
        }

        private async Task<IList<SHorarioTurma>> GetHorariosTurmasAsync(IList<SHorarioProfessor> horariosProfessores)
        {
            var idsHorarioTurma = horariosProfessores.Select(hp => hp.IdHorarioTurma).Distinct().ToList();
            var filtro = new List<string> {
                $"SHorarioTurma.IdHorarioTurma in ({string.Join(',', idsHorarioTurma)})"
            };
            
            var horariosTurma = await _horarioTurmaData.GetAllAsync(filter: filtro);

            return horariosTurma.Data;
        }

        private async Task<IList<STurmaDisc>> GetDisciplinasProfessorAsync(IList<SProfessorTurma> turmasProfessor)
        {
            var idsTurmaDisciplina = turmasProfessor.Select(tp => tp.IdTurmaDisc).Distinct().ToList();
            
            var filtro = new List<string>
            {
                $"STurmaDisc.IdTurmaDisc in ({ string.Join(',', idsTurmaDisciplina)})"
            };

            var result = await _turmaDiscData.GetAllAsync(filter: filtro);

            return result.Data;
        }

        public async Task Cadastrar(SAtividadeProfessor atividadeProfessor)
        {
            var atividadeNova = atividadeProfessor;

            foreach (var horario in atividadeProfessor.SHorarioAtivProf)
            {
                horario.State = 1;
                atividadeNova.SHorarioAtivProf = new List<SHorarioAtivProf>() { horario };
                await _atividadeProfessorData.UpdateAsync(atividadeProfessor.Id, atividadeNova);
            }

            await SetSituacao(atividadeProfessor.Id);

        }

        private async Task SetSituacao(string id)
        {
            var atividade = await _atividadeProfessorData.GetAsync(id);

            if (atividade.Data.IsCargaHorariaPreenchida())
            {
                atividade.Data.Situacao = "A";
                await _atividadeProfessorData.UpdateAsync(id, atividade.Data);
            }
        }
    }
}