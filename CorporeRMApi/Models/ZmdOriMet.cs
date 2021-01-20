
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
        [Display(Name = "Registro Acadêmico")]
        public string RA { get; set; }
        [Required]
        [MaxLength(20)]
        public string CodUsuario { get; set; }
        [Required]
        public int IdTurmaDisc { get; set; }
        [Required]
        [Display(Name = "Data Envio")]
        public DateTime DataEnvio { get; set; }
        [Required]
        [Display(Name = "Data Prevista")]
        public DateTime DataPrevista { get; set; }
        [Display(Name = "Data Retorno")]
        public DateTime? DataRetorno { get; set; }
        [Required]
        public int Status { get; set; }
        [Display(Name = "Observação")]
        public string Observacao { get; set; }
        [MaxLength(20)]
        public string CodUsuarioOri { get; set; }
        public int IdPerLet { get; set; }
        public int CodTipoCurso { get; set; }
        public IList<ZmdArqOri> ZmdArqOri { get; set; }
        [Display(Name = "Aluno")]
        public string NomeAluno { get; set; }
        public string CodDisc { get; set; }
        [Display(Name = "Disciplina")]
        public string NomeDisciplina { get; set; }
        public short CodColigada { get; set; }

        public string GetAlunoId()
        {
            return $"{CodColigada}$_${RA}";
        }

        public string GetMatriculaId()
        {
            return $"{CodColigada}$_${IdTurmaDisc}$_${RA}";
        }

        public string GetTurmaDiscId()
        {
            return $"{CodColigada}$_${IdTurmaDisc}";
        }


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

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(Restds_Temp_Id);
            hash.Add(RA);
            hash.Add(CodUsuario);
            hash.Add(IdTurmaDisc);
            hash.Add(DataEnvio);
            hash.Add(DataPrevista);
            hash.Add(DataRetorno);
            hash.Add(Status);
            hash.Add(Observacao);
            hash.Add(CodUsuarioOri);
            hash.Add(IdPerLet);
            hash.Add(CodTipoCurso);
            hash.Add(ZmdArqOri);
            return hash.ToHashCode();
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
        [Display(Name = "Nome Original")]
        public string NomeOriginal { get; set; }
        [Required]
        [MaxLength(10)]
        [Display(Name = "Extensão")]
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