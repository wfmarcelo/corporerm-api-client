using System;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models.Educacional
{
    public class SEtapas
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public int IdTurmaDisc { get; set; }
        [Required]
        public short CodEtapa { get; set; }
        [Required]
        [MaxLength(1)]
        [Display(Name = "Tipo")]
        public string TipoEtapa { get; set; }
        [MaxLength(1)]
        public string Aplicacao { get; set; }
        [MaxLength(8)]
        public string CodFormulaNota { get; set; }
        [MaxLength(8)]
        public string CodFormulaFalta { get; set; }
        public short? IdGrupo { get; set; }
        [MaxLength(60)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Nota Máxima")]
        public decimal? PontDist { get; set; }
        [Display(Name = "Média")]
        public decimal? Media { get; set; }
        public decimal? FreqMin { get; set; }
        public DateTime? DtInicio { get; set; }
        public DateTime? DtFim { get; set; }
        public short? AulasDadas { get; set; }
        public short? AulasPrevistas { get; set; }
        [Display(Name = "Limite Digitação")]
        public DateTime? DtLimiteDigitacao { get; set; }
        [MaxLength(1)]
        public string ConceitoGrafico { get; set; }
        [MaxLength(1)]
        public string DigAulasDadas { get; set; }
        [MaxLength(1)]
        public string EtapaFinal { get; set; }
        [MaxLength(1)]
        public string ExibeNaWeb { get; set; }
        [MaxLength(1)]
        public string ExibeNoGrafico { get; set; }
        public DateTime? DtInicioDigitacao { get; set; }
        public DateTime? DtLimiteContPrevisto { get; set; }
        public DateTime? DtLimiteContEfetivo { get; set; }
        [MaxLength(1)]
        public string DisponivelAlunos { get; set; }
        [MaxLength(1)]
        [Display(Name = "Encerrada")]
        public string EtapaEncerrada { get; set; }
        [MaxLength(1)]
        public string PermiteDigitacao { get; set; }
        [MaxLength(50)]
        public string Agrupador { get; set; }
        [MaxLength(10)]
        public string NomeReduzido { get; set; }
    }
}