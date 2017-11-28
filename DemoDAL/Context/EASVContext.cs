using Microsoft.EntityFrameworkCore;
using DemoDAL.Entities;

namespace DemoDAL.Context
{
    public class EASVContext : DbContext
    {
        public EASVContext(DbContextOptions<EASVContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Allergy> Allergies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configures one-to-many relationship
            modelBuilder.Entity<Product>().HasMany()


        }


    }
}