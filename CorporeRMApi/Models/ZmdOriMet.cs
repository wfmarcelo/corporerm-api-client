
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models
{
    public class ZmdOriMet
    {
        public string Id { get; set; }
        [Required]
        public int Restds_Temp_Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string RA { get; set; }
        [Required]
        [MaxLength(20)]
        public string CodUsuario { get; set; }
        [Required]
        public int IdTurmaDisc { get; set; }
        [Required]
        public DateTime DataEnvio { get; set; }
        [Required]
        public DateTime DataPrevista { get; set; }
        public DateTime DataRetorno { get; set; }
        [Required]
        public int Status { get; set; }
        public string Observacao { get; set; }
        [MaxLength(20)]
        public string CodUsuarioOri { get; set; }
        public int IdPerLet { get; set; }
        public int CodTipoCurso { get; set; }
        public IList<ZmdArqOri> ZmdArqOri { get; set; }

        public override bool Equals(object obj)
        {
            var oriMet = obj as ZmdOriMet;

            if (oriMet == null)
            {
                return false;
            }
            
            return 
                Restds_Temp_Id == oriMet.Restds_Temp_Id &&
                RA == oriMet.RA &&
                IdTurmaDisc == oriMet.IdTurmaDisc;
        }

    }

    public class ZmdArqOri
    {
        public string Id { get; set; }
        public string Parent_Id { get; set; }
        [Required]
        public int Restds_Temp_Id { get; set; }
        [Required]
        public int OrientacaoId { get; set; }
        [Required]
        [MaxLength(60)]
        public string Nome { get; set; }
        [Required]
        public string NomeOriginal { get; set; }
        [Required]
        [MaxLength(10)]
        public string Extensao { get; set; }
        [Required]
        [MaxLength(100)]
        public string ContentType { get; set; }
        public int Tipo { get; set; }

        public override bool Equals(object obj)
        {
            var arqOri = obj as ZmdArqOri;

            if (arqOri == null)
            {
                return false;
            }
            
            return 
                Restds_Temp_Id == arqOri.Restds_Temp_Id &&
                OrientacaoId == arqOri.OrientacaoId;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(Parent_Id);
            hash.Add(Restds_Temp_Id);
            hash.Add(OrientacaoId);
            hash.Add(Nome);
            hash.Add(NomeOriginal);
            hash.Add(Extensao);
            hash.Add(ContentType);
            hash.Add(Tipo);
            return hash.ToHashCode();
        }
    }
}