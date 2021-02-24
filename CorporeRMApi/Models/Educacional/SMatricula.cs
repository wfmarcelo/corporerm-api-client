using System;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models.Educacional
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
        public int? CodStatusRes { get; set; }
        public string CodSubturma { get; set; }
        public int? IdPerLet { get; set; }
        public int? IdHabilitacaoFilial { get; set; }
        public int? NumDiario { get; set; }
        public DateTime? DtMatricula { get; set; }
        [Display(Name = "Obs. Histórico")]
        [MaxLength(255)]
        public string ObsHistorico { get; set; }
        public string TipoMat { get; set; }
        public string CodDisc { get; set; }
        public string NomeDisc { get; set; }
        [MaxLength(20)]
        public string Usuario { get; set; }
        public short? CodMotivo { get; set; }
        public DateTime? DtAlteracao { get; set; }
        public DateTime? DtAlteracaoSist { get; set; }
        public double? NumCreditosCob { get; set; }
        public string TipoDisciplina { get; set; }
        public decimal? NumCreditos { get; set; }
        [Display(Name = "Nome")]
        public string NomeAluno { get; set; }
        public decimal? Nota { get; set; }
        public decimal? Falta { get; set; }
        public string CodConceito { get; set; }
        [MaxLength(10)]
        public string CodPerLet { get; set; }
        public int? IdTurmaDiscOrigem { get; set; }
        [MaxLength(1)]
        public string CobPosteriorMatric { get; set; }
        public int? IdTurmaDiscSubst { get; set; }
        public string Filial { get; set; }
        public string ConceitoECTS { get; set; }
        public int? CodFilial { get; set; }
        public int? CodTipoCurso { get; set; }
        [MaxLength(20)]
        public string CodTurma { get; set; }
        [MaxLength(30)]
        [Display(Name = "Situação")]
        public string NomeStatus { get; set; }
        public string NomeNivelEnsino { get; set; }
        public int? CodFilialTurmaDisc { get; set; }
        public string RecCreatedBy { get; set; }
        public DateTime? RecCreatedOn { get; set; }
        public string RecModifiedBy { get; set; }
        public DateTime? RecModifiedOn { get; set; }
        public string MatriculaIsolada { get; set; }

        public string GetMatricPLId()
        {
            return $"{CodColigada}$_${IdPerLet}$_${IdHabilitacaoFilial}$_${RA}";
        }

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