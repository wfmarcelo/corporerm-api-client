using System.Text.Json.Serialization;

namespace CorporeRMApi.Models
{
    public class Context
    {
        [JsonPropertyName("$id")]
        public string Id { get; set; }
        public Params _params { get; set; }
        public int Environment { get; set; }
    }

    public class Params
    {
        [JsonPropertyName("$EXERCICIOFISCAL")]
        public int ExercicioFiscal { get; set; } = 1;
        [JsonPropertyName("$CODLOCPRT")]
        public int CodLocPrt { get; set; } = -1;
        [JsonPropertyName("$CODTIPOCURSO")]
        public short CodTipoCurso { get; set; } = 1;
        [JsonPropertyName("$EDUTIPOUSR")]
        public string EduTipoUsr { get; set; } = "-1";
        [JsonPropertyName("$CODUNIDADEBIB")]
        public int CodUnidadeBib { get; set; } = -1;
        [JsonPropertyName("$CODCOLIGADA")]
        public short CodColigada { get; set; } = 1;
        [JsonPropertyName("$RHTIPOUSR")]
        public string RHTipoUsr { get; set; } = "-1";
        [JsonPropertyName("$CODIGOEXTERNO")]
        public string CodigoExterno { get; set; } = "-1";
        [JsonPropertyName("$CODSISTEMA")]
        public string CodSistema { get; set; } = "G";
        [JsonPropertyName("$CODUSUARIOSERVICO")]
        public string CodUsuarioServico { get; set; } = "";
        [JsonPropertyName("$IDPRJ")]
        public int IdPrj { get; set; } = -1;
        [JsonPropertyName("$CHAPAFUNCIONARIO")]
        public string ChapaFuncionario { get; set; } = "-1";
        [JsonPropertyName("$CODFILIAL")]
        public int CodFilial { get; set; } = 1;
        [JsonPropertyName("$CODUSUARIO")]
        public string CodUsuario { get; set; }
    }
}