using System;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models.Educacional
{
    public class SDisciplina
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        [MaxLength(20)]
        public string CodDisc { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        [Required]
        public int CodTipoCurso { get; set; }
        [Required]
        [MaxLength(1)]
        public string TipoNota { get; set; }
        [Display(Name = "Carga horária")]
        public decimal? CH { get; set; }

        public string GetNomeComCodigo()
        {   
            return $"{Nome} ({CodDisc})";
        }

        public override bool Equals(object obj)
        {
            var disciplina = obj as SDisciplina;

            if (disciplina == null)
            {
                return false;
            }

            return
                this.CodColigada == disciplina.CodColigada &&
                this.CodDisc == disciplina.CodDisc;
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(Id, CodColigada, CodDisc, Nome, CodTipoCurso, TipoNota, CH);
        }
    }
}