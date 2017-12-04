using System;
using System.Collections.Generic;
namespace DemoBLL.BusinessObjects
{
    public class ProductBO : IBusinessObject
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }

        public List<int> IngredientIds { get; set; }
        public List<IngredientBO> Ingredients { get; set; }
    }
}
