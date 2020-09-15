using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduMatriculaData : DataServer<SMatricula>
    {
        public EduMatriculaData(CorporeRMApiClient corporeRMApiClient) : base(corporeRMApiClient, nameof(EduMatriculaData))
        {
        }
    }
}