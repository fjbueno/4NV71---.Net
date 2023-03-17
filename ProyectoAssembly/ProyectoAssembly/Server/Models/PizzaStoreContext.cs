namespace ProyectoAssembly.Server.Models
{
    using Microsoft.EntityFrameworkCore;
    using ProyectoAssembly.Shared;
    public class PizzaStoreContext : DbContext
    {
        public DbSet<PizzaSpecial> Specials { get; set; }
        public PizzaStoreContext(DbContextOptions options)
        : base(options)
        {
        }
    }
}

