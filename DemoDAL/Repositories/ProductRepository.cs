using System;


using System.Linq;
using DemoDAL.Context;
using DemoDAL.Entities;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;




namespace DemoDAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        EASVContext _context;

        public ProductRepository(EASVContext context)
        {
            _context = context;
        }


        public Product Create(Product prod)
        {
            _context.Products.Add(prod);
            return prod;
        }

        public Product Delete(int Id)
        {
            var prod = Get(Id);
            _context.Products.Remove(prod);
            return prod;
        }

        public Product Get(int Id)
        {
            var prod = _context.Products.FirstOrDefault(p => p.Id == Id);

            return prod;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products
                           .Include(p => p.Ingredients)
                           .ThenInclude(pi => pi.Ingredient)
                           .ToList();

        }


        public IEnumerable<Product> GetAllById(List<int> ids)
        {
            return null;
        }


    }
}
