using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduHistoricoEnsSupData : DataServer<SHabilitacaoAluno>
    {
        public EduHistoricoEnsSupData(CorporeRMApiClient corporeRMApiClient) 
        : base(corporeRMApiClient, nameof(EduHistoricoEnsSupData))
        {
        }
    }
}