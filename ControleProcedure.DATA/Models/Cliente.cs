﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleProcedure.DATA.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            ClientesProcedimentos = new HashSet<ClientesProcedimentos>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("cliCPF")]
        [StringLength(14)]
        [DisplayName("CPF")]
        public string CliCpf { get; set; }
        [Column("cliNome")]
        [StringLength(200)]
        public string CliNome { get; set; }
        [Column("cliEndereco")]
        [StringLength(200)]
        public string CliEndereco { get; set; }
        [Column("cliCidade")]
        [StringLength(100)]
        public string CliCidade { get; set; }
        [Column("cliBairro")]
        [StringLength(100)]
        public string CliBairro { get; set; }
        [Column("cliNumero")]
        [StringLength(50)]
        public string CliNumero { get; set; }
        [Column("cliTelefoneCelular")]
        [StringLength(14)]
        public string CliTelefoneCelular { get; set; }
        [Column("cliTelefoneFixo")]
        [StringLength(13)]
        public string CliTelefoneFixo { get; set; }

        [InverseProperty("CpIdClienteNavigation")]
        public virtual ICollection<ClientesProcedimentos> ClientesProcedimentos { get; set; }
    }
}