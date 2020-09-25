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
        [Display(Name="Código Professor")]
        public string CodProf { get; set; }
        [MaxLength(20)]
        public string CodTurma { get; set; }
        public int? IdPerLet { get; set; }
        [MaxLength(20)]
        public string CodDisc { get; set; }
        [MaxLength(100)]
        public string Nome { get; set; }
        [MaxLength(1)]
        [Display(Name = "Tipo professor")]
        public string TipoProf { get; set; }
        public int IdTurmaDisc { get; set; }
        [Display(Name="Data Inicial")]
        public DateTime DtInicio { get; set; }
        [Display(Name="Data Final")]
        public DateTime? DtFim { get; set; }

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