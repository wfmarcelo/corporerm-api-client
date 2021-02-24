using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.DataServer
{
    public class EduInstituicaoData : DataServer<SInstituicao>
    {
        public EduInstituicaoData(CorporeRMApiClient corporeRMApiClient) 
        : base(corporeRMApiClient, nameof(EduInstituicaoData))
        {
        }
    }
}