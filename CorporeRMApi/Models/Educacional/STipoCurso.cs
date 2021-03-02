using System;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models.Educacional
{
    public class STipoCurso
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public short CodTipoCurso { get; set; }
        [Required]
        [MaxLength(60)]
        public string Nome { get; set; }
        [Required]
        public string Apresentacao { get; set; }
        [MaxLength(20)]
        public string CFGMatricula { get; set; }
        [MaxLength(60)]
        public string Email { get; set; }
        [MaxLength(1)]
        public string UsaEducaCenso { get; set; }

        public override bool Equals(object obj)
        {
            var tipoCurso = obj as STipoCurso;

            if (tipoCurso == null)
            {
                return false;
            }
            
            return 
                CodColigada == tipoCurso.CodColigada &&
                CodTipoCurso == tipoCurso.CodTipoCurso;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, CodColigada, CodTipoCurso, Nome, Apresentacao, CFGMatricula, Email, UsaEducaCenso);
        }
    }
}