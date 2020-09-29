using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduHorarioProfessorData : DataServer<SHorarioProfessor>
    {
        public EduHorarioProfessorData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduHorarioProfessorData))
        {
        }
    }
}