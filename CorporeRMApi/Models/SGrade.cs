using System;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models
{
    public class SGrade
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        [MaxLength(10)]
        public string CodCurso { get; set; }
        [Required]
        [MaxLength(10)]
        public string CodHabilitacao { get; set; }
        [Required]
        [MaxLength(10)]
        public string CodGrade { get; set; }
        [Required]
        [MaxLength(1)]
        public string Regime { get; set; }
        [MaxLength(255)]
        public string Descricao { get; set; }
        public decimal? CargaHoraria { get; set; }
        [MaxLength(1)]
        public string Status { get; set; }

        public override bool Equals(object obj)
        {
            var grade = obj as SGrade;

            if (grade == null)
            {
                return false;
            }

            return 
                this.CodColigada == grade.CodColigada &&
                this.CodCurso == grade.CodCurso &&
                this.CodHabilitacao == grade.CodHabilitacao &&
                this.CodGrade == grade.CodGrade;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(CodColigada);
            hash.Add(CodCurso);
            hash.Add(CodHabilitacao);
            hash.Add(CodGrade);
            hash.Add(Regime);
            hash.Add(Descricao);
            hash.Add(CargaHoraria);
            hash.Add(Status);
            return hash.ToHashCode();
        }
    }
}