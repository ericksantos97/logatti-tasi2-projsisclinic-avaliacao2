﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjAvaliacaoP2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DadosEntities : DbContext
    {
        public DadosEntities()
            : base("name=DadosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_clinica> tb_clinica { get; set; }
        public virtual DbSet<tb_consulta> tb_consulta { get; set; }
        public virtual DbSet<tb_endereco> tb_endereco { get; set; }
        public virtual DbSet<tb_especialidade> tb_especialidade { get; set; }
        public virtual DbSet<tb_medico> tb_medico { get; set; }
        public virtual DbSet<tb_paciente> tb_paciente { get; set; }
    }
}