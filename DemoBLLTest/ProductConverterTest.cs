using System;
using DemoBLL.BusinessObjects;
using DemoBLL.Converters;
using DemoDAL.Entities;
using Xunit;

namespace DemoBLLTest
{
    public class ProductConverterTest
    {
        private ProductConverter pc;
        public ProductConverterTest()
        {
            pc = new ProductConverter();
        }
        
        [Fact]
        public void EnttoProductBO()
        {
            Product prod = new Product
            {
                Id = 2,
                Name = "Milk"
            };
            
            ProductBO PB = pc.Convert(prod);
    
            Assert.Equal(prod.Id, PB.Id);
            Assert.Equal(prod.Name, PB.Name);
            
            Assert.NotNull(PB);


        }

        [Fact]
        public void ProductBOtoEnt()
        {
            ProductBO prodBO = new ProductBO
            {
                Id = 3,
                Name = "Niqab",
                Type = "Muslim Woman"
            };
            
            Product prod = pc.Convert(prodBO);

            Assert.Equal(prodBO.Id, prod.Id);
            Assert.Equal(prodBO.Name, prod.Name);
            Assert.Equal(prodBO.Type, prod.Type);
            Assert.NotNull(prod);

        }
    }
}
