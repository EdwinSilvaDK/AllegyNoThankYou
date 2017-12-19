using System;
using DemoDAL.Entities;
using DemoBLL.BusinessObjects;
namespace DemoBLL.Converters
{
    public class Allergyconverter : IConverter<Allergy, AllergyBO>
    {
        public Allergyconverter()
        {
        }

        public Allergy Convert(AllergyBO Alg)
        {
            if (Alg == null) { return null; }
            {
                return new Allergy()
                {
                    AllergyName = Alg.AllergyName,
                    Id = Alg.Id,
                };

            }
        }

        public AllergyBO Convert(Allergy Alg)
        {
            if (Alg == null) { return null; }
            {
                return new AllergyBO()
                {
                    AllergyName = Alg.AllergyName,
                    Id = Alg.Id,
                };
            }
        }
    }
}
