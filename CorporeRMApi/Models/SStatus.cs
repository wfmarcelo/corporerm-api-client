using System;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models
{
    public class SStatus
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public int CodStatus { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public short CodTipoCurso { get; set; }
        public int? CUCodStatusPL { get; set; }
        public int? PLCodStatusCur { get; set; }
        public int? PLCodStatusDisc { get; set; }
        public short? PLCodTipoAluno { get; set; }
        public string PLIndicaTranc { get; set; }
        public string CuConcCurso { get; set; }
        public string CuIndicaJubilado { get; set; }
        public string CuIndicaTransf { get; set; }
        public string CuPermiteMatricPL { get; set; }
        public string Curso { get; set; }
        public string DiContCrTes { get; set; }
        public string DiCreditoCursado { get; set; }
        public string DiEmCurso { get; set; }
        public string DiHistorico { get; set; }
        public string DiIncAlunoDisc { get; set; }
        public string Disciplina { get; set; }
        public string DisponivelWEB { get; set; }
        public string DiValidaPre { get; set; }
        public string ListagensWEB { get; set; }
        public string MatriculaProvisoria { get; set; }
        public string NotasFaltasWEB { get; set; }
        public string PLAtivo { get; set; }
        public string PLBloqFinanc { get; set; }
        public string DiBloqNotaFalta { get; set; }
        public string PLBlqAltSitMat { get; set; }
        public string PLCancelaContrato { get; set; }
        public string PLDiario { get; set; }
        public string PLDiscAutomatica { get; set; }
        public string PLetivo { get; set; }
        public string PLExigeContrato { get; set; }
        public string PLIncluirDisc { get; set; }
        public string PLMStAntigoDisc { get; set; }
        public string PLRematricula { get; set; }
        public string Resultado { get; set; }
        public string PLPermiteTrancamento { get; set; }
        public string PLPrioridade { get; set; }
        public string PLOrdDiscPerant { get; set; }
        public int? PLLimiteDiscPerant { get; set; }
        public string PlOrdeDiscPerPost { get; set; }
        public int? PlLimiteDiscPerPost { get; set; }
        public string Aprovado { get; set; }
        public string DiIndicaTranc { get; set; }
        public string PlDispenTurmacao { get; set; }
        public string PerAluMatricWEB { get; set; }
        public string PerAluIncDisc { get; set; }
        public string PerAlunoExcDisc { get; set; }
        public string PLCancelaUsuarioCorpore { get; set; }
        public string PLCanelaUsuarioBiblios { get; set; }
        public string ContabCompetencia { get; set; }
        public int? PLCodStatusAtiv { get; set; }
        public string EnviarEmailMudSitMat { get; set; }
        public string TemplateEnvioEmail { get; set; }
        public string IdRelatorio { get; set; }
        public string ColigadaRelatorio { get; set; }
        public string PLBlqAlrSitSemDoc { get; set; }
        public string AbatePostalTerStatus { get; set; }
        public string DiBlqAltSitMatDisc { get; set; }
        public string DiBlqAltSitMatDiscPrt { get; set; }
        public string CodExterno { get; set; }
        public string PLPreencheDtMatEncCenso { get; set; }
        public string CUStatusFluigComunidade { get; set; }
        public string PLStatusFluigComunidade { get; set; }
        public string DiStatusFluigComunidade { get; set; }
        public string CuIndicaDesvinculado { get; set; }
        public string PLValInadimplMatricPortal { get; set; }
        public string ExibeQuadroAviso { get; set; }
        public int? CodColigadaRptPLetivoEmail { get; set; }
        public int? IdRptPLetivoEmail { get; set; }
        public string NovoRptPLetivoEmail { get; set; }

        public override bool Equals(object obj)
        {
            var status = obj as SStatus;

            if (status == null)
            {
                return false;
            }

            return 
                this.CodColigada == status.CodColigada &&
                this.CodStatus == status.CodStatus;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(CodColigada);
            hash.Add(CodStatus);
            hash.Add(Descricao);
            hash.Add(CodTipoCurso);
            hash.Add(CUCodStatusPL);
            hash.Add(PLCodStatusCur);
            hash.Add(PLCodStatusDisc);
            hash.Add(PLCodTipoAluno);
            hash.Add(PLIndicaTranc);
            hash.Add(CuConcCurso);
            hash.Add(CuIndicaJubilado);
            hash.Add(CuIndicaTransf);
            hash.Add(CuPermiteMatricPL);
            hash.Add(Curso);
            hash.Add(DiContCrTes);
            hash.Add(DiCreditoCursado);
            hash.Add(DiEmCurso);
            hash.Add(DiHistorico);
            hash.Add(DiIncAlunoDisc);
            hash.Add(Disciplina);
            hash.Add(DisponivelWEB);
            hash.Add(DiValidaPre);
            hash.Add(ListagensWEB);
            hash.Add(MatriculaProvisoria);
            hash.Add(NotasFaltasWEB);
            hash.Add(PLAtivo);
            hash.Add(PLBloqFinanc);
            hash.Add(DiBloqNotaFalta);
            hash.Add(PLBlqAltSitMat);
            hash.Add(PLCancelaContrato);
            hash.Add(PLDiario);
            hash.Add(PLDiscAutomatica);
            hash.Add(PLetivo);
            hash.Add(PLExigeContrato);
            hash.Add(PLIncluirDisc);
            hash.Add(PLMStAntigoDisc);
            hash.Add(PLRematricula);
            hash.Add(Resultado);
            hash.Add(PLPermiteTrancamento);
            hash.Add(PLPrioridade);
            hash.Add(PLOrdDiscPerant);
            hash.Add(PLLimiteDiscPerant);
            hash.Add(PlOrdeDiscPerPost);
            hash.Add(PlLimiteDiscPerPost);
            hash.Add(Aprovado);
            hash.Add(DiIndicaTranc);
            hash.Add(PlDispenTurmacao);
            hash.Add(PerAluMatricWEB);
            hash.Add(PerAluIncDisc);
            hash.Add(PerAlunoExcDisc);
            hash.Add(PLCancelaUsuarioCorpore);
            hash.Add(PLCanelaUsuarioBiblios);
            hash.Add(ContabCompetencia);
            hash.Add(PLCodStatusAtiv);
            hash.Add(EnviarEmailMudSitMat);
            hash.Add(TemplateEnvioEmail);
            hash.Add(IdRelatorio);
            hash.Add(ColigadaRelatorio);
            hash.Add(PLBlqAlrSitSemDoc);
            hash.Add(AbatePostalTerStatus);
            hash.Add(DiBlqAltSitMatDisc);
            hash.Add(DiBlqAltSitMatDiscPrt);
            hash.Add(CodExterno);
            hash.Add(PLPreencheDtMatEncCenso);
            hash.Add(CUStatusFluigComunidade);
            hash.Add(PLStatusFluigComunidade);
            hash.Add(DiStatusFluigComunidade);
            hash.Add(CuIndicaDesvinculado);
            hash.Add(PLValInadimplMatricPortal);
            hash.Add(ExibeQuadroAviso);
            hash.Add(CodColigadaRptPLetivoEmail);
            hash.Add(IdRptPLetivoEmail);
            hash.Add(NovoRptPLetivoEmail);
            return hash.ToHashCode();
        }
    }
}