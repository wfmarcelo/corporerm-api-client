using System.Collections.Generic;
using CorporeRMApi.Models;
using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.Processes
{
    public class EduGeraPlanoAulaData : Process<EduGeraPlanoAula>
    {
        public EduGeraPlanoAulaData(ProcessClient processClient) 
            : base(processClient, nameof(EduGeraPlanoAulaData))
        {
        }

        public EduGeraPlanoAula GetModel(STurmaDisc turmaDisc)
        {
            return new EduGeraPlanoAula
            {
                CodColigada = turmaDisc.CodColigada,
                CodFilial = turmaDisc.CodFilial,
                CodTipoCurso = turmaDisc.CodTipoCurso,
                Context =
                    new Context()
                    {
                        Id = "1",
                        Environment = 1,
                        _params =
                            new Params
                            {
                                CodColigada = turmaDisc.CodColigada,
                                CodTipoCurso = (short)turmaDisc.CodTipoCurso,
                                CodSistema = "S",
                                CodFilial = turmaDisc.CodFilial
                            }
                    },
                TipoAula = 0,
                NaoUltrapassaCargaHoraria = true,
                UsaDataInicialTurma = true,
                UsaDataFinalTurma = true,
                ConsiderarRecesso = true,
                RegerarPlanoAula = true,
                PrimaryKeyList = new List<object>{ turmaDisc.GetPrimaryKeyList() },
                PrimaryKeyNames = turmaDisc.GetPrimaryKeyNames(),
                ListaTipoFeriado = new List<string> { "AC", "ES", "MU", "NA", "PF" }
            };
        }
    }
}