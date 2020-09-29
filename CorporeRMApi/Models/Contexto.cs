using System;

namespace CorporeRMApi.Models
{
    public class Contexto
    {
        public string CodUsuario { get; set; }
        public short? CodColigada { get; set; }
        public string CodSistema { get; set; }
        public DateTime? DataSistema { get; set; }
        public string CodUsuarioServico { get; set; }
        public int? CodFilial { get; set; }
        public int? IdPrj { get; set; }
        public int? CodTipoCurso { get; set; }
        public int? CodUnidadeBib { get; set; }
        public int? CodLocPrt { get; set; }
        public string EduTipoUsr { get; set; }
        public string RhTipoUsr { get; set; }
        public string ChapaFuncionario { get; set; }
        public string CodigoExterno { get; set; }
        public string ExercicioFiscal { get; set; }
    }
}