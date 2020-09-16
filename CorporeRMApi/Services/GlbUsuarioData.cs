using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class GlbUsuarioData : DataServer<GUsuario>
    {
        public GlbUsuarioData(CorporeRMApiClient corporeRMApiClient) : base(corporeRMApiClient, nameof(GlbUsuarioData))
        {
        }
    }
}