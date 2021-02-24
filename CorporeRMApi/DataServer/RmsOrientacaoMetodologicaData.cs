using CorporeRMApi.Models.ZMD;

namespace CorporeRMApi.DataServer
{
    public class RmsOrientacaoMetodologicaData : DataServer<ZmdOriMet>
    {
        public RmsOrientacaoMetodologicaData(CorporeRMApiClient corporeRMApiClient) : base(corporeRMApiClient, "RMSPRJ4079360Server")
        {
        }
    }
}