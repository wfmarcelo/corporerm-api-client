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
            STurmaDisc turmaDisc, 
            IList<Horario> horarios, 
            Context contexto,
            bool permitirSuperAlocarSala = false,
            bool respeitaPeriodoProf = false,
            bool geraPorRecorrencia = true,
            bool permiteSuperAlocarProfessores = false)
        {
            return new EduGeraHorarioTurma
            {
                CodColigada = turmaDisc.CodColigada,
                CodFilial = turmaDisc.CodFilial,
                CodTipoCurso = turmaDisc.CodTipoCurso,
                ListaHorarios = horarios,
                Context = contexto,
                PrimaryKeyList = new List<object>{ turmaDisc.GetPrimaryKeyList() },
                PrimaryKeyNames = turmaDisc.GetPrimaryKeyNames(),
                PermitirSuperAlocarProfessores = permiteSuperAlocarProfessores,
                RespeitaPeriodoProf = respeitaPeriodoProf,
                GeraPorRecorrencia = geraPorRecorrencia,
                PermitirSuperAlocarSala = permitirSuperAlocarSala,
                ActionName = "EduGeraHorarioTurmaAction",
                ActionModule = "S"
            };
        }
    }
}