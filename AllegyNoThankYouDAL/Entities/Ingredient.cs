using System;
using System.Collections.Generic;
namespace AllegyNoThankYouDAL.Entities
{
    public class Ingredient : IEntity
    {
        public Ingredient()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }


        public List<ProductIngredient> Products { get; set; }
    }
}
