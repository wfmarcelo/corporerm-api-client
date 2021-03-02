using System.Collections.Generic;

namespace CorporeRMApi.Models.Educacional
{
    public class EduProcessaHorarioAtividadeProfessorParams
    {
        public IList<SHorario> Horarios { get; set; }
        public SAtividadeProfessor AtividadeProfessor { get; set; }
        public IList<SAtividadeProfessor> AtividadesProfessor { get; set; }
        public IList<SHorarioTurma> HorariosTurma { get; set; }
        public IList<STurmaDisc> TurmaDisciplinas { get; set; }

    }
}