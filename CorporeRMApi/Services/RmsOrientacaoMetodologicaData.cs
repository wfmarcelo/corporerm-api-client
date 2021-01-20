using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class RmsOrientacaoMetodologicaData : DataServer<ZmdOriMet>
    {
        public RmsOrientacaoMetodologicaData(CorporeRMApiClient corporeRMApiClient) : base(corporeRMApiClient, "RMSPRJ4079360Server")
        {
        }
    }
}