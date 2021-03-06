﻿using Microsoft.EntityFrameworkCore;
using AllegyNoThankYouDAL.Entities;
using System.Collections.Generic;


namespace AllegyNoThankYouDAL.Context
{
    public class EASVContext : DbContext
    {
        public EASVContext(DbContextOptions<EASVContext> options) : base(options) { }


//The string is kept in the json file appsettings so this part is not necessary
/*      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=tcp:allegynothankyoudbserver.database.windows.net,1433;Initial Catalog=AllegyNoThankYouDB;Persist Security Info=False;User ID=jede;Password=Easv1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }
*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductIngredient>()
                        .HasKey(pi => new { pi.IngredientId, pi.ProductId });

            modelBuilder.Entity<ProductIngredient>()
                        .HasOne(pi => pi.Ingredient)
                        .WithMany(p => p.Products)
                        .HasForeignKey(pi => pi.IngredientId);

            modelBuilder.Entity<ProductIngredient>()
                        .HasOne(pi => pi.Product)
                        .WithMany(i => i.Ingredients)
                        .HasForeignKey(pi => pi.ProductId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
    }

}