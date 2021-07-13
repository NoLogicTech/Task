using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TaskUltimateBibliotec.Models
{
    public partial class Medida
    {
        public Medida()
        {
            Projeto = new HashSet<Projeto>();
        }

        public int MedidaId { get; set; }
        public string MedidaNome { get; set; }
        public string MedidaPrograma { get; set; }

        public virtual ICollection<Projeto> Projeto { get; set; }
    }
}
