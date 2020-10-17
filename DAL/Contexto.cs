using Microsoft.EntityFrameworkCore;
using Prestamos_Tarea3.Entidades;

namespace Prestamos_Tarea3.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Prestamo> Prestamo { get; set; }
        public DbSet<Moras> Moras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite(@"Data Source=DATA\Prestamos.db");
        }
    }
}