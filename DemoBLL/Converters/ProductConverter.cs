using System;
using DemoDAL.Entities;
using DemoBLL.BusinessObjects;
namespace DemoBLL.Converters
{
    public class ProductConverter : IConverter<Product, ProductBO>
    {
        public ProductConverter()
        {

        }

        public Product Convert(ProductBO prod)
        {
            if (prod == null) { return null; }
            return new Product()
            {
                Id = prod.Id,
                Name = prod.Name,
                Type = prod.Name,
            };
        }

        public ProductBO Convert(Product prod)
        {
            if (prod == null) { return null; }
            return new ProductBO()
            {
                Id = prod.Id,
                Name = prod.Name,
                Type = prod.Name,
            };
        }
    }
}
