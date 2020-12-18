using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduInstituicaoData : DataServer<SInstituicao>
    {
        public EduInstituicaoData(CorporeRMApiClient corporeRMApiClient) 
        : base(corporeRMApiClient, nameof(EduInstituicaoData))
        {
        }
    }
}