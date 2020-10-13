using System;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models
{
    public class SHorarioProfessor
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public int IdProfessorTurma { get; set; }
        [Required]
        public int IdHorarioTurma { get; set; }
        [MaxLength(10)]
        public string CodProf { get; set; }
        [MaxLength(45)]
        public string Nome { get; set; }
        public string IdTurmaDisc { get; set; }
        public string DesconsideraPonto { get; set; }
        public int? CodHor { get; set; }
        public DateTime? DataInicial { get; set; }
        public DateTime? DataFinal { get; set; }

        public override bool Equals(object obj)
        {   
            var horarioProfessor = obj as SHorarioProfessor;

            if (horarioProfessor == null)
            {
                return false;
            }

            return this.CodColigada == horarioProfessor.CodColigada &&
                this.IdProfessorTurma == horarioProfessor.IdProfessorTurma &&
                this.IdHorarioTurma == horarioProfessor.IdHorarioTurma;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(CodColigada);
            hash.Add(IdProfessorTurma);
            hash.Add(IdHorarioTurma);
            hash.Add(CodProf);
            hash.Add(Nome);
            hash.Add(IdTurmaDisc);
            hash.Add(DesconsideraPonto);
            hash.Add(CodHor);
            hash.Add(DataInicial);
            hash.Add(DataFinal);
            return hash.ToHashCode();
        }
    }
}