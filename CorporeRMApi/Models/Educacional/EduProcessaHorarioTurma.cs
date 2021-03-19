using System;
using System.Collections.Generic;
using System.Linq;
using CorporeRMApi.Models.Global;

namespace CorporeRMApi.Models.Educacional
{
    public class EduProcessaHorarioTurma
    {
         public IList<GFeriado> ChoquesFeriado { get; set; }
        public IList<SHorarioTurma> ChoquesHorarioTurma { get; set; }
        public IList<SHorarioTurma> choquesHorarioProfessores { get; set; }
        public IList<SHorarioAtivProf> choquesHorarioAtividadeProfessores { get; set; }
        public IList<SAtividadeProfessor> AtividadesProfessores { get; set; }
        public IList<STurmaDisc> DisciplinasTurma { get; set; }
        public IList<STurmaDisc> DisciplinasProfessores { get; set; }
        public IList<SProfessorTurma> TurmasProfessores { get; set; }
        public IList<SHorarioTurma> HorariosInclusao { get; set; }
        public IList<SProfessorTurma> ProfessoresInclusao { get; set; }
        public decimal CHProcessada { get; set; }
        public decimal CHDisciplina { get; set; }
        public decimal CHCadastrada { get; set; }
        public string NomeDisciplina { get; set; }
        public bool ExisteChoque { get; set; }
        public bool IsCHIncompleta { get; set; }
        public string IdTurmaDisciplina { get; set; }
        public short CodColigada { get; set; }
        public int TotalDias
        {
            get
            {
                if (HorariosInclusao == null)
                {
                    return 0;
                }

                return HorariosInclusao.Select(m => m.DataInicial).Distinct().ToList().Count;
            }
        }
        public int TotalAulas
        {
            get
            {
                if (HorariosInclusao == null)
                {
                    return 0;
                }
                
                return HorariosInclusao.Count;
            }
        }
    }

}