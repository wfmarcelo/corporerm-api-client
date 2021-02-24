using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.DataServer
{
    public class EduEtapasData : DataServer<SEtapas>
    {
        public EduEtapasData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduEtapasData))
        {
        }
    }
}