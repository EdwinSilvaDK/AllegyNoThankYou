using System;
using System.Collections.Generic;
using DemoBLL.BusinessObjects;
using DemoDAL;
using DemoBLL.Converters;
using System.Linq;

namespace DemoBLL.Services
{
    public class IngredientService : IIngredientService
    {
        IDALFacade facade;

        private IngredientConverter Iconv = new IngredientConverter();

        public IngredientService(IDALFacade facade)
        {
            this.facade = facade;
        }

        public IngredientBO Create(IngredientBO ind)
        {
            using (var uow = facade.UnitOfWork)
            {
                var newInd = uow.IngredientRepository.Create(Iconv.Convert(ind));
                uow.Complete();
                return Iconv.Convert(newInd);


            }
        }

        public IngredientBO Delete(int Id)
        {
            using (var uow = facade.UnitOfWork)
            {
                var newInd = uow.IngredientRepository.Delete((Id));
                uow.Complete();
                return Iconv.Convert(newInd);


            }
        }

        public IngredientBO Get(int Id)
        {
            using (var uow = facade.UnitOfWork)
            {
                return Iconv.Convert(uow.IngredientRepository.Get(Id));

            }
        }

        public List<IngredientBO> GetAll()
        {
            using (var uow = facade.UnitOfWork)
            {
                return uow.IngredientRepository.GetAll().Select(i => Iconv.Convert(i)).ToList();

            }
        }

        public IngredientBO Update(IngredientBO ind)
        {
            using (var uow = facade.UnitOfWork)
            {
                var IngredientFromDb = uow.IngredientRepository.Get(ind.Id);
                if (IngredientFromDb == null)
                {
                    throw new InvalidOperationException("Product not found");
                }
                IngredientFromDb.Id = ind.Id;
                IngredientFromDb.Name = ind.Name;


                uow.Complete();
                return Iconv.Convert(IngredientFromDb);

            }
        }
    }
}
