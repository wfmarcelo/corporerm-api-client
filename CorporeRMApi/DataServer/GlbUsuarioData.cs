using CorporeRMApi.Models.Global;

namespace CorporeRMApi.DataServer
{
    public class GlbUsuarioData : DataServer<GUsuario>
    {
        public GlbUsuarioData(CorporeRMApiClient corporeRMApiClient) : base(corporeRMApiClient, nameof(GlbUsuarioData))
        {
        }
    }
}