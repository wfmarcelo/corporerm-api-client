using System;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models.Educacional
{
    public class SHistDiscFac
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public string RA { get; set; }
        [Required]
        public string CodDisc { get; set; }
        [Required]
        public int IdPerLet { get; set; }
        [Required]
        public int IdHabilitacaoFilial { get; set; }
        [Display(Name = "Instituição")]
        public int? CodInst { get; set; }
        [Required]
        [Display(Name = "Situação")]
        public int CodStatus { get; set; }
        [Display(Name = "Carga Horária")]
        public decimal? CargaHoraria { get; set; }
        public decimal? Nota { get; set; }
        public int? Faltas { get; set; }
        public string Conceito { get; set; }
        public string Observacao { get; set; }
        [Display(Name = "Créditos")]
        public decimal NumCreditos { get; set; }
        [Display(Name = "Disciplina")]
        public string NomeDisciplina { get; set; }
        [Display(Name = "Período Letivo")]
        public string DescPerLet { get; set; }
        public string Exclusivo { get; set; }
        public string CargaHorariaHora { get; set; }       
        public string ConceitoECTS { get; set; }

        public override bool Equals(object obj)
        {
            var histDiscFac = obj as SHistDiscFac;

            if (histDiscFac == null)
            {
                return false;
            }

            return
                this.CodColigada == histDiscFac.CodColigada &&
                this.RA == histDiscFac.RA &&
                this.CodDisc == histDiscFac.CodDisc &&
                this.IdPerLet == histDiscFac.IdPerLet &&
                this.IdHabilitacaoFilial == histDiscFac.IdHabilitacaoFilial &&
                this.CodStatus == histDiscFac.CodStatus;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(CodColigada);
            hash.Add(RA);
            hash.Add(CodDisc);
            hash.Add(IdPerLet);
            hash.Add(IdHabilitacaoFilial);
            hash.Add(CodInst);
            hash.Add(CodStatus);
            hash.Add(CargaHoraria);
            hash.Add(Nota);
            hash.Add(Faltas);
            hash.Add(Conceito);
            hash.Add(Observacao);
            hash.Add(NumCreditos);
            hash.Add(NomeDisciplina);
            hash.Add(DescPerLet);
            hash.Add(Exclusivo);
            hash.Add(CargaHorariaHora);
            hash.Add(ConceitoECTS);
            return hash.ToHashCode();
        }
    }
}