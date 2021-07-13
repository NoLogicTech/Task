using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TaskUltimateBibliotec.Models
{
    public partial class Concelho
    {
        public Concelho()
        {
            Cliente = new HashSet<Cliente>();
            Codpostal = new HashSet<Codpostal>();
        }

        public int ConcelhoId { get; set; }
        public string ConcelhoNome { get; set; }
        public string ConcelhoCodigo { get; set; }
        public int ConcelhoNumero { get; set; }
        public int DistritoId { get; set; }
        public int? RegiaoId { get; set; }

        public virtual Distrito Distrito { get; set; }
        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual ICollection<Codpostal> Codpostal { get; set; }
    }
}
