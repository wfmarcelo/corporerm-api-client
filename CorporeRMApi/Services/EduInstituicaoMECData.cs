using CorporeRMApi.Models;
using CorporeRMApi.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporeRMApi.Services
{
    public class EduInstituicaoMECData : DataServer<SInstituicaoMEC>
    {
        public EduInstituicaoMECData(CorporeRMApiClient corporeRMApiClient) : base(corporeRMApiClient, nameof(EduInstituicaoMECData))
        {
        }
    }
}
