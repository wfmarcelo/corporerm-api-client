using System;
using System.Collections.Generic;
using System.Linq;
using CorporeRMApi.Models.Global;

namespace CorporeRMApi.Models.Educacional
{
    public class EduGeraHorarioTurmaProcessParams
    {
         public IList<SHorario> Horarios { get; set; }
         public IList<SProfessorTurma> Professores { get; set; }
         public STurmaDisc STurmaDisc { get; set; }
         public SDisciplina SDisciplina { get; set; }
         public Recorrencia Recorrencia { get; set; }
    }

}