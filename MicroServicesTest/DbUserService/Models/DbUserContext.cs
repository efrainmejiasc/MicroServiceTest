using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbUserService.Models
{
    public class DbUserContext : DbContext
    {
        public DbUserContext(DbContextOptions<DbUserContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        //public DbSet<KeyCardUsuario> KeyCardUsuario { get; set; }

        // Sobreescribe el método OnConfiguring o utiliza UseNpgsql para configurar la conexión a PostgreSQL
        // Aquí se utiliza el método OnConfiguring
        // Nota: Entity Framework Core recomienda configurar la cadena de conexión en appsettings.json y utilizar el método UseNpgsql en Startup.cs.
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // Reemplaza "DefaultConnection" con el nombre de tu cadena de conexión en appsettings.json
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=TestTask;User Id=postgres;Password=yourpassword;");
        //    }
        //}
    }
}
