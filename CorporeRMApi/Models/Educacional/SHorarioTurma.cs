using System;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models.Educacional
{
    public class SHorarioTurma
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        public int IdHorarioTurma { get; set; }
        [Required]
        public int CodHor { get; set; }
        [Required]
        public int IdTurmaDisc { get; set; }
        public short? CodFilial { get; set; }
        [MaxLength(5)]
        public string CodPredio { get; set; }
        [MaxLength(10)]
        public string CodSala { get; set; }
        [Display(Name = "Data inicial")]
        public DateTime? DataInicial { get; set; }
        [Display(Name = "Data final")]
        public DateTime? DataFinal { get; set; }
        [MaxLength(60)]
        public string Locacao { get; set; }
        [MaxLength(1)]
        public string TipoAula { get; set; }
        [MaxLength(15)]
        public string NomeTurno { get; set; }
        [Display(Name="Dia semana")]
        public short? DiaSemana { get; set; }
        [MaxLength(5)]
        [Display(Name = "Hora inicial")]
        public string HoraInicial { get; set; }
        [MaxLength(5)]
        [Display(Name = "Hora final")]
        public string HoraFinal { get; set; }
        public int? IdPerLet { get; set; }
        [MaxLength(5)]
        public string CodBloco { get; set; }
        public short? CodTipoSala { get; set; }
        public string RecCreatedBy { get; set; }
        public DateTime? RecCreatedOn { get; set; }
        public string RecModifiedBy { get; set; }
        public DateTime? RecModifiedOn { get; set; }
        [MaxLength(20)]
        public string CodSubTurma { get; set; }
        public int? IdHorarioTurmaVinc { get; set; }
        [MaxLength(255)]
        public string ScientiaActivityHostKey { get; set; }
        [MaxLength(100)]
        public string CodHorarioTurma { get; set; }
        public string Espelho { get; set; }
        public short? CodTipoCurso { get; set; }

        public override bool Equals(object obj)
        {
            var horarioTurma = obj as SHorarioTurma;
            
            if (horarioTurma == null)
            {
                return false;
            }
            
            return 
                this.CodColigada == horarioTurma.CodColigada &&
                this.IdHorarioTurma == horarioTurma.IdHorarioTurma;

        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(CodColigada);
            hash.Add(IdHorarioTurma);
            hash.Add(CodHor);
            hash.Add(IdTurmaDisc);
            hash.Add(CodFilial);
            hash.Add(CodPredio);
            hash.Add(CodSala);
            hash.Add(DataInicial);
            hash.Add(DataFinal);
            hash.Add(Locacao);
            hash.Add(TipoAula);
            hash.Add(NomeTurno);
            hash.Add(DiaSemana);
            hash.Add(HoraInicial);
            hash.Add(HoraFinal);
            hash.Add(IdPerLet);
            hash.Add(CodBloco);
            hash.Add(CodTipoSala);
            hash.Add(RecCreatedBy);
            hash.Add(RecCreatedOn);
            hash.Add(RecModifiedBy);
            hash.Add(RecModifiedOn);
            hash.Add(CodSubTurma);
            hash.Add(IdHorarioTurmaVinc);
            hash.Add(ScientiaActivityHostKey);
            hash.Add(CodHorarioTurma);
            hash.Add(Espelho);
            hash.Add(CodTipoCurso);
            return hash.ToHashCode();
        }
    }
}