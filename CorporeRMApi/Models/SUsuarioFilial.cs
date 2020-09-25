using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models
{
    public class SUsuarioFilial
    {
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public short CodTipoCurso { get; set; }
        [Required]
        public short CodFilial { get; set; }
        [Required]
        [MaxLength(20)]
        public string CodUsuario { get; set; }
        public string DescFilial { get; set; }
        [Required]
        [MaxLength(2)]
        public string Acesso { get; set; }
    }
}