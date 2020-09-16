using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models
{
    public class GUsuario
    {
        [Required]
        [MaxLength(20)]
        public string CodUsuario { get; set; }
        [MaxLength(45)]
        public string Nome { get; set; }
        [MaxLength(60)]
        public string Email { get; set; }
        public IList<GPermis> GPermis { get; set; }
    }

    public class GPermis
    {
        [Required]
        public short CodColigada { get; set; }
        [Required]
        [MaxLength(20)]
        public string CodUsuario { get; set; }
        [Required]
        [MaxLength(1)]
        public string CodSistema { get; set; }
        [Required]
        [MaxLength(15)]
        public string CodPeril { get; set; }
        [Required]
        public short Indice { get; set; }
    }
}