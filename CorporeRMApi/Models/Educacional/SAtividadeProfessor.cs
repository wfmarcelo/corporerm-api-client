using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using Uniarp.Extensions;
using Uniarp.Util;

namespace CorporeRMApi.Models.Educacional
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
        [DataType(DataType.Date)]
        public DateTime? DtInicio { get; set; }
        [Display(Name = "Data final")]
        [DataType(DataType.Date)]
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

        public string CargaHorariaStringFormat()
        {
            return Formater.DecimalToTime((decimal)CargaHoraria);
        }

        public bool IsEditavel()
        {
            return Situacao == "I" ? true : false;
        }

        public bool IsCargaHorariaPreenchida()
        {
            var teste = GetCargaHoraria();
            return CargaHorariaCadastrada >= GetCargaHoraria();
        }

        public static IList<SHorarioAtivProf> GetChoqueAtividade(IList<SHorarioAtivProf> SHorarioAtivProf, DateTime dataInicial, DateTime dataFinal, int horaInicio, int horaFim, int diaSemana)
        {
            if (SHorarioAtivProf == null)
            {
                return new List<SHorarioAtivProf>();
            }

            
            return SHorarioAtivProf
                            .Where(h =>
                                (
                                    ((dataInicial.Date >= ((DateTime)h.DataInicio).Date && dataInicial.Date <= ((DateTime)h.DataFim).Date) ||
                                    (dataFinal.Date >= ((DateTime)h.DataInicio).Date && dataFinal.Date <= ((DateTime)h.DataFim).Date)) ||
                                    ((dataInicial.Date <= ((DateTime)h.DataInicio).Date && dataInicial.Date >= ((DateTime)h.DataFim).Date) ||
                                    (dataFinal.Date <= ((DateTime)h.DataInicio).Date && dataFinal.Date >= ((DateTime)h.DataFim).Date)) ||
                                    ((dataInicial.Date <= ((DateTime)h.DataInicio).Date && dataFinal.Date >= ((DateTime)h.DataFim).Date) ||
                                    (dataFinal.Date <= ((DateTime)h.DataInicio).Date && dataInicial.Date >= ((DateTime)h.DataFim).Date))
                                    )
                                &&
                                (
                                    (horaInicio > Formater.TimeToInt(h.HoraInicio) && horaFim < Formater.TimeToInt(h.HoraFim)) ||
                                    (horaFim > Formater.TimeToInt(h.HoraInicio) && horaFim <= Formater.TimeToInt(h.HoraFim)) ||
                                    (horaInicio >= Formater.TimeToInt(h.HoraInicio) && horaInicio < Formater.TimeToInt(h.HoraFim))
                                )
                                && h.DiaSemana == diaSemana.ToString()).Distinct().ToList();
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
        [DataType(DataType.Date)]
        [Display(Name = "Data Inicial")]
        public DateTime DataInicio { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data Final")]
        public DateTime DataFim { get; set; }
        [Display(Name = "Dia Semana")]
        public string DiaSemana { get; set; }
        [Display(Name = "Hora Inicial")]
        public string HoraInicio { get; set; }
        [Display(Name = "Hora Final")]
        public string HoraFim { get; set; }
        public string Turno { get; set; }
        public string DesconsideraPonto { get; set; }
        [JsonPropertyName("$state")]
        public int State { get; set; }

        public string GetDiaSemana()
        {
            return ((DiaSemana)int.Parse(DiaSemana)).GetDisplayName();
        }
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