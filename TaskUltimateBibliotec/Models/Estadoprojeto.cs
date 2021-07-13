using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TaskUltimateBibliotec.Models
{
    public partial class Estadoprojeto
    {
        public Estadoprojeto()
        {
            Projeto = new HashSet<Projeto>();
        }

        public int EstadoprojetoId { get; set; }
        public string EstadoprojetoNome { get; set; }

        public virtual ICollection<Projeto> Projeto { get; set; }
    }
}
