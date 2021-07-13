using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TaskUltimateBibliotec.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Projeto = new HashSet<Projeto>();
        }

        public int ClienteId { get; set; }
        public string ClienteErpid { get; set; }
        public string ClienteNipc { get; set; }
        public string ClienteNome { get; set; }
        public string ClienteEmail { get; set; }
        public string ClienteTelefone { get; set; }
        public int? DimensaoId { get; set; }
        public int? RegiaoId { get; set; }
        public int? SetorId { get; set; }
        public int? CaeId { get; set; }
        public int? CodpostalId { get; set; }
        public int? DistritoId { get; set; }
        public int? ConcelhoId { get; set; }

        public virtual Cae Cae { get; set; }
        public virtual Codpostal Codpostal { get; set; }
        public virtual Concelho Concelho { get; set; }
        public virtual Dimensao Dimensao { get; set; }
        public virtual Distrito Distrito { get; set; }
        public virtual Regiao Regiao { get; set; }
        public virtual Setor Setor { get; set; }
        public virtual ICollection<Projeto> Projeto { get; set; }
    }
}
