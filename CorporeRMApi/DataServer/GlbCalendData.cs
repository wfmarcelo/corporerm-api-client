using CorporeRMApi.Models;
using CorporeRMApi.Models.Global;

namespace CorporeRMApi.DataServer
{
    public class GlbCalendData : DataServer<GCalend>
    {
        public GlbCalendData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(GlbCalendData))
        {
        }
    }
}