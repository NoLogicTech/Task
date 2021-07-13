using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TaskUltimateBibliotec.Models
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

        public virtual DbSet<Cae> Cae { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Codpostal> Codpostal { get; set; }
        public virtual DbSet<Concelho> Concelho { get; set; }
        public virtual DbSet<Dimensao> Dimensao { get; set; }
        public virtual DbSet<Distrito> Distrito { get; set; }
        public virtual DbSet<Estadoprojeto> Estadoprojeto { get; set; }
        public virtual DbSet<Medida> Medida { get; set; }
        public virtual DbSet<Projeto> Projeto { get; set; }
        public virtual DbSet<Regiao> Regiao { get; set; }
        public virtual DbSet<Setor> Setor { get; set; }
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
            modelBuilder.Entity<Cae>(entity =>
            {
                entity.ToTable("cae");

                entity.Property(e => e.CaeId).HasColumnName("caeId");

                entity.Property(e => e.CaeCodigo)
                    .IsRequired()
                    .HasColumnName("caeCodigo");

                entity.Property(e => e.CaeNome)
                    .IsRequired()
                    .HasColumnName("caeNome");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("cliente");

                entity.HasIndex(e => e.ClienteId)
                    .HasName("IX_cliente");

                entity.Property(e => e.ClienteId).HasColumnName("clienteId");

                entity.Property(e => e.CaeId).HasColumnName("cae_Id");

                entity.Property(e => e.ClienteEmail).HasColumnName("clienteEmail");

                entity.Property(e => e.ClienteErpid).HasColumnName("clienteErpid");

                entity.Property(e => e.ClienteNipc).HasColumnName("clienteNipc");

                entity.Property(e => e.ClienteNome)
                    .IsRequired()
                    .HasColumnName("clienteNome");

                entity.Property(e => e.ClienteTelefone).HasColumnName("clienteTelefone");

                entity.Property(e => e.CodpostalId).HasColumnName("codpostal_Id");

                entity.Property(e => e.ConcelhoId).HasColumnName("concelho_Id");

                entity.Property(e => e.DimensaoId).HasColumnName("dimensao_Id");

                entity.Property(e => e.DistritoId).HasColumnName("distrito_Id");

                entity.Property(e => e.RegiaoId).HasColumnName("regiao_Id");

                entity.Property(e => e.SetorId).HasColumnName("setor_Id");

                entity.HasOne(d => d.Cae)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.CaeId)
                    .HasConstraintName("FK_cliente_cae");

                entity.HasOne(d => d.Codpostal)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.CodpostalId)
                    .HasConstraintName("FK_cliente_codpostal");

                entity.HasOne(d => d.Concelho)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.ConcelhoId)
                    .HasConstraintName("FK_cliente_concelho");

                entity.HasOne(d => d.Dimensao)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.DimensaoId)
                    .HasConstraintName("FK_cliente_dimensao");

                entity.HasOne(d => d.Distrito)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.DistritoId)
                    .HasConstraintName("FK_cliente_distrito");

                entity.HasOne(d => d.Regiao)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.RegiaoId)
                    .HasConstraintName("FK_cliente_regiao");

                entity.HasOne(d => d.Setor)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.SetorId)
                    .HasConstraintName("FK_cliente_setor");
            });

            modelBuilder.Entity<Codpostal>(entity =>
            {
                entity.ToTable("codpostal");

                entity.Property(e => e.CodpostalId)
                    .HasColumnName("codpostalId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConcelhoCodigo)
                    .IsRequired()
                    .HasColumnName("concelho_Codigo");

                entity.Property(e => e.ConcelhoId).HasColumnName("concelho_Id");

                entity.Property(e => e.ConcelhoNumero).HasColumnName("concelho_Numero");

                entity.Property(e => e.DistritoId).HasColumnName("distrito_Id");

                entity.HasOne(d => d.Concelho)
                    .WithMany(p => p.Codpostal)
                    .HasForeignKey(d => d.ConcelhoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_codpostal_concelho");

                entity.HasOne(d => d.Distrito)
                    .WithMany(p => p.Codpostal)
                    .HasForeignKey(d => d.DistritoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_codpostal_distrito");
            });

            modelBuilder.Entity<Concelho>(entity =>
            {
                entity.ToTable("concelho");

                entity.Property(e => e.ConcelhoId).HasColumnName("concelhoId");

                entity.Property(e => e.ConcelhoCodigo)
                    .IsRequired()
                    .HasColumnName("concelhoCodigo");

                entity.Property(e => e.ConcelhoNome)
                    .IsRequired()
                    .HasColumnName("concelhoNome");

                entity.Property(e => e.ConcelhoNumero).HasColumnName("concelhoNumero");

                entity.Property(e => e.DistritoId).HasColumnName("distrito_Id");

                entity.Property(e => e.RegiaoId).HasColumnName("regiao_Id");

                entity.HasOne(d => d.Distrito)
                    .WithMany(p => p.Concelho)
                    .HasForeignKey(d => d.DistritoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_concelho_distrito");
            });

            modelBuilder.Entity<Dimensao>(entity =>
            {
                entity.ToTable("dimensao");

                entity.Property(e => e.DimensaoId).HasColumnName("dimensaoId");

                entity.Property(e => e.DimensaoNome)
                    .IsRequired()
                    .HasColumnName("dimensaoNome");
            });

            modelBuilder.Entity<Distrito>(entity =>
            {
                entity.ToTable("distrito");

                entity.Property(e => e.DistritoId).HasColumnName("distritoId");

                entity.Property(e => e.DistritoNome)
                    .IsRequired()
                    .HasColumnName("distritoNome")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Estadoprojeto>(entity =>
            {
                entity.ToTable("estadoprojeto");

                entity.Property(e => e.EstadoprojetoId).HasColumnName("estadoprojetoId");

                entity.Property(e => e.EstadoprojetoNome)
                    .IsRequired()
                    .HasColumnName("estadoprojetoNome");
            });

            modelBuilder.Entity<Medida>(entity =>
            {
                entity.ToTable("medida");

                entity.Property(e => e.MedidaId).HasColumnName("medidaId");

                entity.Property(e => e.MedidaNome)
                    .IsRequired()
                    .HasColumnName("medidaNome");

                entity.Property(e => e.MedidaPrograma)
                    .IsRequired()
                    .HasColumnName("medidaPrograma");
            });

            modelBuilder.Entity<Projeto>(entity =>
            {
                entity.ToTable("projeto");

                entity.Property(e => e.ProjetoId).HasColumnName("projetoId");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_Id");

                entity.Property(e => e.EstadoId).HasColumnName("estado_Id");

                entity.Property(e => e.MedidaId).HasColumnName("medida_Id");

                entity.Property(e => e.ProjetoDatacontratacao)
                    .HasColumnName("projetoDatacontratacao")
                    .HasColumnType("date");

                entity.Property(e => e.ProjetoDatadecisao)
                    .HasColumnName("projetoDatadecisao")
                    .HasColumnType("date");

                entity.Property(e => e.ProjetoDatafim)
                    .HasColumnName("projetoDatafim")
                    .HasColumnType("date");

                entity.Property(e => e.ProjetoDatainicio)
                    .HasColumnName("projetoDatainicio")
                    .HasColumnType("date");

                entity.Property(e => e.ProjetoDatasubmissao)
                    .HasColumnName("projetoDatasubmissao")
                    .HasColumnType("date");

                entity.Property(e => e.ProjetoDesignacao).HasColumnName("projetoDesignacao");

                entity.Property(e => e.ProjetoIncentivoaprovado)
                    .HasColumnName("projetoIncentivoaprovado")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ProjetoIncentivorecebido)
                    .HasColumnName("projetoIncentivorecebido")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ProjetoNumero).HasColumnName("projetoNumero");

                entity.Property(e => e.ProjetoResponsavel).HasColumnName("projetoResponsavel");

                entity.Property(e => e.ProjetoValoraprovado)
                    .HasColumnName("projetoValoraprovado")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ProjetoValorrealizado)
                    .HasColumnName("projetoValorrealizado")
                    .HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Projeto)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("FK_projeto_cliente");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.Projeto)
                    .HasForeignKey(d => d.EstadoId)
                    .HasConstraintName("FK_projeto_estadoprojeto");

                entity.HasOne(d => d.Medida)
                    .WithMany(p => p.Projeto)
                    .HasForeignKey(d => d.MedidaId)
                    .HasConstraintName("FK_projeto_medida");
            });

            modelBuilder.Entity<Regiao>(entity =>
            {
                entity.ToTable("regiao");

                entity.Property(e => e.RegiaoId).HasColumnName("regiaoId");

                entity.Property(e => e.RegiaoNome)
                    .IsRequired()
                    .HasColumnName("regiaoNome")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Setor>(entity =>
            {
                entity.ToTable("setor");

                entity.Property(e => e.SetorId).HasColumnName("setorId");

                entity.Property(e => e.SetorNome)
                    .IsRequired()
                    .HasColumnName("setorNome")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Tarefa>(entity =>
            {
                entity.ToTable("tarefa");

                entity.Property(e => e.TarefaId).HasColumnName("tarefaId");

                entity.Property(e => e.ProjetoId).HasColumnName("projeto_Id");

                entity.Property(e => e.TarefaDatahoraregisto)
                    .HasColumnName("tarefaDatahoraregisto")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TarefaDatalimite)
                    .HasColumnName("tarefaDatalimite")
                    .HasColumnType("date");

                entity.Property(e => e.TarefaEstado).HasColumnName("tarefaEstado");

                entity.Property(e => e.TarefaNome)
                    .IsRequired()
                    .HasColumnName("tarefaNome")
                    .HasColumnType("text");

                entity.Property(e => e.TarefaParentid).HasColumnName("tarefaParentid");

                entity.Property(e => e.TarefaPosicao).HasColumnName("tarefaPosicao");

                entity.Property(e => e.TarefaTemfilho).HasColumnName("tarefaTemfilho");

                entity.Property(e => e.UtilizadorIdatribuido).HasColumnName("utilizador_Idatribuido");

                entity.Property(e => e.UtilizadorIdcriador).HasColumnName("utilizador_Idcriador");

                entity.HasOne(d => d.TarefaParent)
                    .WithMany(p => p.InverseTarefaParent)
                    .HasForeignKey(d => d.TarefaParentid)
                    .HasConstraintName("FK_tarefa_tarefa");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
