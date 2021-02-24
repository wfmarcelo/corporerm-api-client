using CorporeRMApi.Models;
using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.DataServer
{
    public class EduHistoricoEnsSupData : DataServer<SHabilitacaoAluno>
    {
        public EduHistoricoEnsSupData(CorporeRMApiClient corporeRMApiClient) 
        : base(corporeRMApiClient, nameof(EduHistoricoEnsSupData))
        {
        }
    }
}