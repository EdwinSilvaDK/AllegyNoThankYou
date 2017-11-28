using System;
using System.Collections.Generic;
namespace DemoDAL.Entities
{
    public class Product : IEntity
    {
        public Product()
        {
        }
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }

        public List<ProductIngredient> Ingredients { get; set; }
    }

}
