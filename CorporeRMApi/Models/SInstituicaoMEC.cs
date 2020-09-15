using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models
{
    public class SInstituicaoMEC
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public int IdInstituicaoMEC { get; set; }
        [Required]
        [MaxLength(12)]
        public string CodInepInstituicao { get; set; }
        [Required]
        [MaxLength(100)]
        public string NomeInstituicao { get; set; }
        [Required]
        public short SituacaoFuncionamento { get; set; }
        [Required]
        public short DepAdmin { get; set; }
        [Required]
        public short Zona { get; set; }
        [Required]
        public short LocalDiferenciado { get; set; }
    }
}