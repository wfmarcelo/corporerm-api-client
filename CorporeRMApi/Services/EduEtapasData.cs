using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduEtapasData : DataServer<SEtapas>
    {
        public EduEtapasData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduEtapasData))
        {
        }
    }
}