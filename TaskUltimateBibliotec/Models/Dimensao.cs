using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TaskUltimateBibliotec.Models
{
    public partial class Dimensao
    {
        public Dimensao()
        {
            Cliente = new HashSet<Cliente>();
        }

        public int DimensaoId { get; set; }
        public string DimensaoNome { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
