using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.DataServer
{
    public class EduInstituicaoMECData : DataServer<SInstituicaoMEC>
    {
        public EduInstituicaoMECData(CorporeRMApiClient corporeRMApiClient) : base(corporeRMApiClient, nameof(EduInstituicaoMECData))
        {
        }
    }
}
