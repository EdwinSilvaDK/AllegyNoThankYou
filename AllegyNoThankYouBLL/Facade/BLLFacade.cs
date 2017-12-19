using System;
using Microsoft.Extensions.Configuration;
using AllegyNoThankYouDAL;
using AllegyNoThankYouDAL.Facade;
using AllegyNoThankYouBLL.Services;
using AllegyNoThankYouDAL.Repositories;

namespace AllegyNoThankYouBLL.Facade
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