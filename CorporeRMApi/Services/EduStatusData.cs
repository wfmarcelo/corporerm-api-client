using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduStatusData : DataServer<SStatus>
    {
        public EduStatusData(CorporeRMApiClient corporeRMApiClient) 
        : base(corporeRMApiClient, nameof(EduStatusData))
        {
        }
    }
}