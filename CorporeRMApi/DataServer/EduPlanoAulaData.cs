using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.DataServer
{
    public class EduPlanoAulaData : DataServer<SPlanoAula>
    {
        public EduPlanoAulaData(CorporeRMApiClient corporeRMApiClient) : base(corporeRMApiClient, nameof(EduPlanoAulaData))
        {
        }
    }
}