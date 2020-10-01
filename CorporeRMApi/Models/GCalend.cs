using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models
{
    public class GCalend
    {
        public string Id { get; set; }
        [Required]
        [MaxLength(16)]
        public string Codigo { get; set; }
        [MaxLength(40)]
        public string Nome { get; set; }
        public IList<GFeriado> GFeriado { get; set; }

        public override bool Equals(object obj)
        {
            var calendario = obj as GCalend;

            if (calendario == null)
            {
                return false;
            }

            return this.Codigo == calendario.Codigo;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Codigo, Nome, GFeriado);
        }
    }

    public class GFeriado
    {
        public string Id { get; set; }
        public string Parent_Id { get; set; }
        [Required]
        [MaxLength(16)]
        public string CodCalendario { get; set; }
        [Required]
        public DateTime DiaFeriado { get; set; }
        [MaxLength(50)]
        public string Nome { get; set; }
        public int? HoraInicio { get; set; }
        public int? HoraFinal { get; set; }
        public char Feriado { get; set; }
        public string Tipo { get; set; }
        public short? IgnoraNasFerias { get; set; }

    }
}