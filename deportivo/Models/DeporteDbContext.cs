using Microsoft.EntityFrameworkCore;

namespace deportivo.Models
{
    public class DeporteDbContext : DbContext
    {
        public DbSet<RegistrarUsuario> Usuarios { get; set; }

        public DbSet<Producto> Productos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DeporteDbContext(DbContextOptions <DeporteDbContext> o) : base(o){
            
        } 
    }
}