using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduTurmaDiscData : DataServer<STurmaDisc>
    {
        public EduTurmaDiscData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduTurmaDiscData))
        {
        }
    }
}