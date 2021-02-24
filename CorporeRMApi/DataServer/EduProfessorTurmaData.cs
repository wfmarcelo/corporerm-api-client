using CorporeRMApi.Models;
using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.DataServer
{
    public class EduProfessorTurmaData : DataServer<SProfessorTurma>
    {
        public EduProfessorTurmaData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduProfessorTurmaData))
        {
        }
    }
}