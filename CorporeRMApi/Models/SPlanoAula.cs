using System;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models
{
    public class SPlanoAula
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public int IdTurmaDisc { get; set; }
        [Display(Name = "Aula")]
        [Required]
        public int? Aula { get; set; }
        [Required]
        public int? IdHorarioTurma { get; set; }
        public short? CodFilial { get; set; }
        public string CodPredio { get; set; }
        public string CodSala { get; set; }
        public string CodProf { get; set; }
        public int? CodHor { get; set; }
        [Display(Name = "Data")]
        public DateTime? Data { get; set; }
        [Display(Name = "Conteúdo")]
        public string Conteudo { get; set; }
        public string Locacao { get; set; }
        [Display(Name = "Conteúdo efetivo")]
        public string ConteudoEfetivo { get; set; }
        [Display(Name = "Data efetiva")]
        public DateTime? DataEfetiva { get; set; }
        public string Reposicao { get; set; }
        public string Substituto { get; set; }
        public string PagamentoProf { get; set; }
        [Display(Name = "Início")]
        public string HoraInicial { get; set; }
        public string HoraInicialRealizado { get; set; }
        public string HoraFinalRealizado { get; set; }
        [Display(Name = "Fim")]
        public string HoraFinal { get; set; }
        public string CodTurma { get; set; }
        public string CodDisc { get; set; }
        public string NomeDisc { get; set; }
        public string TipoFalta { get; set; }
        public string CodBloco { get; set; }
        public string FrequenciaDispWeb { get; set; }
        [Display(Name = "Dia")]
        public string DiaSemana { get; set; }
        public string CodSubTurma { get; set; }
        public string LicaoCasa { get; set; }
        public string Observacao { get; set; }
        public string Confirmado { get; set; }
        public int IdPlanoAula { get; set; }
        [Display(Name = "Tipo aula")]
        public string TipoAula { get; set; }
        public int? IdPerLet { get; set; }
        public string Predio { get; set; }
        public string Bloco { get; set; }
        public string Sala { get; set; }

        public string GetTurmaDiscId()
        {
            return $"{CodColigada}$_${IdTurmaDisc}";
        }
    }
}