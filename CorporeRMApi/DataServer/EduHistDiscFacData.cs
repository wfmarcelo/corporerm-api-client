using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.DataServer
{
    public class EduHistDiscFacData : DataServer<SHistDiscFac>
    {
        public EduHistDiscFacData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduHistDiscFacData))
        {
        }
    }
}