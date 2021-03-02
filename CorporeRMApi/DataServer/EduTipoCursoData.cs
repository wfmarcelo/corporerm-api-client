using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.DataServer
{
    public class EduTipoCursoData : DataServer<STipoCurso>
    {
        public EduTipoCursoData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduTipoCursoData))
        {
        }
    }
}