using System;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models.Educacional
{
    public class SCoordenador
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public int IdCoordenador { get; set; }
        [Required]
        public int IdHabilitacaoFilial { get; set; }
        [Required]
        public int CodPessoa { get; set; }
        [MaxLength(120)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(1)]
        public string Funcao { get; set; }
        [Required]
        public DateTime DtInicio { get; set; }
        public DateTime? DtFim { get; set; }
        public string CodUsuario { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            var coordenador = obj as SCoordenador;

            if (coordenador == null)
            {
                return false;
            }

            return
                this.CodColigada == coordenador.CodColigada &&
                this.IdCoordenador == coordenador.IdCoordenador;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(CodColigada);
            hash.Add(IdCoordenador);
            hash.Add(IdHabilitacaoFilial);
            hash.Add(CodPessoa);
            hash.Add(Nome);
            hash.Add(Funcao);
            hash.Add(DtInicio);
            hash.Add(DtFim);
            hash.Add(CodUsuario);
            hash.Add(Email);
            return hash.ToHashCode();
        }
    }
}