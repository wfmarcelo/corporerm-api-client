using System;
using System.ComponentModel.DataAnnotations;
using Uniarp.Util;

namespace CorporeRMApi.Models.Educacional
{
    public class SAluno
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        [MaxLength(20)]
        public string RA { get; set; }
        [Required]
        [MaxLength(120)]
        public string Nome { get; set; }
        [Required]
        [Display(Name = "Data Nascimento")]
        public DateTime DtNascimento { get; set; }
        [Required]
        public int CodTipoCurso { get; set; }
        [MaxLength(14)]
        public string CPF { get; set; }
        [MaxLength(120)]
        public string NomeSocial { get; set; }
        [MaxLength(20)]
        public string CodUsuario { get; set; }
        [MaxLength(60)]
        public string Email { get; set; }
        public short? CodArea { get; set; }
        public short? CodCarreira { get; set; }
        public short? CodIdioma { get; set; }
        public short? CodTipoAluno { get; set; }
        public int? CodInstDestino { get; set; }
        public int? CodInstOrigem { get; set; }
        public short? CodColCFo { get; set; }
        public string CodCFo { get; set; }
        public string CodParentCFo { get; set; }
        public int? CodPessoaRaca { get; set; }
        public string codParentRaca { get; set; }
        public int? CodPessoa { get; set; }
        public string CodCursoHist { get; set; }
        public int? CodSerieHist { get; set; }
        public string ObsHist { get; set; }
        public string Identificador2 { get; set; }
        public string Identificador3 { get; set; }
        public string AnoIngresso { get; set; }
        public string Anotacoes { get; set; }
        public string EmpresaNome { get; set; }
        public string EmpresaNumero { get; set; }
        public string EmpresaComplemento { get; set; }
        public string EmpresaBairro { get; set; }
        public string EmpresaCidade { get; set; }
        public string EmpresaUF { get; set; }
        public string EmpresaCEP { get; set; }
        public string EmpresaTelefone { get; set; }
        public string EmpresaHorario { get; set; }
        public string EmpresaRua { get; set; }
        public string TipoCertidao { get; set; }
        public string CertNumero { get; set; }
        public string CertCartorio { get; set; }
        public string CertComarca { get; set; }
        public DateTime? CertData { get; set; }
        public string CertDistrito { get; set; }
        public string CertUF { get; set; }
        public string CertFolha { get; set; }
        public string CertLivro { get; set; }
        public int? Codigo { get; set; }
        [Display(Name = "Tipo Aluno")]
        public string DescTipoAluno { get; set; }
        public string RespAcademico { get; set; }
        public string RespFinanceiro { get; set; }
        public string Sexo { get; set; }
        public string CodPerLet { get; set; }
        public string Sobrenome { get; set; }
        public string Apelido { get; set; }
        [Display(Name = "Estado Civil")]
        public string EstadoCivil { get; set; }
        public string Nacionalidade { get; set; }
        [Display(Name = "Estado Natal")]
        public string EstadoNatal { get; set; }
        public string Naturalidade { get; set; }
        public int? IdImagem { get; set; }
        public byte[] Imagem { get; set; }
        public short? CorRaca { get; set; }
        public string GrauInstrucao { get; set; }
        public string TipoSang { get; set; }
        public short? DeficienteFisico { get; set; }
        public short? DeficienteFala { get; set; }
        public short? DeficienteMental { get; set; }
        public short? DeficienteVisual { get; set; }
        public short? DeficienteAuditivo { get; set; }
        public short? DeficienteIntelectual { get; set; }
        public string RecursoRealizacaoTrab { get; set; }
        public string RecursoAcessibilidade { get; set; }
        public string Rua { get; set; }
        [Display(Name = "Número")]
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        [Display(Name = "País")]
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        [Display(Name = "Telefone Residencial")]
        public string Telefone1 { get; set; }
        [Display(Name = "Celular")]
        public string Telefone2 { get; set; }
        [Display(Name = "Telefone 3")]
        public string Telefone3 { get; set; }
        public string Fax { get; set; }
        public string CEP { get; set; }
        public string CartMotorista { get; set; }
        public string TipoCartHabilit { get; set; }
        public DateTime? DtVencHabilit { get; set; }
        public string TituloEleitor { get; set; }
        public string ZonaTituloEleitor { get; set; }
        public string SecaoTitEleitor { get; set; }
        public DateTime? DtTitEleitor { get; set; }
        public string EstEleit { get; set; }
        public string CartIdentidade { get; set; }
        public string UFCartIdent { get; set; }
        public string OrgEmissorIdent { get; set; }
        public DateTime? DtEmissaoIdent { get; set; }
        public string CertifReserv { get; set; }
        public string CategMilitar { get; set; }
        public string CSM { get; set; }
        public DateTime? DtExpCML { get; set; }
        public string Exped { get; set; }
        public string RM { get; set; }
        public string CarteiraTrab { get; set; }
        public string SerieCartTrab { get; set; }
        public string UFCartTrab { get; set; }
        public DateTime? DtCartTrab { get; set; }
        public short? NIT { get; set; }
        public string RegProfissional { get; set; }
        public string SitMilitar { get; set; }
        public string NPassaporte { get; set; }
        public DateTime? DtEmissPassaporte { get; set; }
        public DateTime? DtValPassaporte { get; set; }
        public string PaisOrigem { get; set; }
        public string TipoVisto { get; set; }
        public DateTime? DataChegada { get; set; }
        public string CartModelo19 { get; set; }
        public short? NroFilhosBrasil { get; set; }
        public string NroRegGeral { get; set; }
        public string NroDecreto { get; set; }
        public short? ConjugeBrasil { get; set; }
        public short? Naturalizado { get; set; }
        public DateTime? DtVencIdent { get; set; }
        public DateTime? DtVencCartTrab { get; set; }
        public short? FilhosBrasil { get; set; }
        public int? CodProfissao { get; set; }
        public string CodOcupacao { get; set; }
        public string IndAtendEspecializado { get; set; }
        public string IndAtendEspecifico { get; set; }
        public string IndicadorDeRecursos { get; set; }
        public int? CodInst2Grau { get; set; }
        public string GrauUltimaInst { get; set; }
        public string AnoUltimaInst { get; set; }
        public short? AjustaTamanhoFoto { get; set; }
        public int? CodigoPT { get; set; }
        public string CodFreguesia { get; set; }
        public string CodPostal { get; set; }
        public string NumeroCartCidadao { get; set; }
        public DateTime? DtEmissaoCartCidadao { get; set; }
        public string OrgExpCartCidadao { get; set; }
        public DateTime? DtValidadeCartCidadao { get; set; }
        public string Canhoto { get; set; }
        public string Senha { get; set; }
        public string EmpresaCodFreguesia { get; set; }
        public string EmpresaCodPostal { get; set; }
        public string EmpresaCodMunicipio { get; set; }
        public string EmpresaLocalidade { get; set; }
        public string CertServentia { get; set; }
        public string RAcad { get; set; }
        public string UFRAcad { get; set; }
        [Display(Name = "Nome Social")]
        public string UserID { get; set; }
        public short? BRPDH { get; set; }
        public string CodSistec { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public int? CodTipoRua { get; set; }
        public int? CodTipoBairro { get; set; }
        public string TipoRua { get; set; }
        public string TipoBairro { get; set; }
        public string EmailPai { get; set; }
        public string EmailMae { get; set; }
        public string EmailRespAcademico { get; set; }
        public string EmailRespFinanceiro { get; set; }
        public int? CodEtnia { get; set; }
        public decimal? InvestTreinAnt { get; set; }
        public string Empresa { get; set; }
        public int? CodMemoObs { get; set; }
        public short? Fumante { get; set; }
        public string ObsPessoa { get; set; }
        public int? IdImagemDoc { get; set; }
        public int? IdImagemDocV { get; set; }
        public DateTime? DataAprovacaoCurr { get; set; }
        public string CodMunicipio { get; set; }
        public string Localidade { get; set; }
        public int? IdBiometria { get; set; }
        public short? EstadoRow { get; set; }
        public ushort? RowValida { get; set; }
        public short? Aluno { get; set; }
        public short? Professor { get; set; }
        public short? Candidato { get; set; }
        public short? UsuarioBiblios { get; set; }
        public short? Funcionario { get; set; }
        public short? ExFuncionario { get; set; }
        public int? CodigoMX { get; set; }
        public string PrimeiroNome { get; set; }
        public string SobrenomePai { get; set; }
        public string SobrenomeMae { get; set; }
        public string TagsScript { get; set; }
        public string Chapa { get; set; }
        public string NroInt { get; set; }
        public string CURP { get; set; }
        public DateTime? DtVencIdentPT { get; set; }
        public string CodOrgaoClasse { get; set; }
        public string CodUFRegistro { get; set; }
        public string CodNaturalidade { get; set; }
        public string NumeroRIC { get; set; }
        public string OrgEmissorRIC { get; set; }
        public DateTime? DtEmissaoRIC { get; set; }
        public DateTime? DtEmissaoCNH { get; set; }
        public DateTime? DataNaturalizacao { get; set; }
        public string OrgEmissorCNH { get; set; }
        public string OrgEmissorRNE { get; set; }
        public DateTime? DtEmissaoRNE { get; set; }
        public int? IdPais { get; set; }
        public DateTime? DataObito { get; set; }
        public string MatriculaObito { get; set; }
        public short? Falecido { get; set; }
        public string PortariaNaturalizacao { get; set; }
        public string CodClassifTrabEstrang { get; set; }
        public DateTime? DataPrimeiraCNH { get; set; }
        public string UFCNH { get; set; }
        public string EmailPessoal { get; set; }
        public int? Ano1Emprego { get; set; }
        public int? Idade { get; set; }
        public int? IdHabilitacaoFilial { get; set; }
        public int? CodStatus { get; set; }
        public short? FiadorSGI { get; set; }
        public short? ConjugeSGI { get; set; }
        public short? DeficienteMobReduzida { get; set; }
        public string RecCreatedBy { get; set; }
        public DateTime? RecCreatedOn { get; set; }

        public string RecModifiedBy { get; set; }
        public DateTime? RecModifiedOn { get; set; }
        public string DeficienteObservacao { get; set; }
        public int? Codigo1 { get; set; }

        public override bool Equals(object obj)
        {
            var aluno = obj as SAluno;

            if (aluno == null)
            {
                return false;
            }

            return 
                this.CodColigada == aluno.CodColigada &&
                this.RA == aluno.RA;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(CodColigada);
            hash.Add(RA);
            hash.Add(Nome);
            hash.Add(DtNascimento);
            hash.Add(CodTipoCurso);
            hash.Add(CPF);
            hash.Add(NomeSocial);
            hash.Add(CodUsuario);
            hash.Add(Email);
            return hash.ToHashCode();
        }

        public void FormatarCampos()
        {
            this.EstadoCivil = ((int)char.Parse(this.EstadoCivil ?? "0")).ToString();
            this.Sexo = ((int)char.Parse(this.Sexo)).ToString();
            this.Telefone1 = Formater.FormatarTelefone(this.Telefone1);
            this.Telefone2 = Formater.FormatarTelefone(this.Telefone2);
            this.Telefone3 = Formater.FormatarTelefone(this.Telefone3);
            this.Fax = Formater.FormatarTelefone(this.Fax);
            this.CEP = Formater.FormatarCEP(this.CEP);

            
        }
    }
}