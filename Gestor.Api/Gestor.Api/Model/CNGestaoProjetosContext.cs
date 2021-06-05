using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Gestor.Api.Model
{
    public partial class CNGestaoProjetosContext : DbContext
    {
        public CNGestaoProjetosContext()
        {
        }

        public CNGestaoProjetosContext(DbContextOptions<CNGestaoProjetosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tarefa> Tarefa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=172.31.55.155;Initial Catalog=CNGestaoProjetos;Persist Security Info=True;User ID=sa;Password=SqlCascata@1;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarefa>(entity =>
            {
                entity.ToTable("tarefa");

                entity.Property(e => e.TarefaId).HasColumnName("tarefaId");

                entity.Property(e => e.ProjetoId).HasColumnName("projeto_Id");

                entity.Property(e => e.TarefaDatahoraregisto)
                    .HasColumnName("tarefaDatahoraregisto")
                    .HasColumnType("datetime");

                entity.Property(e => e.TarefaDatalimite)
                    .HasColumnName("tarefaDatalimite")
                    .HasColumnType("date");

                entity.Property(e => e.TarefaEstado).HasColumnName("tarefaEstado");

                entity.Property(e => e.TarefaNome)
                    .IsRequired()
                    .HasColumnName("tarefaNome")
                    .HasColumnType("text");

                entity.Property(e => e.TarefaPosicao).HasColumnName("tarefaPosicao");

                entity.Property(e => e.TarefaTarefasuperiorid).HasColumnName("tarefa_Tarefasuperiorid");

                entity.Property(e => e.UtilizadorIdatribuido).HasColumnName("utilizador_Idatribuido");

                entity.Property(e => e.UtilizadorIdcriador).HasColumnName("utilizador_Idcriador");

                entity.HasOne(d => d.TarefaTarefasuperior)
                    .WithMany(p => p.InverseTarefaTarefasuperior)
                    .HasForeignKey(d => d.TarefaTarefasuperiorid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tarefa_superior");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
