using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduHorarioTurma : DataServer<SHorarioTurma>
    {
        public EduHorarioTurma(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduHorarioTurma))
        {
        }
    }
}