//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace reciclemos_v3.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class reciclemosEntities : DbContext
    {
        public reciclemosEntities()
            : base("name=reciclemosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<comuna> comuna { get; set; }
        public virtual DbSet<estado> estado { get; set; }
        public virtual DbSet<logros> logros { get; set; }
        public virtual DbSet<materiales> materiales { get; set; }
        public virtual DbSet<materiales_detalle> materiales_detalle { get; set; }
        public virtual DbSet<prospecto> prospecto { get; set; }
        public virtual DbSet<provincia> provincia { get; set; }
        public virtual DbSet<region> region { get; set; }
        public virtual DbSet<solicitud> solicitud { get; set; }
        public virtual DbSet<solicitud_detalle> solicitud_detalle { get; set; }
        public virtual DbSet<tipo_usuario> tipo_usuario { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
    }
}
