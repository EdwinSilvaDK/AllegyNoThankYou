using System;
using System.Collections.Generic;
using DemoDAL.Context;
using DemoDAL.Entities;

namespace DemoDAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        EASVContext _context;

        public ProductRepository(EASVContext context)
        {
            _context = context;
        }


        public Product Create(Product ent)
        {
            throw new NotImplementedException();
        }

        public Product Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Product Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllById(List<int> ids)
        {
            throw new NotImplementedException();
        }
    }
}
