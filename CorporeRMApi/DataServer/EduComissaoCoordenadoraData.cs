using CorporeRMApi.Models.Educacional;

namespace CorporeRMApi.DataServer
{
    public class EduComissaoCoordenadoraData : DataServer<SCoordenador>
    {
        public EduComissaoCoordenadoraData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduComissaoCoordenadoraData))
        {
        }
    }
}