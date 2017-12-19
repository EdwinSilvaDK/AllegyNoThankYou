using System;
using System.Collections.Generic;
using DemoBLL.BusinessObjects;
using DemoDAL;
using DemoBLL.Converters;
using System.Linq;

namespace DemoBLL.Services
{
    public class AllergyService : IAllergyService
    {
        IDALFacade facade;
        private Allergyconverter Aconv = new Allergyconverter();
        public AllergyService(IDALFacade facade)
        {
            this.facade = facade;
        }

        public AllergyBO Create(AllergyBO alg)
        {
            using (var uow = facade.UnitOfWork)
            {
                var newAlg = uow.AllergyRepository.Create(Aconv.Convert(alg));
                uow.Complete();
                return Aconv.Convert(newAlg);


            }
        }

        public AllergyBO Delete(int Id)
        {
            using (var uow = facade.UnitOfWork)
            {
                var newAlg = uow.AllergyRepository.Delete((Id));
                uow.Complete();
                return Aconv.Convert(newAlg);



            }
        }

        public AllergyBO Get(int Id)
        {
            using (var uow = facade.UnitOfWork)
            {
                return Aconv.Convert(uow.AllergyRepository.Get(Id));


            }
        }

        public List<AllergyBO> GetAll()
        {
            using (var uow = facade.UnitOfWork)
            {
                return uow.AllergyRepository.GetAll().Select(a => Aconv.Convert(a)).ToList();


            }
        }

        public AllergyBO Update(AllergyBO alg)
        {
            using (var uow = facade.UnitOfWork)
            {
                var AllergyFromDb = uow.AllergyRepository.Get(alg.Id);
                if (AllergyFromDb == null)
                {
                    throw new InvalidOperationException("Product not found");
                }
                AllergyFromDb.AllergyName = alg.AllergyName;
                AllergyFromDb.Id = alg.Id;
                uow.Complete();
                return Aconv.Convert(AllergyFromDb);


            }
        }
    }
}
