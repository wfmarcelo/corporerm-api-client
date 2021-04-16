using System.Collections.Generic;

namespace CorporeRMApi.Models.Educacional
{
    public class EduProcessaHorarioAtividadeProfessor
    {
        public bool ExisteChoque { get; set; }
        public bool IsCargaHorariaExcedida { get; set; }
        public IList<SHorarioTurma> ChoquesHorarioProfessor { get; set; }
        public IList<SHorarioAtivProf> ChoquesHorarioAtividadeProfessor { get; set; }
        public SAtividadeProfessor AtividadeProfessor { get; set; }
        public IList<STurmaDisc> DisciplinasProfessor { get; set; }

    }
}