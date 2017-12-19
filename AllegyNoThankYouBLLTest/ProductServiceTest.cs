using AllegyNoThankYouBLL.BusinessObjects;
using AllegyNoThankYouBLL.Services;
using AllegyNoThankYouDAL;
using AllegyNoThankYouDAL.Entities;
using AllegyNoThankYouDAL.Facade;
using Xunit;


namespace AllegyNoThankYouBLLTest
{
    public class ProductServiceTest
    {
        ProductService prodServ = new ProductService(new DALFacade(new DbOptions()
        {
            Environment = "Development"
        }));
        ProductBO prodBONoId = new ProductBO() { Name = "Milk", Type = "Dairy" };
        Product prodWithId = new Product() { Id = 1, Name = "Milk", Type = "Dairy" };
        [Fact]
        public void CreateProductTest()
        {
            var prodCreated = prodServ.Create(prodBONoId);
            Assert.Equal(prodWithId.Id, prodCreated.Id);
        }

    }
}