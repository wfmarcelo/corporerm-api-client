using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduGradeData : DataServer<SGrade>
    {
        public EduGradeData(CorporeRMApiClient corporeRMApiClient) 
        : base(corporeRMApiClient, nameof(EduGradeData))
        {
        }
    }
}