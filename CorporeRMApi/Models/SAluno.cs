using System;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models
{
    public class SAluno
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        [MaxLength(20)]
        public string RA { get; set; }
        [Required]
        [MaxLength(120)]
        public string Nome { get; set; }
        [Required]
        public DateTime DtNascimento { get; set; }
        [Required]
        public int CodTipoCurso { get; set; }
        [MaxLength(14)]
        public string CPF { get; set; }
        [MaxLength(120)]
        public string NomeSocial { get; set; }
        [MaxLength(20)]
        public string CodUsuario { get; set; }
        [MaxLength(60)]
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            var aluno = obj as SAluno;

            if (aluno == null)
            {
                return false;
            }

            return 
                this.CodColigada == aluno.CodColigada &&
                this.RA == aluno.RA;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(CodColigada);
            hash.Add(RA);
            hash.Add(Nome);
            hash.Add(DtNascimento);
            hash.Add(CodTipoCurso);
            hash.Add(CPF);
            hash.Add(NomeSocial);
            hash.Add(CodUsuario);
            hash.Add(Email);
            return hash.ToHashCode();
        }
    }
}