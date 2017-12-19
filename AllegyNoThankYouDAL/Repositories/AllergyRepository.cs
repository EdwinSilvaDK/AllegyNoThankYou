using System;
using System.Collections.Generic;
using DemoDAL.Entities;
using DemoDAL.Context;
using System.Linq;

namespace DemoDAL.Repositories
{
    public class AllergyRepository : IAllergyRepository
    {
        EASVContext _context;
        public AllergyRepository(EASVContext context)
        {
            _context = context;

        }

        public Allergy Create(Allergy alg)
        {
            _context.Allergies.Add(alg);
            return alg;
        }

        public Allergy Delete(int Id)
        {
            var alg = Get(Id);
            _context.Allergies.Remove(alg);
            return alg;
        }

        public Allergy Get(int Id)
        {
            return _context.Allergies.FirstOrDefault(a => a.Id == Id);
        }

        public IEnumerable<Allergy> GetAll()
        {
            return _context.Allergies.ToList();
        }

        public IEnumerable<Allergy> GetAllById(List<int> ids)
        {
            return null;
        }
    }
}
