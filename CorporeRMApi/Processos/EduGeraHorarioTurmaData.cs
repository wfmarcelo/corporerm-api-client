using System.Collections.Generic;
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

        public EduGeraHorarioTurma GetModel(STurmaDisc turmaDisc, string codUsuario)
        {
            return new EduGeraHorarioTurma
            {
                CodColigada = turmaDisc.CodColigada,
                CodFilial = turmaDisc.CodFilial,
                CodTipoCurso = turmaDisc.CodTipoCurso,
                Context =
                    new Context()
                    {
                        Id = "1",
                        Environment = 4,
                        _params =
                            new Params
                            {
                                CodColigada = turmaDisc.CodColigada,
                                CodTipoCurso = (short)turmaDisc.CodTipoCurso,
                                CodSistema = "S",
                                CodFilial = turmaDisc.CodFilial,
                                CodUsuario = codUsuario
                            }
                    },
                
                PrimaryKeyList = new List<object>{ turmaDisc.GetPrimaryKeyList() },
                PrimaryKeyNames = turmaDisc.GetPrimaryKeyNames(),
                ActionName = "EduGeraHorarioTurmaAction",
                ActionModule = "S"
            };
        }
    }
}