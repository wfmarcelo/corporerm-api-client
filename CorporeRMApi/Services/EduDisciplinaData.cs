using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduDisciplinaData : DataServer<SDisciplina>
    {
        public EduDisciplinaData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduDisciplinaData))
        {
        }
    }
}