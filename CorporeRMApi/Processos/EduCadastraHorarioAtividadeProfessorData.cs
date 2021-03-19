using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorporeRMApi.DataServer;
using CorporeRMApi.Models;
using CorporeRMApi.Models.Educacional;
using Uniarp.Util;

namespace CorporeRMApi.Processos
{
    public class EduCadastraHorarioAtividadeProfessorData
    {
        private readonly EduAtividadeProfessorData _atividadeProfessorData;

        public EduCadastraHorarioAtividadeProfessorData(
            EduAtividadeProfessorData atividadeProfessorData)
        {
            _atividadeProfessorData = atividadeProfessorData;
        }

        public void SetContexto(Contexto contexto)
        {
            _atividadeProfessorData.SetContexto(contexto);
        }

        public async Task<EduProcessaHorarioAtividadeProfessor> Processar(
            EduProcessaHorarioAtividadeProfessorParams parametros)
        {
            var choquesHorarioProfessor = new List<SHorarioTurma>();
            var choquesHorarioAtividadeProfessor = new List<SHorarioAtivProf>();
            var horariosProcessados = new List<SHorarioAtivProf>();
            bool existeChoque = false;

            foreach (var horario in parametros.Horarios)
            {
                var horaInicial = Formater.TimeToInt(horario.HoraInicial);
                var horaFinal = Formater.TimeToInt(horario.HoraFinal);

                var dataInicial = (DateTime)parametros.AtividadeProfessor.DtInicio;
                var dataFinal = (DateTime)parametros.AtividadeProfessor.DtTermino;

                var choqueHorarioProfessor = SHorarioTurma.GetChoqueHorario(parametros.HorariosTurma, dataInicial, dataFinal, horaInicial, horaFinal, horario.DiaSemana);
                if (choqueHorarioProfessor.Count > 0)
                {
                    foreach (var choque in choqueHorarioProfessor)
                    {
                        choquesHorarioProfessor.Add(choque);
                    }
                    existeChoque = true;
                    continue;
                }

                foreach (var atividade in parametros.AtividadesProfessor)
                {
                    var atividadeProfessor = await _atividadeProfessorData.GetAsync(atividade.Id);
                    
                    var choqueHorarioAtividadeProfessor = SAtividadeProfessor.GetChoqueAtividade(atividadeProfessor.SHorarioAtivProf, dataInicial, dataFinal, horaInicial, horaFinal, horario.DiaSemana);
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

                horariosProcessados.Add(
                    new SHorarioAtivProf
                    {
                        CodColigada = parametros.AtividadeProfessor.CodColigada,
                        IdAtividadeProf = parametros.AtividadeProfessor.IdAtividadeProf,
                        CodHor = horario.CodHor,
                        DiaSemana = horario.DiaSemana.ToString(),
                        DataInicio = dataInicial,
                        DataFim = dataFinal,
                        HoraInicio = horario.HoraInicial,
                        HoraFim = horario.HoraFinal,
                        DesconsideraPonto = "N"
                    });
            }

            parametros.AtividadeProfessor.SHorarioAtivProf = horariosProcessados;

            return new EduProcessaHorarioAtividadeProfessor
            {
                ExisteChoque = existeChoque,
                ChoquesHorarioAtividadeProfessor = choquesHorarioAtividadeProfessor,
                ChoquesHorarioProfessor = choquesHorarioProfessor,
                AtividadeProfessor = parametros.AtividadeProfessor,
                DisciplinasProfessor = parametros.TurmaDisciplinas
            };
        }

        public async Task Cadastrar(SAtividadeProfessor atividadeProfessor)
        {
            var atividadeNova = atividadeProfessor;

            foreach (var horario in atividadeProfessor.SHorarioAtivProf)
            {
                atividadeNova.SHorarioAtivProf = new List<SHorarioAtivProf>() { horario };
                await _atividadeProfessorData.UpdateAsync(atividadeProfessor.Id, atividadeNova);
            }
        }
    }
}