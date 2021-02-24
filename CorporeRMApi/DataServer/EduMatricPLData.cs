using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.DataServer
{
    public class EduMatricPLData : DataServer<SMatricPL>
    {
        public EduMatricPLData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduMatricPLData))
        {
        }
    }
}
