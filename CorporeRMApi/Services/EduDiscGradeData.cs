using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduDiscGradeData : DataServer<SDiscGrade>
    {
        public EduDiscGradeData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduDiscGradeData))
        {
        }
    }
}