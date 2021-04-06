using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace CorporeRMApi.Models.Educacional
{
    public class STurmaDisc
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public int IdTurmaDisc { get; set; }
        [Required]
        public short CodFilial { get; set; }
        [Required]
        [MaxLength(20)]
        [Display(Name = "Código Turma")]
        public string CodTurma { get; set; }
        [Required]
        [Display(Name = "Período Letivo")]
        public int IdPerLet { get; set; }
        [Required]
        [MaxLength(20)]
        public string CodDisc { get; set; }
        [MaxLength(25)]
        [Display(Name = "Centro de Custo")]
        public string CodCCusto { get; set; }
        [MaxLength(1)]
        public string Aplicacao { get; set; }
        [MaxLength(8)]
        public string CodFormula { get; set; }
        [Required]
        [Display(Name = "Código turno")]
        public int CodTurno { get; set; }
        [MaxLength(5)]
        public string CodPredio { get; set; }
        [MaxLength(10)]
        public string CodSala { get; set; }
        [MaxLength(4)]
        public string CodEvento { get; set; }
        public int? CodPlanilha { get; set; }
        public int? IdHabilitacaoFilial { get; set; }
        public int? NumAulasEm { get; set; }
        public int? DuracaoAula { get; set; }
        public int? MaxAlunos { get; set; }
        public short? CodTipoCurso { get; set; }
        [Display(Name = "Data Inicial")]
        [DataType(DataType.Date)]
        public DateTime? DtInicial { get; set; }
        [Display(Name = "Data Final")]
        [DataType(DataType.Date)]
        public DateTime? DtFinal { get; set; }
        public int? MinAlunos { get; set; }
        public decimal? CustoMedio { get; set; }
        [MaxLength(1)]
        public string DiscOpcional { get; set; }
        [MaxLength(1)]
        public string PreAlocacao { get; set; }
        [MaxLength(1)]
        public string CodEventoFalta { get; set; }
        [MaxLength(1)]
        public string CodEventoAtraso { get; set; }
        [MaxLength(100)]
        [Display(Name = "Disciplina")]
        public string NomeDisc { get; set; }
        public string Nome { get; set; }
        [MaxLength(1)]
        [Display(Name = "Tipo da turma")]
        public string Tipo { get; set; }
        [MaxLength(5)]
        public string CodBloco { get; set; }
        [Display(Name = "Código curso")]
        public string CodCurso { get; set; }
        [Display(Name = "Curso")]
        public string NomeCurso { get; set; }
        [Display(Name = "Habilitação")]
        public string CodHabilitacao { get; set; }
        [Display(Name = "Código Grade")]
        public string CodGrade { get; set; }
        [MaxLength(10)]
        public string CodCampus { get; set; }
        [MaxLength(1)]
        public string AdicionalNoturno { get; set; }
        [MaxLength(1)]
        public string AdicionalExtra { get; set; }
        public int? VagasCalouros { get; set; }
        public int? NumMaxAlunoOutrosCursos { get; set; }
        public int? VagasListaEspera { get; set; }
        public decimal? NumCreditosCob { get; set; }
        public decimal? ValorCredito { get; set; }
        [MaxLength(1)]
        public string DisponivelMatricula { get; set; }
        public string ComplementoDisc { get; set; }
        public DateTime? DtInicioMatPres { get; set; }
        public DateTime? DtFimMatPres { get; set; }
        [MaxLength(1)]
        public string Gerencial { get; set; }
        [Required]
        [MaxLength(1)]
        public string Ativa { get; set; }
        public int? IdTurmaDiscAntigo { get; set; }
        public int? NumMaxAlunosOutrasMtzAplicadas { get; set; }
        public int? Decimais { get; set; }
        [MaxLength(255)]
        public string AliasComunidade { get; set; }
        public short? CodTipoCursoPLetivo { get; set; }
        public string NomeFilial { get; set; }
        [MaxLength(1)]
        public string Compartilhada { get; set; }
        [MaxLength(1)]
        public string Espelho { get; set; }
        [MaxLength(50)]
        public string MascaraTurmaEspelho { get; set; }
        public int? NumMaxAlunoOutraColigada { get; set; }
        public string CodPerLet { get; set; }
        public int? CodPeriodo { get; set; }
        public string DescGrade { get; set; }

        public IList<STurmaDiscCompl> STurmaDiscCompl { get; set; }

        public override bool Equals(object obj)
        {
            var turmaDisciplina = obj as STurmaDisc;

            if (turmaDisciplina == null)
            {
                return false;
            }

            return
                this.CodColigada == turmaDisciplina.CodColigada &&
                this.IdTurmaDisc == turmaDisciplina.IdTurmaDisc;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(CodColigada);
            hash.Add(IdTurmaDisc);
            hash.Add(CodFilial);
            hash.Add(CodTurma);
            hash.Add(IdPerLet);
            hash.Add(CodDisc);
            hash.Add(CodTurno);
            hash.Add(Ativa);
            hash.Add(IdTurmaDiscAntigo);
            hash.Add(CodCurso);
            hash.Add(CodGrade);
            hash.Add(DtInicial);
            hash.Add(DtFinal);
            return hash.ToHashCode();
        }

        public string GetDiscGradeId()
        {
            return $"{CodColigada}$_${CodCurso}$_${CodHabilitacao}$_${CodGrade}$_${CodPeriodo}$_${CodDisc}";
        }

        public string GetGradeId()
        {
            return $"{CodColigada}$_${CodCurso}$_${CodHabilitacao}$_${CodGrade}";
        }
        public string GetCursoId()
        {
            return $"{CodColigada}$_${CodCurso}";
        }

        public string GetDisciplinaId()
        {
            return $"{CodColigada}$_${CodDisc}";
        }
        
        public string GetPeriodoLetivoId()
        {
            return $"{CodColigada}$_${IdPerLet}";
        }

        public IList<object> GetPrimaryKeyList()
        {
            return new List<object>
            {
                CodColigada,
                IdTurmaDisc
            };
        }
        public IList<string> GetPrimaryKeyNames()
        {
            return new List<string>
            {
                "CODCOLIGADA",
                "IDTURMADISC"
            };
        }

    }

    public class STurmaDiscCompl
    {
        public string Id { get; set; }
        public string ParentId { get; set; }
        public short CodColigada { get; set; }
        public int IdTurmaDisc { get; set; }
        public string Id_Moodle { get; set; }
        public string Id_Turma_Moodle { get; set; }
        public string Teste_Moodle { get; set; }
        [Display(Name = "Estudo Dirigido")]
        public string Est_Dirigido { get; set; }
        public string Agrupada { get; set; }
        public string Semanada { get; set; }
        public string LecSala { get; set; }
        [Display(Name = "Segunda Turma")]
        public string Seg_Turma { get; set; }
        public string Unificada { get; set; }
        [Display(Name = "Classificação")]
        public string Classificacao { get; set; }
        public string Oferta { get; set; }
        [Display(Name = "Observação")]
        public string Observacao { get; set; }
        public string CH_Alternativa { get; set; }
        [Display(Name = "CH Alternativa")]
        public string CH_Horas { get; set; }
        public string Superlocacao_Prof { get; set; }
        public string CadastraHorario { get; set; }
    }

}