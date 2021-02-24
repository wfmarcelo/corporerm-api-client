using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CorporeRMApi.Models.Educacional
{
    public class SCurso
    {
        public string Id { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        [MaxLength(10)]
        public string CodCurso { get; set; }
        [Required]
        public int CodTipoCurso { get; set; }
        [MaxLength(500)]
        public string Nome { get; set; }
        public IList<SCursoCompl> SCursoCompl { get; set; }

        public override bool Equals(object obj)
        {
            var curso = obj as SCurso;

            if (curso == null)
            {
                return false;
            }

            return
                this.CodColigada == curso.CodColigada &&
                this.CodCurso == curso.CodCurso;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, CodColigada, CodCurso, CodTipoCurso, Nome);
        }
    }

    public class SCursoCompl
    {
        public string Id { get; set; }
        public string ParentId { get; set; }
        [Required]
        public short CodColigada { get; set; }
        [Required]
        [MaxLength(10)]
        public string CodCurso { get; set; }
        public string Objetivo { get; set; }
        public string IntegradoAvalia { get; set; }
        
    }
}