using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorporeRMApi.Models.Educacional;
using Uniarp.Util;

namespace CorporeRMApi.DataServer
{
    public class EduAtividadeProfessorData : DataServer<SAtividadeProfessor>
    {
        public EduAtividadeProfessorData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduAtividadeProfessorData))
        {
        }

        public async Task<IList<SAtividadeProfessor>> GetAtividadesAsync(IList<string> codigosProf, DateTime dataIncial, DateTime dataFinal)
        {
            var codigos = codigosProf.Select(p => $"'{p}'").ToList();
            var filtro = $"[\"SAtividadeProfessor.CodProf in ({string.Join(',', codigos)}) " +
                        $"AND (SAtividadeProfessor.DTINICIO BETWEEN '{dataIncial.ToString("s")}' AND '{dataFinal.ToString("s")}' " +
                        $"OR SAtividadeProfessor.DTTERMINO BETWEEN '{dataIncial.ToString("s")}' AND '{dataFinal.ToString("s")}') \"]";
            return await base.GetAllAsync(filter: filtro);
        }
        public async Task<IList<SAtividadeProfessor>> GetAtividadesAsync(string codProf)
        {
            var filtro = $"[\"SAtividadeProfessor.CodProf = '{codProf}' AND SAtividadeProfessor.DtTermino > GETDATE() \"]";
            return await base.GetAllAsync(filter: filtro);
        }

        public async Task<IList<SAtividadeProfessor>> GetAtividadesAsync(IList<SAtividadeProfessor> atividades)
        {
            var atividadesRetorno = new List<SAtividadeProfessor>();

            if (atividades == null)
            {
                return atividadesRetorno;
            }

            foreach (var atividade in atividades)
            {
                var registro = await GetAsync(atividade.Id);

                if (registro == null)
                {
                    continue;
                }

                atividadesRetorno.Add(registro);
            }

            return atividadesRetorno;
        }


        public IList<SHorarioAtivProf> GetChoqueAtividade(IList<SAtividadeProfessor> atividades, DateTime dataInicial, DateTime dataFinal, int HoraInicio, int HoraFim, int diaSemana)
        {
            var choques = new List<SHorarioAtivProf>();

            foreach (var atividade in atividades)
            {
                var choque =
                        atividade.SHorarioAtivProf
                            .Where(h =>
                                (
                                    ((dataInicial.Date >= ((DateTime)h.DataInicio).Date && dataInicial.Date <= ((DateTime)h.DataFim).Date) ||
                                    (dataFinal.Date >= ((DateTime)h.DataInicio).Date && dataFinal.Date <= ((DateTime)h.DataFim).Date)) ||
                                    ((dataInicial.Date <= ((DateTime)h.DataInicio).Date && dataInicial.Date >= ((DateTime)h.DataFim).Date) ||
                                    (dataFinal.Date <= ((DateTime)h.DataInicio).Date && dataFinal.Date >= ((DateTime)h.DataFim).Date)) ||
                                    ((dataInicial.Date <= ((DateTime)h.DataInicio).Date && dataFinal.Date >= ((DateTime)h.DataFim).Date) ||
                                    (dataFinal.Date <= ((DateTime)h.DataInicio).Date && dataInicial.Date >= ((DateTime)h.DataFim).Date))
                                    )
                                &&
                                (HoraInicio >= Formater.TimeToInt(h.HoraInicio) && HoraFim < Formater.TimeToInt(h.HoraFim) ||
                                (HoraFim > Formater.TimeToInt(h.HoraInicio) && HoraFim <= Formater.TimeToInt(h.HoraFim)))
                                && h.DiaSemana == diaSemana.ToString()).Distinct().ToList();

                if (choque.Count > 0)
                {
                    choques = choques.Concat(choque).ToList();
                }
            }

            return choques;
        }
    }
}