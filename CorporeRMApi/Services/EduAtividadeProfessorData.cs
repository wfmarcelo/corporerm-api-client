using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduAtividadeProfessorData : DataServer<SAtividadeProfessor>
    {
        public EduAtividadeProfessorData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduAtividadeProfessorData))
        {
        }
    }
}