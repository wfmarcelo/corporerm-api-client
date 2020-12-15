using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduTipoAlunoData : DataServer<STipoAluno>
    {
        public EduTipoAlunoData(CorporeRMApiClient corporeRMApiClient) : base(corporeRMApiClient, nameof(EduTipoAlunoData))
        {
        }
    }
}