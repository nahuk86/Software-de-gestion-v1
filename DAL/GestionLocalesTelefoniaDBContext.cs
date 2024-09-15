using ArqBase.Domain;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GestionLocalesTelefoniaDBContext : DbContext
    {
        public GestionLocalesTelefoniaDBContext(DbContextOptions<GestionLocalesTelefoniaDBContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Bitacora> Bitacora { get; set; }
        // Agrega otros DbSet según sea necesario

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configuraciones adicionales de modelos si es necesario
        }
    }
}