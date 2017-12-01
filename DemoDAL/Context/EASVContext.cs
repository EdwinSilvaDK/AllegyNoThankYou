using Microsoft.EntityFrameworkCore;
using DemoDAL.Entities;
using System.Collections.Generic;


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
            modelBuilder.Entity<ProductIngredient>()
                        .HasKey(pi => new { pi.IngredientId, pi.ProductId });

            modelBuilder.Entity<ProductIngredient>()
                        .HasOne(pi => pi.Ingredient)
                        .WithMany(a => a.Products)
                        .HasForeignKey(pi => pi.IngredientId);

            modelBuilder.Entity<ProductIngredient>()
                        .HasOne(pi => pi.Product)
                        .WithMany(i => i.Ingredients)
                        .HasForeignKey(pi => pi.ProductId);


            base.OnModelCreating(modelBuilder);
        }


    }
}