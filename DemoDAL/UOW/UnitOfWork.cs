using System;
using DemoDAL.Context;
using Microsoft.EntityFrameworkCore;
using DemoDAL.Repositories;


namespace DemoDAL.UOW
{
    public class UnitOfWork : IUnitOfWork
    {

        public IProductRepository ProductRepository { get; internal set; }
        public IIngredientRepository IngredientRepository { get; internal set; }

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
            ProductRepository = new ProductRepository(context);
            IngredientRepository = new IngredientRepository(context);



        }






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
