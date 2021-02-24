using CorporeRMApi.Models;
using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.DataServer
{
    public class EduPLetivoData : DataServer<SPLetivo>
    {
        public EduPLetivoData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduPLetivoData))
        {
        }
    }
}