namespace CrudMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<Perfil> perfil { get; set; }
        public virtual DbSet<Persona> persona { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Perfil>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.clave)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.estado)
                .IsUnicode(false);
        }
    }
}
