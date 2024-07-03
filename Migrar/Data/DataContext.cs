using Migrar.Model;
using Microsoft.EntityFrameworkCore;

namespace Migrar.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

   public DbSet<Destino> Destinos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Destino>().HasData(
            new Destino { Id = 1, Local = "Paris", Foto = "https://images.pexels.com/photos/1850619/pexels-photo-1850619.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", Valor = 2000.00M },
            new Destino { Id = 2, Local = "Toquio", Foto = "https://images.pexels.com/photos/2341830/pexels-photo-2341830.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", Valor = 2500.00M },
            new Destino { Id = 3, Local = "Rio de Janeiro", Foto = "https://images.pexels.com/photos/2876407/pexels-photo-2876407.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", Valor = 1000.00M },
            new Destino { Id = 4, Local = "Nova York", Foto = "https://images.pexels.com/photos/40142/new-york-skyline-manhattan-hudson-40142.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", Valor = 3000.00M },
            new Destino { Id = 5, Local = "Sydney", Foto = "https://images.pexels.com/photos/2193300/pexels-photo-2193300.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", Valor = 2800.00M },
            new Destino { Id = 6, Local = "Cidade do Cabo", Foto = "https://images.pexels.com/photos/136721/pexels-photo-136721.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", Valor = 2200.00M },
            new Destino { Id = 7, Local = "Barcelona", Foto = "https://images.pexels.com/photos/1388030/pexels-photo-1388030.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", Valor = 1800.00M },
            new Destino { Id = 8, Local = "Toronto", Foto = "https://images.pexels.com/photos/1519088/pexels-photo-1519088.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", Valor = 2400.00M }

    );
    }

    }
}