using CorporeRMApi.Models;
using CorporeRMApi.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporeRMApi.Services
{
    public class EduMatricPLData : DataServer<SMatricPL>
    {
        public EduMatricPLData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduMatricPLData))
        {
        }
    }
}
