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
<<<<<<< HEAD
       
=======

>>>>>>> b1d42960ae377047d05b7fc8249ed12ff03f7b16
    }

}
