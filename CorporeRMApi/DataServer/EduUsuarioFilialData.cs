using CorporeRMApi.Models;
using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.DataServer
{
    public class EduUsuarioFilialData : DataServer<SUsuarioFilial>
    {
        public EduUsuarioFilialData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduUsuarioFilialData))
        {
        }
    }
}