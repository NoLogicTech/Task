using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TaskUltimateBibliotec.Models
{
    public partial class Projeto
    {
        public int ProjetoId { get; set; }
        public string ProjetoNumero { get; set; }
        public string ProjetoDesignacao { get; set; }
        public decimal? ProjetoValoraprovado { get; set; }
        public decimal? ProjetoIncentivoaprovado { get; set; }
        public decimal? ProjetoValorrealizado { get; set; }
        public decimal? ProjetoIncentivorecebido { get; set; }
        public DateTime? ProjetoDatasubmissao { get; set; }
        public DateTime? ProjetoDatadecisao { get; set; }
        public DateTime? ProjetoDatacontratacao { get; set; }
        public DateTime? ProjetoDatainicio { get; set; }
        public DateTime? ProjetoDatafim { get; set; }
        public string ProjetoResponsavel { get; set; }
        public int? ClienteId { get; set; }
        public int? MedidaId { get; set; }
        public int? EstadoId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Estadoprojeto Estado { get; set; }
        public virtual Medida Medida { get; set; }
    }
}
