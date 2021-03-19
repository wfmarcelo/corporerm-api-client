using System;
using System.Collections.Generic;
using System.Linq;
using CorporeRMApi.Models.Global;

namespace CorporeRMApi.Models.Educacional
{
    public class EduProcessaHorarioTurmaParams
    {
        public EduProcessaHorarioTurmaParams(
            IList<SHorario> horarios,
            IList<SProfessorTurma> professores,
            STurmaDisc sTurmaDisc,
            SDisciplina sDisciplina,
            Recorrencia recorrencia,
            bool verificaChoqueTurma
        )
        {
            Horarios = horarios;
            Professores = professores;
            STurmaDisc = sTurmaDisc;
            SDisciplina = sDisciplina;
            Recorrencia = recorrencia;
            VerificaChoqueTurma = verificaChoqueTurma;
        }
          
         public IList<SHorario> Horarios { get; set; }
         public IList<SProfessorTurma> Professores { get; set; }
         public STurmaDisc STurmaDisc { get; set; }
         public SDisciplina SDisciplina { get; set; }
         public Recorrencia Recorrencia { get; set; }
         public bool VerificaChoqueTurma { get; set; }
    }

}