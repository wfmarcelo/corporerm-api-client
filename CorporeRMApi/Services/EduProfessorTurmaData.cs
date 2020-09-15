using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduProfessorTurmaData : DataServer<SProfessorTurma>
    {
        public EduProfessorTurmaData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduProfessorTurmaData))
        {
        }
    }
}