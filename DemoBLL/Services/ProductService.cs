using System;
using System.Collections.Generic;
using DemoBLL.BusinessObjects;
using DemoDAL;
using DemoDAL.Entities;
using DemoBLL.Converters;
using System.Linq;

namespace DemoBLL.Services
{
    public class ProductService : IProductService
    {
        IDALFacade facade;
        private ProductConverter Pconv = new ProductConverter();

        public ProductService(IDALFacade facade)
        {
            this.facade = facade;
        }

        public ProductBO Create(ProductBO prod)
        {
            using (var uow = facade.UnitOfWork)
            {
                var newProd = uow.ProductRepository.Create(Pconv.Convert(prod));
                uow.Complete();
                return Pconv.Convert(newProd);

            }
        }

        public ProductBO Delete(int Id)
        {
            using (var uow = facade.UnitOfWork)
            {
                var newProd = uow.ProductRepository.Delete(Id);
                uow.Complete();
                return Pconv.Convert(newProd);

            }

        }

        public ProductBO Get(int Id)
        {
            using (var uow = facade.UnitOfWork)
            {
                return Pconv.Convert(uow.ProductRepository.Get(Id));
            }
        }

        public List<ProductBO> GetAll()
        {
            using (var uow = facade.UnitOfWork)
            {
                return uow.ProductRepository.GetAll().Select(p => Pconv.Convert(p)).ToList();
            }
        }

        public ProductBO Update(ProductBO prod)
        {
            using (var uow = facade.UnitOfWork)
            {
                var prodructFromDb = uow.ProductRepository.Get(prod.Id);
                if (prodructFromDb == null)
                {
                    throw new InvalidOperationException("Product not found");
                }
                prodructFromDb.Id = prod.Id;
                prodructFromDb.Name = prod.Name;
                prodructFromDb.Type = prod.Type;
                uow.Complete();
                return Pconv.Convert(prodructFromDb);
            }
        }

    }
}
