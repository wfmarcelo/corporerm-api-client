using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.DataServer
{
    public class EduHabilitacaoFilialData : DataServer<SHabilitacaoFilial>
    {
        public EduHabilitacaoFilialData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduHabilitacaoFilialData))
        {
        }
    }
}