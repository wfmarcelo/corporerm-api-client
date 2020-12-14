using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Uniarp.Util;

namespace CorporeRMApi.Models
{
    public class SAtividadeProfessor
    {

        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public int IdAtividadeProf { get; set; }
        [Required]
        public string CodProf { get; set; }
        public int? IdOferta { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public string Instituicao { get; set; }
        [Display(Name = "Carga horária")]
        public decimal? CargaHoraria { get; set; }
        public int? EquivHoraAula { get; set; }
        [Display(Name = "Observação")]
        public string Observacao { get; set; }
        public string ProgPrjLinhaP { get; set; }
        public string AreaConc { get; set; }
        public string Situacao { get; set; }
        public string Metas { get; set; }
        public string FontFinanciamento { get; set; }
        public string VincProdAcademica { get; set; }
        public string FormaParticipacao { get; set; }
        public string Nivel { get; set; }
        public string Coordenador { get; set; }
        public string Ano { get; set; }
        public string TipoAtividade { get; set; }
        [Display(Name = "Valor hora")]
        public decimal? ValorHora { get; set; }
        [Display(Name = "Data inicial")]
        public DateTime? DtInicio { get; set; }
        [Display(Name = "Data final")]
        public DateTime? DtTermino { get; set; }
        public string CodCCusto { get; set; }
        public string Remunerada { get; set; }
        [Required]
        public int? IdAtividadeExtra { get; set; }
        public string DesconsideraPonto { get; set; }
        public string CompoeSalario { get; set; }
        public string RecCreatedBy { get; set; }
        public DateTime? RecCreatedOn { get; set; }
        public string RecModifiedBy { get; set; }
        public DateTime? RecModiefiedOn { get; set; }
        public ushort? Status { get; set; }
        public string Nome { get; set; }
        public string NomeCentroCusto { get; set; }
        public int? CodFilial { get; set; }
        public IList<SHorarioAtivProf> SHorarioAtivProf { get; set; }
        public IList<SAtivColaborador> SAtivColaborador { get; set; }

        public int CargaHorariaCadastrada
        {
            get
            {
                if (SHorarioAtivProf == null)
                {
                    return 0;
                }
                
                if (SHorarioAtivProf.Count == 0)
                {
                    return 0;
                }

                return SHorarioAtivProf.Sum(h => Formater.TimeToInt(h.HoraFim) - Formater.TimeToInt(h.HoraInicio));
            }
        }

        public int GetCargaHoraria()
        {
            return Formater.TimeToInt(Formater.DecimalToTime((decimal)CargaHoraria));
        }

        public bool IsEditavel()
        {
            return Situacao == "I" ? true : false;
        }

        public bool IsCargaHorariaPreenchida()
        {
            return CargaHorariaCadastrada < CargaHoraria;
        }
    }

    public class SHorarioAtivProf
    {
        public string Id { get; set; }
        public string Parent_Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public int IdHorarioAtivProf { get; set; }
        [Required]
        public int IdAtividadeProf { get; set; }
        [Required]
        public int CodHor { get; set; }
        [Required]
        public DateTime DataInicio { get; set; }
        [Required]
        public DateTime DataFim { get; set; }
        [Display(Name = "Dia Semana")]
        public string DiaSemana { get; set; }
        [Display(Name = "Hora Inicial")]
        public string HoraInicio { get; set; }
        [Display(Name = "Hora Final")]
        public string HoraFim { get; set; }
        public string Turno { get; set; }
        public string DesconsideraPonto { get; set; }
    }

    public class SAtivColaborador
    {
        public string Id { get; set; }
        public string Parent_Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public int IdColaborador { get; set; }
        [Required]
        public int IdAtividadeProf { get; set; }
        [Required]
        public string Nome { get; set; }
    }
}