using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TaskUltimateBibliotec.Models
{
    public partial class Distrito
    {
        public Distrito()
        {
            Cliente = new HashSet<Cliente>();
            Codpostal = new HashSet<Codpostal>();
            Concelho = new HashSet<Concelho>();
        }

        public int DistritoId { get; set; }
        public string DistritoNome { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual ICollection<Codpostal> Codpostal { get; set; }
        public virtual ICollection<Concelho> Concelho { get; set; }
    }
}
