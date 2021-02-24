using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.DataServer
{
    public class EduTurmaData : DataServer<STurma>
    {
        public EduTurmaData(CorporeRMApiClient corporeRMApiClient) : base(corporeRMApiClient, nameof(EduTurmaData))
        {
        }
    }
}