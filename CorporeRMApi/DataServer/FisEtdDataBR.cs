using CorporeRMApi.Models.Global;

namespace CorporeRMApi.DataServer
{
    public class FisEtdDataBR : DataServer<GETD>
    {
        public FisEtdDataBR(CorporeRMApiClient corporeRMApiClient) : base(corporeRMApiClient, nameof(FisEtdDataBR))
        {
        }
    }
}