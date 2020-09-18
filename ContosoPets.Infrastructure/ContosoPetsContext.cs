using ContosoPets.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;


namespace ContosoPets.Infrastructure
{
    public class ContosoPetsContext : DbContext
    {
        public ContosoPetsContext(DbContextOptions<ContosoPetsContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}