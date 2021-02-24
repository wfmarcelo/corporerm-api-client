using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.DataServer
{
    public class EduHorarioTurmaData : DataServer<SHorarioTurma>
    {
        public EduHorarioTurmaData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduHorarioTurmaData))
        {
        }
    }
}