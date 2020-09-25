using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduHorarioTurmaData : DataServer<SHorarioTurma>
    {
        public EduHorarioTurmaData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduHorarioTurmaData))
        {
        }
    }
}