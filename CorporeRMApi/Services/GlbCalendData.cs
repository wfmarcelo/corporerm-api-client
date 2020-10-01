using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class GlbCalendData : DataServer<GCalend>
    {
        public GlbCalendData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(GlbCalendData))
        {
        }
    }
}