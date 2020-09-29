using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduHorarioData : DataServer<SHorario>
    {
        public EduHorarioData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduHorarioData))
        {
        }
    }
}