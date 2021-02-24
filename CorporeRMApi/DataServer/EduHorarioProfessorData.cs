using CorporeRMApi.Models;
using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.DataServer
{
    public class EduHorarioProfessorData : DataServer<SHorarioProfessor>
    {
        public EduHorarioProfessorData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduHorarioProfessorData))
        {
        }
    }
}