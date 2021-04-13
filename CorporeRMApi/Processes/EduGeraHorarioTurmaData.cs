using System.Collections.Generic;
using System.Threading.Tasks;
using CorporeRMApi.Models;
using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.Processes
{
    public class EduGeraHorarioTurmaData : Process<EduGeraHorarioTurma>
    {
        public EduGeraHorarioTurmaData(ProcessClient processClient) 
            : base(processClient, nameof(EduGeraHorarioTurmaData))
        {
        }

        public EduGeraHorarioTurma GetModel(
            EduProcessaHorarioTurma parametros)
        {
            return new EduGeraHorarioTurma
            {
                CodColigada = parametros.STurmaDisc.CodColigada,
                CodFilial = parametros.STurmaDisc.CodFilial,
                CodTipoCurso = parametros.STurmaDisc.CodTipoCurso,
                IdTurmaDisc = parametros.STurmaDisc.IdTurmaDisc,
                ListaHorarios = parametros.HorariosInclusao,
                Context = new Context()
                    {
                        Id = "1",
                        Environment = 1,
                        _params =
                            new Params
                            {
                                CodColigada = parametros.STurmaDisc.CodColigada,
                                CodTipoCurso = (short)parametros.STurmaDisc.CodTipoCurso,
                                CodSistema = "S",
                                CodFilial = parametros.STurmaDisc.CodFilial
                            }
                    },
                PrimaryKeyList = new List<object>{ parametros.STurmaDisc.GetPrimaryKeyList() },
                PrimaryKeyNames = parametros.STurmaDisc.GetPrimaryKeyNames(),
                PermitirSuperAlocarProfessores = false,
                RespeitaPeriodoProf = false,
                GeraPorRecorrencia = true,
                PermitirSuperAlocarSala = false,
                ActionName = "EduGeraHorarioTurmaAction",
                ActionModule = "S"
            };
        }
    }
}