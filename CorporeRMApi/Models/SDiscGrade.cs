using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models
{
    public class SDiscGrade
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
        public short CodPeriodo { get; set; }
        [Required]
        [MaxLength(20)]
        public string CodDisc { get; set; }
        [Required]
        [MaxLength(2)]
        public string TipoDisc { get; set; }
        [MaxLength(60)]
        public string Descricao { get; set; }
        public decimal? CH { get; set; }
        public IList<SDiscGradeCompl> SDiscGradeCompl { get; set; }
        public string NomeDisciplina { get; set; }

        public override bool Equals(object obj)
        {
            var gradeDisciplina = obj as SDiscGrade;

            if (gradeDisciplina == null)
            {
                return false;
            }

            return
                this.CodColigada == gradeDisciplina.CodColigada &&
                this.CodCurso == gradeDisciplina.CodCurso &&
                this.CodHabilitacao == gradeDisciplina.CodHabilitacao &&
                this.CodGrade == gradeDisciplina.CodGrade &&
                this.CodPeriodo == gradeDisciplina.CodPeriodo &&
                this.CodDisc == gradeDisciplina.CodDisc;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(CodColigada);
            hash.Add(CodCurso);
            hash.Add(CodHabilitacao);
            hash.Add(CodGrade);
            hash.Add(CodPeriodo);
            hash.Add(CodDisc);
            hash.Add(TipoDisc);
            hash.Add(Descricao);
            hash.Add(CH);
            return hash.ToHashCode();
        }
    }

    public class SDiscGradeCompl
    {
        
        public string Id { get; set; }
        public string Parent_Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public string CodCurso { get; set; }
        [Required]
        public string CodHabilitacao { get; set; }
        [Required]
        public string CodGrade { get; set; }
        [Required]
        public short CodPeriodo { get; set; }
        [Required]
        public string CodDisc { get; set; }
        public string Plano { get; set; }
        [Display(Name = "Ementa")]
        public string Ementa { get; set; }
        public string ExtNotas { get; set; }
        [Display(Name = "Objetivo Geral")]
        public string ObjetivoGeral { get; set; }
        [Display(Name = "Objetivo Específico")]
        public string ObjetivoEspecifico { get; set; }
        [Display(Name = "Relações Interdisciplinares")]
        public string RelInterDisc { get; set; }
        [Display(Name = "Habilidades Requeridas")]
        public string Habilidades { get; set; }
        [Display(Name = "Estratégias de Ensino")]
        public string Estrategias { get; set; }
        [Display(Name = "Sistema de Avaliação")]
        public string Avaliacao { get; set; }
        [Display(Name = "Bibliografia Básica")]
        public string BibBasica { get; set; }
        [Display(Name = "Bibliografia Complementar")]
        public string BibliCompl { get; set; }
        public string OL { get; set; }
        public string Tipo { get; set; }
    }
}