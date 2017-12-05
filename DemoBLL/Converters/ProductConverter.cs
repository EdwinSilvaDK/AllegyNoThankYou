using System;
using DemoDAL.Entities;
using DemoBLL.BusinessObjects;
using System.Linq;
namespace DemoBLL.Converters
{
    public class ProductConverter : IConverter<Product, ProductBO>
    {
        private IngredientConverter Iconv;
        public ProductConverter()
        {
            Iconv = new IngredientConverter();
        }

        public Product Convert(ProductBO prod)
        {
            if (prod == null) { return null; }
            return new Product()
            {
                Id = prod.Id,
                Name = prod.Name,
                Type = prod.Type,
                Ingredients = prod.IngredientIds?.Select(iId => new ProductIngredient()
                {

                    IngredientId = iId,
                    ProductId = prod.Id,
                }).ToList(),
            };
        }

        public ProductBO Convert(Product prod)
        {
            if (prod == null) { return null; }
            return new ProductBO()
            {
                Id = prod.Id,
                IngredientIds = prod.Ingredients?.Select(i => i.IngredientId).ToList(),
                Name = prod.Name,
                Type = prod.Type,
                /* Ingredients = prod.Ingredients?.Select(I => new IngredientBO()
                 {
                     Id = I.ProductId,
                     Name = I.Ingredient?.Name

                 }).ToList(),
                 */
            };
        }
    }
}
