using System;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models
{
    public class SProfessor
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        [MaxLength(10)]
        public string CodProf { get; set; }
        public int CodPessoa { get; set; }
        [Required]
        [MaxLength(120)]
        public string Nome { get; set; }
        [MaxLength(120)]
        public string NomeSocial { get; set; }
        [Required]
        public DateTime DtNascimento { get; set; }
        [Required]
        public string Naturalidade { get; set; }
        [Required]
        public string EstadoNatal { get; set; }
        public string CodUsuario { get; set; }
        public string Email { get; set; }
        [MaxLength(14)]
        public string CPF { get; set; }

        public override bool Equals(object obj)
        {
            var professor = obj as SProfessor;

            if (professor == null)
            {
                return false;
            }

            return
                this.CodColigada == professor.CodColigada &&
                this.CodProf == professor.CodProf;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(CodColigada);
            hash.Add(CodProf);
            hash.Add(CodPessoa);
            hash.Add(Nome);
            hash.Add(NomeSocial);
            hash.Add(DtNascimento);
            hash.Add(Naturalidade);
            hash.Add(EstadoNatal);
            hash.Add(CodUsuario);
            hash.Add(Email);
            hash.Add(CPF);
            return hash.ToHashCode();
        }
    }
}