using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models.Educacional
{
    public class EduGeraHorarioTurma
    {
        public short CodColigada { get; set; }
        public int? CodFilial { get; set; }
        public int? CodTipoCurso { get; set; }
        public int IdTurmaDisc { get; set; }
        public IList<Horario> ListaHorarios { get; set; }
        public bool PermitirSuperAlocarSala { get; set; }
        public bool RespeitaPeriodoProf { get; set; }
        public bool GeraPorRecorrencia { get; set; }
        public bool PermitirSuperAlocarProfessores { get; set; }
        public IList<object> PrimaryKeyList { get; set; }
        public IList<string> PrimaryKeyNames { get; set; }
        public string CodUsuario { get; set; }
        public Context Context { get; set; }
        public string ActionName { get; set; }
        public string ActionModule { get; set; }
    }

    public class Horario
    {
        public string Turno { get; set; }
        public string Professor { get; set; }
        public IList<int> ListaIdProfessorTurma { get; set; }
        public IList<ProfessorTurma> ListaProfessorTurma { get; set; }
        public string Predio { get; set; }
        public string Bloco { get; set; }
        public string Sala { get; set; }
        [Display(Name = "Data Inicial")]
        public DateTime DataInicial { get; set; }
        [Display(Name = "Data final")]
        public DateTime DataFinal { get; set; }
        public string CodSubTurma { get; set; }
        public short CodColigada { get; set; }
        public int CodHor { get; set; }
        public int CodTurno { get; set; }
        [Display(Name = "Dia semana")]
        public int DiaSemana { get; set; }
        [Display(Name = "Hora inicial")]
        public string HoraInicial { get; set; }
        [Display(Name = "Hora final")]
        public string HoraFinal { get; set; }
        public string Aula { get; set; }
        public string Classificacao { get; set; }
        public int CodHorariaAgrupUrania { get; set; }
        public string InternalId { get; set; }
    }

    public class ProfessorTurma
    {
        public short CodColigada { get; set; }
        public int IdProfessorTurma { get; set; }
        public int IdProfessorTurmaAntigo { get; set; }
        public string CodProf { get; set; }
        public int CodPessoa { get; set; }
        public string CodUsuario { get; set; }
        public string UserID { get; set; }
        public string Email { get; set; }
        [Display(Name = "Nome")]
        public string NomeProf { get; set; }
        public int IdTurmaDisc { get; set; }
        public int IdTurmaDiscAntigo { get; set; }
        public DateTime? DtInicio { get; set; }
        public decimal? ValorHora { get; set; }
        public int? AulasSemanaisProf { get; set; }
        public DateTime? DtFim { get; set; }
        public decimal? ValorFixo { get; set; }
        public decimal PercentFaturamento { get; set; }
        [Display(Name = "Tipo")]
        public string TipoProf { get; set; }
        public string DesconsideraPonto { get; set; }
        public bool CompoeSalario { get; set; }
        public int Status { get; set; }
        public int TipoOperacao { get; set; }
        public List<string> LstHorarioProfessor { get; set; }
        public DateTime? DtFimOriginal { get; set; }
        public DateTime? DtInicioOriginal { get; set; }
        public int StatusOriginal { get; set; }
        public decimal? ValorHoraOriginal { get; set; }
        public int? AulasSemanaisProfOriginal { get; set; }
        public decimal? ValorFixoOriginal { get; set; }
        public decimal PercentFaturamentoOriginal { get; set; }
        public string DesconsideraPontoOriginal { get; set; }
        public bool CompoeSalarioOriginal { get; set; }
    }
}