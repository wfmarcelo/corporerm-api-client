using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduPlanoAulaData : DataServer<SPlanoAula>
    {
        public EduPlanoAulaData(CorporeRMApiClient corporeRMApiClient) : base(corporeRMApiClient, nameof(EduPlanoAulaData))
        {
        }
    }
}