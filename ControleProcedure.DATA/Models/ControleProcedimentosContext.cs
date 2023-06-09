﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ControleProcedure.DATA.Models
{
    public partial class ControleProcedimentosContext : DbContext
    {
        public ControleProcedimentosContext()
        {
        }

        public ControleProcedimentosContext(DbContextOptions<ControleProcedimentosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<ClientesProcedimentos> ClientesProcedimentos { get; set; }
        public virtual DbSet<Servicos> Servicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-N3KBHKL3;Initial Catalog=ControleProcedimentos;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.CliBairro).IsUnicode(false);

                entity.Property(e => e.CliCidade).IsUnicode(false);

                entity.Property(e => e.CliCpf).IsUnicode(false);

                entity.Property(e => e.CliEndereco).IsUnicode(false);

                entity.Property(e => e.CliNome).IsUnicode(false);

                entity.Property(e => e.CliNumero).IsUnicode(false);

                entity.Property(e => e.CliTelefoneCelular).IsUnicode(false);

                entity.Property(e => e.CliTelefoneFixo).IsUnicode(false);
            });

            modelBuilder.Entity<ClientesProcedimentos>(entity =>
            {
                entity.HasOne(d => d.CpIdClienteNavigation)
                    .WithMany(p => p.ClientesProcedimentos)
                    .HasForeignKey(d => d.CpIdCliente)
                    .HasConstraintName("FK_ClientesProcedimentos_Cliente");

                entity.HasOne(d => d.CpIdProcedimentoNavigation)
                    .WithMany(p => p.ClientesProcedimentos)
                    .HasForeignKey(d => d.CpIdProcedimento)
                    .HasConstraintName("FK_ClientesProcedimentos_Procedimento");
            });

            modelBuilder.Entity<Servicos>(entity =>
            {
                entity.Property(e => e.ProcedLocal).IsUnicode(false);

                entity.Property(e => e.ProcedNome).IsUnicode(false);

                entity.Property(e => e.ProcedObservacao).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}