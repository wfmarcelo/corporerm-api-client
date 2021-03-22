using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public IList<Horario> HorariosInclusao { get; set; }
        public IList<ProfessorTurma> ProfessoresInclusao { get; set; }
        [Display(Name = "CH processada")]
        public decimal CHProcessada { get; set; }
        [Display(Name = "CH disciplina")]
        public decimal CHDisciplina { get; set; }
        [Display(Name = "CH cadastrada")]
        public decimal CHCadastrada { get; set; }
        public string NomeDisciplina { get; set; }
        public bool ExisteChoque { get; set; }
        public bool IsCHIncompleta { get; set; }
        public STurmaDisc STurmaDisc { get; set; }
        [Display(Name = "Total dias")]
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
        [Display(Name = "Total aulas")]
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