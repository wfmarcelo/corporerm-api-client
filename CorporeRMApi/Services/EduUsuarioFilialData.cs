using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduUsuarioFilialData : DataServer<SUsuarioFilial>
    {
        public EduUsuarioFilialData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduUsuarioFilialData))
        {
        }
    }
}