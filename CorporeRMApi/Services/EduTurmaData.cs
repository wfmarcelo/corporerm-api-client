using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduTurmaData : DataServer<STurma>
    {
        public EduTurmaData(CorporeRMApiClient corporeRMApiClient) : base(corporeRMApiClient, nameof(EduTurmaData))
        {
        }
    }
}