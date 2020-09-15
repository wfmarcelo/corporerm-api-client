using CorporeRMApi.Models;

namespace CorporeRMApi.Services
{
    public class EduComissaoCoordenadoraData : DataServer<SCoordenador>
    {
        public EduComissaoCoordenadoraData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduComissaoCoordenadoraData))
        {
        }
    }
}