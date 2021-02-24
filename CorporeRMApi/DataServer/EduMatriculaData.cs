using CorporeRMApi.Models;
using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.DataServer
{
    public class EduMatriculaData : DataServer<SMatricula>
    {
        public EduMatriculaData(CorporeRMApiClient corporeRMApiClient) : base(corporeRMApiClient, nameof(EduMatriculaData))
        {
        }
    }
}