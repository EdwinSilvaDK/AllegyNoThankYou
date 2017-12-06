using System;
using System.Collections.Generic;
using DemoDAL.Entities;
using DemoDAL.Context;
using System.Linq;

namespace DemoDAL.Repositories
{
    public class IngredientRepository : IIngredientRepository
    {
        EASVContext _context;
        public IngredientRepository(EASVContext context)
        {
            _context = context;
        }

        public Ingredient Create(Ingredient ind)
        {
            _context.Ingredients.Add(ind);
            return ind;
        }

        public Ingredient Delete(int Id)
        {
            var ind = Get(Id);
            _context.Ingredients.Remove(ind);
            return ind;
        }

        public Ingredient Get(int Id)
        {
            return _context.Ingredients.FirstOrDefault(i => i.Id == Id);

        }

        public IEnumerable<Ingredient> GetAll()
        {
            return _context.Ingredients.ToList();
        }

        public IEnumerable<Ingredient> GetAllById(List<int> ids)
        {
            return null;
        }
    }
}
