using Microsoft.EntityFrameworkCore;
using DemoDAL.Entities;

namespace DemoDAL.Context
{
    public class EASVContext : DbContext
    {
        public EASVContext(DbContextOptions<EASVContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }

    }
}