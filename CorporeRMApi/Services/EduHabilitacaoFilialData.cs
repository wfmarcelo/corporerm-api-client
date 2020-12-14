using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduHabilitacaoFilialData : DataServer<SHabilitacaoFilial>
    {
        public EduHabilitacaoFilialData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduHabilitacaoFilialData))
        {
        }
    }
}