using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.DataServer
{
    public class EduGradeData : DataServer<SGrade>
    {
        public EduGradeData(CorporeRMApiClient corporeRMApiClient) 
        : base(corporeRMApiClient, nameof(EduGradeData))
        {
        }
    }
}