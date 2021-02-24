using CorporeRMApi.Models;
using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.DataServer
{
    public class EduTipoAlunoData : DataServer<STipoAluno>
    {
        public EduTipoAlunoData(CorporeRMApiClient corporeRMApiClient) : base(corporeRMApiClient, nameof(EduTipoAlunoData))
        {
        }
    }
}