﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CentroNaturistaMasaya.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CNMEntities : DbContext
    {
        public CNMEntities()
            : base("name=CNMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Consulta> Consultas { get; set; }
        public virtual DbSet<Contenido> ContenidoS { get; set; }
        public virtual DbSet<ContenidoV> ContenidoVs { get; set; }
        public virtual DbSet<Empleado> Empleadoes { get; set; }
        public virtual DbSet<Existencia> Existencias { get; set; }
        public virtual DbSet<Paciente> Pacientes { get; set; }
        public virtual DbSet<PRecetado> PRecetadoes { get; set; }
        public virtual DbSet<Presentacion> Presentacions { get; set; }
        public virtual DbSet<Producto> Productoes { get; set; }
        public virtual DbSet<Proveedor> Proveedors { get; set; }
        public virtual DbSet<Suministro> Suministroes { get; set; }
        public virtual DbSet<TelefonoP> TelefonoPs { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }
    }
}
