using System;
namespace DemoDAL.Entities
{
    public class Allergy : IEntity
    {
        public Allergy()
        {
        }

        public int Id { get; set; }
        public string AllergyName { get; set; }
    }
}
