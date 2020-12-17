using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduHistDiscFacData : DataServer<SHistDiscFac>
    {
        public EduHistDiscFacData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduHistDiscFacData))
        {
        }
    }
}