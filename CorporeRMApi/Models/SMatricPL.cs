using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CorporeRMApi.Models
{
    public class SMatricPL
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        [MaxLength(20)]
        public string RA { get; set; }
        [Required]
        public int IdHabilitacaoFilial { get; set; }
        [Required]
        public int IdPerLet { get; set; }
        public short? CodFilial { get; set; }
        public short? CodTipoMat { get; set; }
        [MaxLength(20)]
        public string CodTurma { get; set; }
        public int? CodStatusRes { get; set; }
        [Required]
        public int CodStatus { get; set; }
        [Required]
        public DateTime DtMatricula { get; set; }
        public DateTime? DtResultado { get; set; }
        [MaxLength(15)]
        public string Identificador { get; set; }
        [MaxLength(20)]
        public string NumCarteira { get; set; }
        [MaxLength(20)]
        public string ViaCarteira { get; set; }
        public int? Periodo { get; set; }
        public int? NumAluno { get; set; }
        [MaxLength(1)]
        public string CarteiraEmitida { get; set; }
        [MaxLength(120)]
        [Display(Name = "Aluno")]
        public string NomeAluno { get; set; }
        public DateTime? DtAlteracao { get; set; }
        [MaxLength(20)]
        public string Usuario { get; set; }
        public short? CodMotivo { get; set; }
        public string SelInstEnade { get; set; }
        public string SelMecEnade { get; set; }
        public DateTime? DtProvaEnade { get; set; }
        public string CompareceuEnade { get; set; }
        public string ObsEnade { get; set; }
        public short? CodTipoCurso { get; set; }
        public DateTime? DtSolicitacaoAlteracao { get; set; }
        public int? CodInstDestino { get; set; }
        public short? CodMotivoTransferencia { get; set; }
        public decimal? CR { get; set; }
        public DateTime? DtMatriculaEncerra { get; set; }
        public string CodUsuario { get; set; }
        public string Email { get; set; }
        public DateTime? DtNascimento { get; set; }
        public string TipoCurso { get; set; }
        [MaxLength(30)]
        public string NomeStatusRes { get; set; }
        [MaxLength(60)]
        public string NomeTipoMat { get; set; }
        public int? CodTurno { get; set; }
        [MaxLength(30)]
        [Display(Name = "Status")]
        public string NomeStatus { get; set; }
        public string CodCurso { get; set; }
        public string NomeCurso { get; set; }
        public string CodHabilitacao { get; set; }
        public string NomeHabilitacao { get; set; }
        public string CodGrade { get; set; }
        public string DescGrade { get; set; }

        public List<SMatricPLCompl> Complementos { get; set; }


        public string GetAlunoId()
        {
            return $"{CodColigada}$_${RA}";
        }

        public string GetHabilitacaoAlunoId()
        {
            return $"{CodColigada}$_${IdHabilitacaoFilial}$_${RA}";
        }
    }

    public class SMatricPLCompl
    {

    }
}
