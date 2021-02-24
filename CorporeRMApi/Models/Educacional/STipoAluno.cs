using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models.Educacional
{
    public class STipoAluno
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public short CodTipoAluno { get; set; }
        [Required]
        [MaxLength(60)]
        public string Descricao { get; set; }
        [Required]
        public short CodTipoCurso { get; set; }
    }
}