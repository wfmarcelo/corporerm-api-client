using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models
{
    public class GETD
    {
        public string Id { get; set; }
        [Required]
        [MaxLength(2)]
        public string CodETD { get; set; }
        [MaxLength(40)]
        public string Nome { get; set; }
        [MaxLength(1)]
        public string Nacional { get; set; }
        [MaxLength(4)]
        public string CodigoSinief { get; set; }
        public short? IdPais { get; set; }
        [MaxLength(60)]
        public string Descricao { get; set; }
    }
}