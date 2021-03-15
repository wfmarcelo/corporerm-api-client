namespace CorporeRMApi.Models.Educacional.ConsultaSql
{
    // Consulta turma disciplinas professores no periodo
    public class PEnsino00009
    {
        public int CodTipoCurso { get; set; }
        public string NomeTipoCurso { get; set; }
        public int IdPerLet { get; set; }
        public string NomePeriodoLetivo { get; set; }
        public string CodCurso { get; set; }
        public string NomeCurso { get; set; }
        public string CodGrade { get; set; }
        public string NomeGrade { get; set; }
        public string CodTurma { get; set; }
        public string NomeTurma { get; set; }
        public string TurmaDisciplinaId { get; set; }
        public string NomeDisciplina { get; set; }
        public bool StatusDisciplina { get; set; }
    } 
}