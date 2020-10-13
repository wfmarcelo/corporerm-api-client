using Newtonsoft.Json;

namespace CorporeRMApi.Models
{
    public class Context
    {
        [JsonProperty("$id")]
        public string Id { get; set; }
        public Params _params { get; set; }
        public int Environment { get; set; }
    }

    public class Params
    {
        [JsonProperty("$EXERCICIOFISCAL")]
        public int ExercicioFiscal { get; set; } = 1;
        [JsonProperty("$CODLOCPRT")]
        public int CodLocPrt { get; set; } = -1;
        [JsonProperty("$CODTIPOCURSO")]
        public short CodTipoCurso { get; set; } = 1;
        [JsonProperty("$EDUTIPOUSR")]
        public string EduTipoUsr { get; set; } = "-1";
        [JsonProperty("$CODUNIDADEBIB")]
        public int CodUnidadeBib { get; set; } = -1;
        [JsonProperty("$CODCOLIGADA")]
        public short CodColigada { get; set; } = 1;
        [JsonProperty("$RHTIPOUSR")]
        public string RHTipoUsr { get; set; } = "-1";
        [JsonProperty("$CODIGOEXTERNO")]
        public string CodigoExterno { get; set; } = "-1";
        [JsonProperty("$CODSISTEMA")]
        public string CodSistema { get; set; } = "G";
        [JsonProperty("$CODUSUARIOSERVICO")]
        public string CodUsuarioServico { get; set; } = "";
        [JsonProperty("$IDPRJ")]
        public int IdPrj { get; set; } = -1;
        [JsonProperty("$CHAPAFUNCIONARIO")]
        public string ChapaFuncionario { get; set; } = "-1";
        [JsonProperty("$CODFILIAL")]
        public int CodFilial { get; set; } = 1;
    }
}