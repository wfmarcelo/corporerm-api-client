using System;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models
{
    public class SMatricula
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public int IdTurmaDisc { get; set; }
        [Required]
        [MaxLength(20)]
        public string RA { get; set; }
        [Required]
        public int CodStatus { get; set; }
        public int? IdHabilitacaoFilial { get; set; }
        public int? IdPerLet { get; set; }
        public string CodDisc { get; set; }
        [MaxLength(20)]
        public string CodTurma { get; set; }
        public string TipoMat { get; set; }

        public override bool Equals(object obj)
        {
            var matricula = obj as SMatricula;

            if (matricula == null)
            {
                return false;
            }

            return
                this.CodColigada == matricula.CodColigada &&
                this.IdTurmaDisc == matricula.IdTurmaDisc &&
                this.RA == matricula.RA;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(CodColigada);
            hash.Add(IdTurmaDisc);
            hash.Add(RA);
            hash.Add(CodStatus);
            hash.Add(IdPerLet);
            hash.Add(CodDisc);
            hash.Add(CodTurma);
            hash.Add(TipoMat);
            return hash.ToHashCode();
        }
    }
}