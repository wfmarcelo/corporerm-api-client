using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models.Educacional
{
    public class SHabilitacaoAluno
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public int IdHabilitacaoFilial { get; set; }
        [Required]
        [MaxLength(20)]
        [Display(Name = "Registro Acadêmico")]
        public string RA { get; set; }
        public short? CodTipoIngresso { get; set; }
        public int? CodInst { get; set; }
        public int? CodStatus { get; set; }
        [Display(Name = "Admissão")]
        public DateTime? DtIngresso { get; set; }
        [Display(Name = "Pontos")]
        public string PontosVestibular { get; set; }
        public string ClassificacaoVestibular { get; set; }
        public decimal? MediaVestibular { get; set; }
        [Display(Name = "Data da Colação")]
        public DateTime? DtColacaoGrau { get; set; }
        public DateTime? DtEmisDiploma { get; set; }
        public string RegistroConclusao { get; set; }
        public string LivroRegistro { get; set; }
        public string PaginaRegistro { get; set; }
        [Display(Name = "Data de Conclusão")]
        public DateTime? DtConclusaoCurso { get; set; }
        public decimal? CR { get; set; }
        public decimal? MediaGlobal { get; set; }
        public DateTime? DtProvao { get; set; }
        public string ProcessoRegistro { get; set; }
        public int? CodInstDiploma { get; set; }
        public string Observacao { get; set; }
        public string RealizouProvao { get; set; }
        public int? IdHabilitacaoFilialOrigem { get; set; }
        public short? CodMotivoTransferencia { get; set; }
        public string MotivoTransferencia { get; set; }
        [Display(Name = "Forma")]
        public string NomeTipoIngresso { get; set; }
        public string NomeInstituicao { get; set; }
        public string NomeStatus { get; set; }
        [Display(Name = "Matriz Curricular")]
        public string NomeGrade { get; set; }
        [Display(Name = "Curso")]
        public string NomeCurso { get; set; }
        [Display(Name = "Habilitação")]
        public string NomeHabilitacao { get; set; }
        [Display(Name = "Turno")]
        public string NomeTurno { get; set; }
        [Display(Name = "Nome")]
        public string NomeAluno { get; set; }
        public string CodCurso { get; set; }
        [Display(Name = "Total de Disciplinas")]
        public int? QtdTotalDiscObr { get; set; }
        [Display(Name = "Total Cursadas")]
        public int? QtdConcDiscObr { get; set; }
        [Display(Name = "Total Pendentes")]
        public int? QtdPendDiscObr { get; set; }
        public string TipoContDiscOpt { get; set; }
        [Display(Name = "Total Optativas")]
        public double? QtdTotalDiscOpt { get; set; }
        public double? QtdConcDiscOpt { get; set; }
        public double? QtdPendDiscOpt { get; set; }
        public string TipoContDiscEle { get; set; }
        public double? QtdTotalDiscEle { get; set; }
        public double? QtdConcDiscEle { get; set; }
        public double? QtdPendDiscEle { get; set; }
        public string TipoContAtvCur { get; set; }
        public double? QtdTotalAtvCur { get; set; }
        public double? QtdConcAtvCur { get; set; }
        public double? QtdPendAtvCur { get; set; }
        public int? QtdMinIntegralizacao { get; set; }
        public int? QtdConcIntegralizacao { get; set; }
        public int? QtdPendIntegralizacao { get; set; }
        public short? CodTipoCurso { get; set; }
        public IList<SDiscConcluidas> SDiscConcluidas { get; set; }
        public IList<SDiscPendentes> SDiscPendentes { get; set; }
        public IList<SDiscOptativasEletivas> SDiscOptativasEletivas { get; set; }
        public IList<SAtividadeAluno> SAtividadeAluno { get; set; }
        public IList<SDiscEquivConcluidas> SDiscEquivConcluidas { get; set; }
        public IList<SDiscAprovEstudosOrigem> SDiscAprovEstudosOrigem { get; set; }
        public IList<SGrupoOptEletiva> SGrupoOptEletiva { get; set; }
        public IList<SDiscGrupoOptEletiva> SDiscGrupoOptEletiva { get; set; }
        public IList<SDiscExtras> SDiscExtras { get; set; }
        public IList<SDiscEquivEmCurso> SDiscEquivEmCurso { get; set; }
        public IList<SDisciplinaTCC> SDisciplinaTCC { get; set; }
    }

    public class SDiscConcluidas
    {
        public string Id { get; set; }
        public string Parent_Id { get; set; }
        public short? CodColigada { get; set; }
        public int? IdHabilitacaoFilial { get; set; }
        public string RA { get; set; }
        public short? CodPeriodo { get; set; }
        public string PLetivo { get; set; }
        public string CodDisc { get; set; }
        public string Disciplina { get; set; }
        public string Status { get; set; }
        public decimal? NumCreditos { get; set; }
        public decimal? CH { get; set; }
        public decimal? Nota { get; set; }
        public int? GrEquiv { get; set; }
        public int? CodStatus { get; set; }
        public double? Faltas { get; set; }
        public string Conceito { get; set; }
        public int? CodStatusMatricula { get; set; }
        public string StatusMatricula { get; set; }
        public DateTime? DtMatricula { get; set; }
        public int? IdPerLet { get; set; }
        public string ActionPars { get; set; }
        public short? ImageIndex { get; set; }
        public string NomePeriodo { get; set; }
        public string CHHora { get; set; }
        public string ConceitoECTS { get; set; }
        public int? IdHabFilialAprovEstudos { get; set; }
        public int? IdTurmaDisc { get; set; }

    }

    public class SDiscPendentes
    {
        public string Id { get; set; }
        public string Parent_Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        public int? IdHabilitacaoFilial { get; set; }
        [Required]
        public string RA { get; set; }
        public short? CodPeriodo { get; set; }
        public string PLetivo { get; set; }
        [Required]
        [Display(Name = "Código")]
        public string CodDisc { get; set; }
        public string Disciplina { get; set; }
        public string Status { get; set; }
        [Display(Name = "Créditos")]
        public decimal? NumCreditos { get; set; }
        public decimal? CH { get; set; }
        public decimal? Nota { get; set; }
        public int? GrEquiv { get; set; }
        public int? CodStatus { get; set; }
        public double? Faltas { get; set; }
        public string Conceito { get; set; }
        public int? CodStatusMatricula { get; set; }
        public string StatusMatricula { get; set; }
        public DateTime? DtMatricula { get; set; }
        public string ActionPars { get; set; }
        public short? ImageIndex { get; set; }
        public string NomePeriodo { get; set; }
        public string CHHora { get; set; }
        public int? IdPerLet { get; set; }
        public string ConceitoECTS { get; set; }
        [Required]
        public bool EmCurso { get; set; }
        public int? IdTurmaDisc { get; set; }
    }

    public class SDiscOptativasEletivas
    {
        public string Id { get; set; }
        public string Parent_Id { get; set; }
        public short? CodColigada { get; set; }
        public int? IdHabilitacaoFilial { get; set; }
        public string RA { get; set; }
        public string PLetivo { get; set; }
        public string CodDisc { get; set; }
        public string Disciplina { get; set; }
        public string Status { get; set; }
        public decimal? NumCreditos { get; set; }
        public decimal? CH { get; set; }
        public decimal? Nota { get; set; }
        public int? GrEquiv { get; set; }
        public string Tipo { get; set; }
        public DateTime? DtMatricula { get; set; }
        public int? CodStatusMatricula { get; set; }
        public string StatusMatricula { get; set; }
        public int? CodStatusRes { get; set; }
        public double? Faltas { get; set; }
        public string ActionPars { get; set; }
        public short? ImageIndex { get; set; }
        public string Conceito { get; set; }
        public string CHHora { get; set; }
        public int? IdPerLet { get; set; }
        public string ConceitoECTS { get; set; }
        public int? IdHabFilialAprovEstudos { get; set; }
        public int? IdTurmaDisc { get; set; }
        public bool EmCurso { get; set; }

    }

    public class SAtividadeAluno
    {
        public string Id { get; set; }
        public string Parent_Id { get; set; }
        public short? CodColigada { get; set; }
        public int? IdHabilitacaoFilial { get; set; }
        public int? IdAtividade { get; set; }
        public string RA { get; set; }
        public int? CodModalidade { get; set; }
        public string Modalidade { get; set; }
        public string Descricao { get; set; }
        public decimal? CH { get; set; }
        public decimal? Creditos { get; set; }
        public string PLetivo { get; set; }
        public string CumpriuAtivadade { get; set; }
        public string DocumentacaoEntregue { get; set; }
        public string ActionPars { get; set; }
        public string Status { get; set; }
        public string Componente { get; set; }
        public decimal? ValorMinimo { get; set; }
        public decimal? ValorMaximo { get; set; }
        public short? ImageIndex { get; set; }
        public string CHHora { get; set; }
        public int? CodComponente { get; set; }
        public decimal? ValorMinimoComponente { get; set; }
        public string TipoAtividadeCurricular { get; set; }
    }

    public class SDiscEquivConcluidas
    {
        public string Id { get; set; }
        public string Parent_Id { get; set; }
        public short? CodColigada { get; set; }
        public int? IdHabilitacapFilial { get; set; }
        public string RA { get; set; }
        public string PLetivo { get; set; }
        public string CodDisc { get; set; }
        public string Disciplina { get; set; }
        public string Status { get; set; }
        public decimal? NumCreditos { get; set; }
        public decimal? CH { get; set; }
        public decimal? Nota { get; set; }
        public double? Faltas { get; set; }
        public int? IdGrupo { get; set; }
        public string CodDiscEqv { get; set; }
        public int? IdGrupoEqEquiv { get; set; }
        public int? IdPerLet { get; set; }
        public string CodStatus { get; set; }
        public string ActionPars { get; set; }
        public short? ImageIndex { get; set; }
        public string Conceito { get; set; }
        public int? GrEquiv { get; set; }
        public string CHHora { get; set; }
        public string ConceitoECTS { get; set; }
        public int? IdHabFilialAprovEstudos { get; set; }
        public int? IdTurmaDisc { get; set; }
    }

    public class SDiscAprovEstudosOrigem
    {
        public string Id { get; set; }
        public string Parent_Id { get; set; }
        public short CodColigada { get; set; }
        public int IdHabilitacaoFilial { get; set; }
        public string RA { get; set; }
        public string PLetivo { get; set; }
        public string CodDisc { get; set; }
        public string Disciplina { get; set; }
        public string Status { get; set; }
        public decimal NumCreditos { get; set; }
        public decimal CH { get; set; }
        public decimal Nota { get; set; }
        public int Faltas { get; set; }
        public string CodDiscAprov { get; set; }
        public int IdHabFilialPK { get; set; }
        public string ActionPars { get; set; }
        public int IdHistDiscFacExt { get; set; }
        public int IdPerLet { get; set; }
        public string Conceito { get; set; }
        public string CHHora { get; set; }
        public string ConceitoECTS { get; set; }
        public int IdTurmaDisc { get; set; }
    }

    public class SGrupoOptEletiva
    {
        public string Id { get; set; }
        public string Parent_Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public string CodCurso { get; set; }
        [Required]
        public string Codhabilitacao { get; set; }
        [Required]
        public string CodGrade { get; set; }
        [Required]
        public int IdGrupo { get; set; }
        [Required]
        public string Nome { get; set; }
        public short CodPeriodo { get; set; }
        [Required]
        public string TipoAvaliacao { get; set; }
        public decimal MinCreditos { get; set; }
        public decimal MinCH { get; set; }
        public int MinDisciplinas { get; set; }
        public string NomePeriodo { get; set; }
        public int IdTurmaDisc { get; set; }
        public int IdPerLet { get; set; }
    }

    public class SDiscGrupoOptEletiva
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
        public int IdGrupo { get; set; }
        [Required]
        public string CodDisc { get; set; }
    }

    public class SDiscExtras
    {
        public string Id { get; set; }
        public string Parent_Id { get; set; }
        public short? CodColigada { get; set; }
        public int? IdHabilitacaoFilial { get; set; }
        public string RA { get; set; }
        public string CodCurso { get; set; }
        public string CodHabilitacao { get; set; }
        public string CodDisc { get; set; }
        public string CodGrade { get; set; }
        public string CH { get; set; }
        public string Nome { get; set; }
        public string NumCreditos { get; set; }
        public string Disciplina { get; set; }
        public string Status { get; set; }
        public string PLetivo { get; set; }
        public string Nota { get; set; }
        public string Faltas { get; set; }
        public string ActionPars { get; set; }
        public string Concluiu { get; set; }
        public string Aproveitada { get; set; }
        public string NaoPassivelAprov { get; set; }
        public short? ImageIndex { get; set; }
        public string Conceito { get; set; }
        public string CHHora { get; set; }
        public string ConceitoECTS { get; set; }
        public int? IdTurmaDisc { get; set; }       
        public int? IdPerLet { get; set; }
    }

    public class SDiscEquivEmCurso
    {
        public string Id { get; set; }
        public string Parent_Id { get; set; }
        public short? CodColigada { get; set; }
        public int? IdHabilitacaoFilial { get; set; }
        public string RA { get; set; }
        public string PLetivo { get; set; }
        public string CodDisc { get; set; }
        public string Disciplina { get; set; }
        public string Status { get; set; }
        public decimal? NumCreditos { get; set; }
        public decimal? CH { get; set; }
        public decimal? Nota { get; set; }
        public double? Faltas { get; set; }
        public int? IdGrupo { get; set; }
        public string CodDiscEqv { get; set; }
        public int? IdGrupoEqEquiv { get; set; }
        public int? IdPerLet { get; set; }
        public string CodStatus { get; set; }
        public string ActionPars { get; set; }
        public short? ImageIndex { get; set; }
        public string Conceito { get; set; }
        public int? GrEquiv { get; set; }
        public string CHHora { get; set; }
        public string ConceitoECTS { get; set; }
        public int? IdTurmaDisc { get; set; }
        [Required]
        public string IdHistDiscEquivEmCurso { get; set; }
    }

    public class SDisciplinaTCC
    {
        public string Id { get; set; }
        public string Parent_Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public int IdTCC { get; set; }
        [Required]
        public string RA { get; set; }
        [Required]
        public int IdHabilitacaoFilial { get; set; }
        public string Tema { get; set; }
        public int IdTipoTCC { get; set; }
        public string NomeTipoTCC { get; set; }
        public int IdLinhaPesquisa { get; set; }
        public string NomeLinhaPesquisa { get; set; }
        public int IdStatusTCC { get; set; }
        public short CodPeriodo { get; set; }
        public string PLetivo { get; set; }
        [Required]
        public string CodDisc { get; set; }
        public string Status { get; set; }
        public decimal NumCreditos { get; set; }
        public decimal Nota { get; set; }
        public decimal CH { get; set; }
        public int GrEquiv { get; set; }
        public int CodStatus { get; set; }
        public decimal Faltas { get; set; }
        public string Conceito { get; set; }
        public int CodStatusMatricula { get; set; }
        public string StatusMatricula { get; set; }
        public DateTime DtMatricula { get; set; }
        public int IdPerLet { get; set; }
        public string ActionPars { get; set; }
        public short ImageIndex { get; set; }
        public string NomePeriodo { get; set; }
        public string CHHora { get; set; }
        public string ConceitoECTS { get; set; }
        public int IdHabFilialAprovEstudos { get; set; }
        public int IdTurmaDisc { get; set; }
        [Display(Name = "Situação")]
        public string NomeStatus { get; set; }
        public object Image { get; set; }
        public string Disciplina { get; set; }   
        public string Img { get; set; }
    }
}