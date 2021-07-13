using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TaskUltimateBibliotec.Models
{
    public partial class Codpostal
    {
        public Codpostal()
        {
            Cliente = new HashSet<Cliente>();
        }

        public int CodpostalId { get; set; }
        public int DistritoId { get; set; }
        public int ConcelhoNumero { get; set; }
        public string ConcelhoCodigo { get; set; }
        public int ConcelhoId { get; set; }

        public virtual Concelho Concelho { get; set; }
        public virtual Distrito Distrito { get; set; }
        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
