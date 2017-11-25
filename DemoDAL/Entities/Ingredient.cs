using System;
namespace DemoDAL.Entities
{
    public class Ingredient : IEntity
    {
        public Ingredient()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int AllergyId { get; set; }
    }
}
