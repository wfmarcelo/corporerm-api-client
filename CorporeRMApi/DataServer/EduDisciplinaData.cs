using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.DataServer
{
    public class EduDisciplinaData : DataServer<SDisciplina>
    {
        public EduDisciplinaData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduDisciplinaData))
        {
        }
    }
}