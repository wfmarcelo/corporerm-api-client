using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.DataServer
{
    public class EduCursoData : DataServer<SCurso>
    {
        public EduCursoData(CorporeRMApiClient corporeRMApiClient) 
        : base(corporeRMApiClient, nameof(EduCursoData))
        {
        }
    }
}