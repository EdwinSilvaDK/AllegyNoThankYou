﻿using System;
using System.Collections.Generic;
using DemoBLL.BusinessObjects;
using DemoDAL;
using DemoBLL;
using DemoDAL.Entities;
using DemoBLL.Converters;
using System.Linq;

namespace DemoBLL.Services
{
    public class ProductService : IProductService
    {
        IDALFacade facade;
        private ProductConverter Pconv = new ProductConverter();
        private IngredientConverter Iconv = new IngredientConverter();

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
                var prod = Pconv.Convert(uow.ProductRepository.Get(Id));

                prod.Ingredients = prod.IngredientIds?
                    .Select(id => Iconv.Convert(uow.IngredientRepository.Get(id)))
                    .ToList();

                return prod;
            }
        }

        public List<ProductBO> GetAll()
        {
            using (var uow = facade.UnitOfWork)
            {
                return uow.ProductRepository.GetAll().Select(p => Pconv.Convert(p)).ToList();
            }
        }


        public List<IngredientBO> GetAllFilteredIngredient(List<int> ids)
        {


            var Ingredient = GetAllIndgredients();
            var filteredIngredient = Ingredient.Where(i => !ids.Contains(i.Id)).ToList();
            return filteredIngredient;

        }



        public List<IngredientBO> GetAllIndgredients()
        {
            using (var uow = facade.UnitOfWork)
            {
                return uow.IngredientRepository.GetAll().Select(i => Iconv.Convert(i)).ToList();

            }
        }

        public ProductBO Update(ProductBO prod)
        {
            using (var uow = facade.UnitOfWork)
            {
                var ProductFromDb = uow.ProductRepository.Get(prod.Id);
                if (ProductFromDb == null)
                {
                    throw new InvalidOperationException("Product not found");
                }
                var productUpdated = Pconv.Convert(prod);
                ProductFromDb.Id = productUpdated.Id;
                ProductFromDb.Name = productUpdated.Name;
                ProductFromDb.Type = productUpdated.Type;
                ProductFromDb.Ingredients = productUpdated.Ingredients;
                uow.Complete();
                return Pconv.Convert(ProductFromDb);
            }
        }

    }
}
