using Microsoft.EntityFrameworkCore;
using OA.Data;

namespace OA.Repo
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new ProductMap(modelBuilder.Entity<Product>());
            new ProductProfileMap(modelBuilder.Entity<ProductProfile>());
        }
    }
}
