using System;
using System.Collections.Generic;

namespace CorporeRMApi.Models.Educacional
{
    public class EduGeraPlanoAula
    {
        public short CodColigada { get; set; }
        public int? CodFilial { get; set; }
        public short? CodTipoCurso { get; set; }
        public IList<TurmaDisciplina> TurmasDisciplinas { get; set; }
        public DateTime? DataInicial { get; set; }
        public DateTime? DataFinal { get; set; }
        public bool NaoUltrapassaCargaHoraria { get; set; }
        public bool RegeraPlanoAula { get; set; }
        public bool UsaDataInicialTurma { get; set; }
        public bool UsaDataFinalTurma { get; set; }
        public bool UsaDataInicialPL { get; set; }
        public bool UsaDataFinalPL { get; set; }
        public bool ConsiderarRecesso { get; set; }
        public bool GerarPlanoSequencial { get; set; }
        public bool NaoVerificarDataPLetivo { get; set; }
        public bool ConsiderarEventoAcademico { get; set; }
        public IList<string> ListaTipoFeriado { get; set; }
        public IList<string> ListaTipoEventoAcademico { get; set; }
        public bool GerarMenorData { get; set; }
        public bool ReordenarAula { get; set; } = true;
        public int? TipoAula { get; set; }
        public IList<object> PrimaryKeyList { get; set; }
        public IList<string> PrimaryKeyNames { get; set; }
        public Context Context { get; set; }

    }

    public class TurmaDisciplina
    {
        public int? IdHabilitacaoFilial { get; set; }
        public short? CodColigada { get; set; }
        public int? IdTurmaDisc { get; set; }
        public int? CodTipoCurso { get; set; }
        public short? CodFilial { get; set; }
        public string CodTurma { get; set; }
        public int? IdPeriodoLetivo { get; set; }
        public string CodDisciplina { get; set; }
        public string CodPredio { get; set; }
        public string CodBloco { get; set; }
        public string CodSala { get; set; }
        public string DuracaoAula { get; set; }
        public string NomeDisciplina { get; set; }
        public int? IdHorarioTurma { get; set; }
        public string InternalId { get; set; }

        public static TurmaDisciplina GetTurmaDisciplina(SHorarioTurma horarioTurma, STurmaDisc turmaDisc)
        {
            return new TurmaDisciplina
            {
                CodBloco = horarioTurma.CodBloco,
                CodColigada = horarioTurma.CodColigada,
                CodDisciplina = turmaDisc.CodDisc,
                CodFilial = horarioTurma.CodFilial,
                CodPredio = horarioTurma.CodPredio,
                CodSala = horarioTurma.CodSala,
                CodTipoCurso = horarioTurma.CodTipoCurso,
                CodTurma = turmaDisc.CodTurma,
                NomeDisciplina = turmaDisc.Nome,
                IdHabilitacaoFilial = turmaDisc.IdHabilitacaoFilial,
                IdHorarioTurma = horarioTurma.IdHorarioTurma,
                IdPeriodoLetivo = turmaDisc.IdPerLet,
                IdTurmaDisc = turmaDisc.IdTurmaDisc
            };
        }
    }


}