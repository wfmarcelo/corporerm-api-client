using CorporeRMApi.Models;
using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.DataServer
{
    public class EduTurmaDiscData : DataServer<STurmaDisc>
    {
        public EduTurmaDiscData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduTurmaDiscData))
        {
        }
    }
}