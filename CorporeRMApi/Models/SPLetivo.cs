using System;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models
{
    public class SPLetivo
    {
        // CodColigada$_$IdPerLet
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public int IdPerLet { get; set; }
        [Required]
        [MaxLength(10)]
        public string CodPerLet { get; set; }
        [Required]
        public short CodFilial { get; set; }
        [Required]
        public int CodTipoCurso { get; set; }
        [Required]
        [MaxLength(1)]
        public string ExibirPortal { get; set; }
        public DateTime? DtInicio { get; set; }
        public DateTime? DtFim { get; set; }
        public DateTime? DtPrevista { get; set; }
        [MaxLength(60)]
        public string Descricao { get; set; }
        [MaxLength(60)]
        public string NomeTipoCurso { get; set; }
        [MaxLength(2000)]
        public string Obs { get; set; }

        public override bool Equals(object obj)
        {
            var periodoLetivo = obj as SPLetivo;

            if (periodoLetivo == null)
            {
                return false;
            }

            return
                this.CodColigada == periodoLetivo.CodColigada &&
                this.IdPerLet == periodoLetivo.IdPerLet;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(CodColigada);
            hash.Add(IdPerLet);
            hash.Add(CodPerLet);
            hash.Add(CodFilial);
            hash.Add(CodTipoCurso);
            hash.Add(ExibirPortal);
            hash.Add(DtInicio);
            hash.Add(DtFim);
            hash.Add(DtPrevista);
            return hash.ToHashCode();
        }
    }
}