using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models.Educacional
{
    public enum DiaSemana
    {
        Domingo = 1,
        [Display(Name = "Segunda-Feira")]
        Segunda = 2,
        [Display(Name = "Terça-Feira")]
        Terca = 3,
        [Display(Name = "Quarta-Feira")]
        Quarta = 4,
        [Display(Name = "Quinta-Feira")]
        Quinta = 5,
        [Display(Name = "Sexta-Feira")]
        Sexta = 6,
        [Display(Name = "Sábado")]
        Sabado = 7
    }
}