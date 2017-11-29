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
                        .HasKey(pi => new { pi.ProductId, pi.IngredientId });


            modelBuilder.Entity<ProductIngredient>()
                        .HasOne(pi => pi.Product)
                        .WithMany(I => I.Ingredients)
                        .HasForeignKey(pi => pi.ProductId);

            modelBuilder.Entity<ProductIngredient>()
                        .HasOne(pi => pi.Ingredient)
                        .WithMany(p => p.Products)
                        .HasForeignKey(pi => pi.IngredientId);




        }


    }
}