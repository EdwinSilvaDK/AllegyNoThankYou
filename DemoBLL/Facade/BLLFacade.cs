using System;
using Microsoft.Extensions.Configuration;
using DemoDAL;
using DemoDAL.Facade;
using DemoBLL.Services;
using DemoDAL.Repositories;

namespace DemoBLL.Facade
{
    public class BLLFacade : IBLLFacade
    {
        private IDALFacade facade;

        public BLLFacade(IConfiguration conf)
        {
            facade = new DALFacade(new DbOptions()
            {
                ConnectionString = conf.GetConnectionString("DefaultConnection"),
                Environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")
            });
        }

        public IProductService ProductService
        {
            get { return new ProductService(facade); }
        }
        public IIngredientService IngredientService
        {
            get { return new IngredientService(facade); }
        }

    }
}