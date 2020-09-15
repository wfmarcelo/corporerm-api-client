using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduPLetivoData : DataServer<SPLetivo>
    {
        public EduPLetivoData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduPLetivoData))
        {
        }
    }
}