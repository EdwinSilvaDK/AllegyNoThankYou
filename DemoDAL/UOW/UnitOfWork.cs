using System;
using DemoDAL.Context;
using Microsoft.EntityFrameworkCore;
using DemoDAL.Repositories;


namespace DemoDAL.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private EASVContext context;
                
        public UnitOfWork(DbOptions opt)
        {
            DbContextOptions<EASVContext> options;
            if (opt.Environment == "Development" && String.IsNullOrEmpty(opt.ConnectionString))
            {
                options = new DbContextOptionsBuilder<EASVContext>()
                   .UseInMemoryDatabase("TheDB")
                   .Options;
            }
            else
            {
                options = new DbContextOptionsBuilder<EASVContext>()
                .UseSqlServer(opt.ConnectionString)
                    .Options;
            }

            context = new EASVContext(options);
        }

        //Fat Arrow!
        public IProductRepository ProductRepository { get => new ProductRepository(context); }
        public IIngredientRepository IngredientRepository { get => new IngredientRepository(context); }


        public int Complete()
        {
            //The number of objects written to the underlying database.
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

    }
}
