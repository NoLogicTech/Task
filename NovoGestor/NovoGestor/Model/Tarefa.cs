using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace NovoGestor.Model
{
    public partial class Tarefa
    {
        public Tarefa()
        {
            InverseTarefaTarefasuperior = new HashSet<Tarefa>();
        }

        public int TarefaId { get; set; }
        public int TarefaTarefasuperiorid { get; set; }
        public int ProjetoId { get; set; }
        public string TarefaNome { get; set; }
        public DateTime TarefaDatahoraregisto { get; set; }
        public DateTime TarefaDatalimite { get; set; }
        public int TarefaPosicao { get; set; }
        public int UtilizadorIdcriador { get; set; }
        public int UtilizadorIdatribuido { get; set; }
        public bool TarefaEstado { get; set; }

        public virtual Tarefa TarefaTarefasuperior { get; set; }
        public virtual ICollection<Tarefa> InverseTarefaTarefasuperior { get; set; }
    }

}
