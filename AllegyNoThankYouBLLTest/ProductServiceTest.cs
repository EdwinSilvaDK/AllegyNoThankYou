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
        ProductBO prodToUpdate = new ProductBO() { Id = 2, Name = "Mils", Type = "Daary" };
        ProductBO prodAfterUpdate = new ProductBO() { Id = 2, Name = "Milk", Type = "Dairy" };
        ProductBO verifyUpdate = new ProductBO() { Id = 2, Name = "Milk", Type = "Dairy" };
        ProductBO prodBONoId = new ProductBO() { Name = "Milk", Type = "Dairy" };
        Product prodWithId = new Product() { Id = 1, Name = "Milk", Type = "Dairy" };
        [Fact]
        public void CreateProductTest()
        {
            var prodCreated = prodServ.Create(prodBONoId);
            Assert.Equal(prodWithId.Id, prodCreated.Id);
        }

        [Fact]
        public void editProductTest()
        {

            prodToUpdate = prodServ.Update(prodAfterUpdate);
            Assert.Equal(prodToUpdate.Name, verifyUpdate.Name);
        }

        [Fact]
        public void getAllProducts()
        {

        }

        [Fact]
        public void deleteProductTest()
        {

        }

        [Fact]
        public void getProduct()
        {

        }

    }
}