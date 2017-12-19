using System;
using DemoDAL.Entities;

namespace DemoBLL.BusinessObjects
{
    public class ProductIngredientBO
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
