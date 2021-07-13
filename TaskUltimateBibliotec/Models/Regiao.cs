using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TaskUltimateBibliotec.Models
{
    public partial class Regiao
    {
        public Regiao()
        {
            Cliente = new HashSet<Cliente>();
        }

        public int RegiaoId { get; set; }
        public string RegiaoNome { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
