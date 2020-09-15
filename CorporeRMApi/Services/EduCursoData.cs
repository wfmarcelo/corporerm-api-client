using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduCursoData : DataServer<SCurso>
    {
        public EduCursoData(CorporeRMApiClient corporeRMApiClient) 
        : base(corporeRMApiClient, nameof(EduCursoData))
        {
        }
    }
}