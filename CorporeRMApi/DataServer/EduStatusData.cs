using CorporeRMApi.Models;
using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.DataServer
{
    public class EduStatusData : DataServer<SStatus>
    {
        public EduStatusData(CorporeRMApiClient corporeRMApiClient) 
        : base(corporeRMApiClient, nameof(EduStatusData))
        {
        }
    }
}