using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models.Educacional
{
    public class SInstituicao
    {
        public string Id { get; set; }        
        [Required]
        public int CodInst { get; set; }
        [Required]
        [MaxLength(60)]
        public string Nome { get; set; }
        [MaxLength(60)]
        public string NomeFantasia { get; set; }
        [MaxLength(32)]
        public string Cidade { get; set; }
        [MaxLength(2)]
        public string UF { get; set; }
        [MaxLength(80)]
        public string Diretor { get; set; }
        [MaxLength(1)]
        public string Conveniada { get; set; }
        [MaxLength(1)]
        public string TipoInst { get; set; }
        [MaxLength(20)]
        public string CodEMEC { get; set; }
        [MaxLength(20)]
        public string CNPJ { get; set; }
        [MaxLength(140)]
        public string Logradouro { get; set; }
        [MaxLength(8)]
        public string Numero { get; set; }
        [MaxLength(60)]
        public string Complemento { get; set; }
        [MaxLength(80)]
        public string Bairro { get; set; }
        [MaxLength(9)]
        public string CEP { get; set; }
    }
}