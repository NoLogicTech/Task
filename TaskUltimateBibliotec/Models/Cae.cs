using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TaskUltimateBibliotec.Models
{
    public partial class Cae
    {
        public Cae()
        {
            Cliente = new HashSet<Cliente>();
        }

        public int CaeId { get; set; }
        public string CaeCodigo { get; set; }
        public string CaeNome { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
