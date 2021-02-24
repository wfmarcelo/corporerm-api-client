using System;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models.Educacional
{
    public class STurma
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public short CodFilial { get; set; }
        [Required]
        public int IdPerLet { get; set; }
        [Required]
        [MaxLength(20)]
        public string CodTurma { get; set; }
        public int? CodTurno { get; set; }
        public string CodGrade { get; set; }
        [MaxLength(60)]
        public string Nome { get; set; }
        public string CodCurso { get; set; }

        public override bool Equals(object obj)
        {
            var turma = obj as STurma;

            if (turma == null)
            {
                return false;
            }

            return
                this.CodColigada == turma.CodColigada &&
                this.CodFilial == turma.CodFilial &&
                this.IdPerLet == turma.IdPerLet &&
                this.CodTurma == turma.CodTurma;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, CodColigada, CodFilial, IdPerLet, CodTurma, CodTurno, CodGrade, Nome);
        }
    }
}