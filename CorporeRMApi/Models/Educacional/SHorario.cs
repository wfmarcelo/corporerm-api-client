using System;
using System.ComponentModel.DataAnnotations;
using Uniarp.Extensions;
using Uniarp.Util;

namespace CorporeRMApi.Models.Educacional
{
    public class SHorario
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public int CodHor { get; set; }
        [Required]
        public int CodTurno { get; set; }
        [Required]
        [Display(Name = "Dia semana")]
        public int DiaSemana { get; set; }
        [Required]
        [MaxLength(5)]
        [Display(Name = "Hora inicial")]
        public string HoraInicial { get; set; }
        [Required]
        [MaxLength(5)]
        [Display(Name = "Hora final")]
        public string HoraFinal { get; set; }
        [Required]
        [MaxLength(3)]
        public string Aula { get; set; }
        public int? IdPerLet { get; set; }
        [MaxLength(15)]
        public string Horario { get; set; }
        public short? Classificacao { get; set; }

        public override bool Equals(object obj)
        {
            var horario = obj as SHorario;

            if (horario == null)
            {
                return false;
            }

            return this.CodColigada == horario.CodColigada &&
                this.CodHor == horario.CodHor;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(CodColigada);
            hash.Add(CodHor);
            hash.Add(CodTurno);
            hash.Add(DiaSemana);
            hash.Add(HoraInicial);
            hash.Add(HoraFinal);
            hash.Add(Aula);
            hash.Add(IdPerLet);
            hash.Add(Horario);
            hash.Add(Classificacao);
            return hash.ToHashCode();
        }

        public string GetDiaSemana()
        {
            return ((DiaSemana)DiaSemana).GetDisplayName();
        }

        public int GetCargaHoraria()
        {
            return Formater.TimeToInt(HoraFinal) - Formater.TimeToInt(HoraInicial);
        }

        public int GetHorarioInicialInt()
        {
            return Formater.TimeToInt(HoraInicial);
        }
        public int GetHorarioFinalInt()
        {
            return Formater.TimeToInt(HoraFinal);
        }
    }
}