using AllegyNoThankYouBLL.BusinessObjects;
using AllegyNoThankYouBLL.Converters;
using AllegyNoThankYouDAL.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTestProject
{
    [TestClass]
    public class ProductConverterTest
    {
                    private ProductConverter pc;
            public ProductConverterTest()
            {
                pc = new ProductConverter();
            }

            [TestMethod]
            public void EnttoProductBO()
            {
                Product prod = new Product
                {
                    Id = 2,
                    Name = "Milk"
                };

                ProductBO PB = pc.Convert(prod);

                Assert.AreEqual(prod.Id, PB.Id);
                Assert.AreEqual(prod.Name, PB.Name);

                Assert.IsNotNull(PB);


            }

            [TestMethod]
            public void ProductBOtoEnt()
            {
                ProductBO prodBO = new ProductBO
                {
                    Id = 3,
                    Name = "Niqab",
                    Type = "Muslim Woman"
                };

                Product prod = pc.Convert(prodBO);

                Assert.AreEqual(prodBO.Id, prod.Id);
                Assert.AreEqual(prodBO.Name, prod.Name);
                Assert.AreEqual(prodBO.Type, prod.Type);
                Assert.IsNotNull(prod);

            }
        }
    


}
