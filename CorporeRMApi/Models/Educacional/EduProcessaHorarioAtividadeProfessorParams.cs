using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorporeRMApi.DataServer;

namespace CorporeRMApi.Models.Educacional
{
    public class EduProcessaHorarioAtividadeProfessorParams
    {
        private readonly EduProfessorTurmaData _professorTurmaData;
        private readonly EduAtividadeProfessorData _atividadeProfessorData;
        private readonly EduHorarioProfessorData _horarioProfessorData;
        private readonly EduHorarioTurmaData _horarioTurmaData;
        private readonly EduTurmaDiscData _turmaDiscData;

        public IList<SHorario> Horarios { get; set; }
        public SAtividadeProfessor AtividadeProfessor { get; set; }
        public IList<SAtividadeProfessor> AtividadesProfessor { get; set; }
        public IList<SHorarioTurma> HorariosTurma { get; set; }
        public IList<STurmaDisc> TurmaDisciplinas { get; set; }

        public EduProcessaHorarioAtividadeProfessorParams(
            EduProfessorTurmaData professorTurmaData,
            EduAtividadeProfessorData atividadeProfessorData,
            EduHorarioProfessorData horarioProfessorData,
            EduHorarioTurmaData horarioTurmaData,
            EduTurmaDiscData turmaDiscData
        )
        {
            _professorTurmaData = professorTurmaData;
            _atividadeProfessorData = atividadeProfessorData;
            _horarioProfessorData = horarioProfessorData;
            _horarioTurmaData = horarioTurmaData;
            _turmaDiscData = turmaDiscData;
        }

        



    }
}