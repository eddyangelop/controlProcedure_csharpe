﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace controlProcedure.DATA.Models
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
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();

                optionsBuilder.UseSqlServer(configuration.GetConnectionString("Homologacao"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}