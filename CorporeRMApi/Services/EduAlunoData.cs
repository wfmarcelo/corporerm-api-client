using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduAlunoData : DataServer<SAluno>
    {
        public EduAlunoData(CorporeRMApiClient corporeRMApiClient) : base(corporeRMApiClient, nameof(EduAlunoData))
        {
        }
    }
}