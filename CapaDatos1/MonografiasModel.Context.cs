﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbmonografiasEntities : DbContext
    {
        public dbmonografiasEntities()
            : base("name=dbmonografiasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<AutorMonografia> AutorMonografia { get; set; }
        public virtual DbSet<Lector> Lector { get; set; }
        public virtual DbSet<Monografia> Monografia { get; set; }
        public virtual DbSet<Prestamo> Prestamo { get; set; }
    }
}
