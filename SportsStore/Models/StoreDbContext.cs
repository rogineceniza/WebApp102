using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace SportsStore.Models
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }

        public DbSet<Product> Products => Set<Product>();
    }
}