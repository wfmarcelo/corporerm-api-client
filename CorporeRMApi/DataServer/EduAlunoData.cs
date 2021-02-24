using System.Threading.Tasks;
using CorporeRMApi.Models.Educacional;
using Uniarp.Util;

namespace CorporeRMApi.DataServer
{
    public class EduAlunoData : DataServer<SAluno>
    {
        public EduAlunoData(CorporeRMApiClient corporeRMApiClient) : base(corporeRMApiClient, nameof(EduAlunoData))
        {
        }
        
    }
}