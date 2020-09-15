using System;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models
{
    public class SProfessorTurma
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public int IdProfessorTurma { get; set; }
        [Required]
        public string CodProf { get; set; }
        [MaxLength(20)]
        public string CodTurma { get; set; }
        public int? IdPerLet { get; set; }
        [MaxLength(20)]
        public string CodDisc { get; set; }

        public override bool Equals(object obj)
        {
            var professorTurma = obj as SProfessorTurma;

            if (professorTurma == null)
            {
                return false;
            }

            return
                this.CodColigada == professorTurma.CodColigada &&
                this.IdProfessorTurma == professorTurma.IdProfessorTurma;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, CodColigada, IdProfessorTurma, CodProf, CodTurma, IdPerLet, CodDisc);
        }
    }
}