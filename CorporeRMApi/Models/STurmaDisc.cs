using System;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models
{
    public class STurmaDisc
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public int IdTurmaDisc { get; set; }
        [Required]
        public short CodFilial { get; set; }
        [Required]
        [MaxLength(20)]
        public string CodTurma { get; set; }
        [Required]
        public int IdPerLet { get; set; }
        [Required]
        [MaxLength(20)]
        public string CodDisc { get; set; }
        [Required]
        public int CodTurno { get; set; }
        [Required]
        [MaxLength(1)]
        public string Ativa { get; set; }
        public int? IdTurmaDiscAntigo { get; set; }
        public string CodCurso { get; set; }
        public string CodGrade { get; set; }
        public DateTime? DtInicial { get; set; }
        public DateTime? DtFinal { get; set; }

        public override bool Equals(object obj)
        {
            var turmaDisciplina = obj as STurmaDisc;

            if (turmaDisciplina == null)
            {
                return false;
            }

            return
                this.CodColigada == turmaDisciplina.CodColigada &&
                this.IdTurmaDisc == turmaDisciplina.IdTurmaDisc;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(CodColigada);
            hash.Add(IdTurmaDisc);
            hash.Add(CodFilial);
            hash.Add(CodTurma);
            hash.Add(IdPerLet);
            hash.Add(CodDisc);
            hash.Add(CodTurno);
            hash.Add(Ativa);
            hash.Add(IdTurmaDiscAntigo);
            hash.Add(CodCurso);
            hash.Add(CodGrade);
            hash.Add(DtInicial);
            hash.Add(DtFinal);
            return hash.ToHashCode();
        }
    }
}