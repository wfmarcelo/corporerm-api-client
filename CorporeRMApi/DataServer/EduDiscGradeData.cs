using CorporeRMApi.Models;
using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.DataServer
{
    public class EduDiscGradeData : DataServer<SDiscGrade>
    {
        public EduDiscGradeData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduDiscGradeData))
        {
        }
    }
}