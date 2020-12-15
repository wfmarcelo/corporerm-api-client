using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class FisEtdDataBR : DataServer<GETD>
    {
        public FisEtdDataBR(CorporeRMApiClient corporeRMApiClient) : base(corporeRMApiClient, nameof(FisEtdDataBR))
        {
        }
    }
}