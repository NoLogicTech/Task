using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TaskUltimateBibliotec.Models
{
    public partial class Setor
    {
        public Setor()
        {
            Cliente = new HashSet<Cliente>();
        }

        public int SetorId { get; set; }
        public string SetorNome { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
