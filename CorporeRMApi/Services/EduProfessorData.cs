using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduProfessorData : DataServer<SProfessor>
    {
        public EduProfessorData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduProfessorData))
        {
        }
    }
}