using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models.Educacional
{
    public class SHabilitacaoFilial
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public int IdHabilitacaoFilial { get; set; }
        [Required]
        public int CodTurno { get; set; }
        [Required]
        public short CodFilial { get; set; }
        [Required]
        [MaxLength(10)]
        public string CodCurso { get; set; }
        [Required]
        [MaxLength(10)]
        public string CodHabilitacao { get; set; }
        [Required]
        [MaxLength(10)]
        public string CodGrade { get; set; }
        [MaxLength(25)]
        public string CodCCusto { get; set; }
        [MaxLength(25)]
        public string CodDepartamento { get; set; }
        [MaxLength(1)]
        public string Ativo { get; set; }
        [Required]
        public short CodTipoCurso { get; set; }
        public string Curso { get; set; }
        public string Turno { get; set; }
        public string Habilitacao { get; set; }
        [MaxLength(255)]
        public string Grade { get; set; }
        [MaxLength(60)]
        public string EmailCoordenacao { get; set; }
        [MaxLength(1)]
        public string ExcluiPagtoCartaoCredito { get; set; }
        public string DecretoCurso { get; set; }
        public string DescricaoCurso { get; set; }
        public string DecretoHabilitacao { get; set; }
        [MaxLength(60)]
        public string DescricaoHabilitacao { get; set; }
        [MaxLength(60)]
        public string EmailTCC { get; set; }
        public int? IdCursoMEC { get; set; }
        public string NomeFilial { get; set; }
        public string DesCursoMEC { get; set; }

    }
}