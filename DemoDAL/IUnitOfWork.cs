using System;
namespace DemoDAL
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository ProductRepository { get; }
        IIngredientRepository IngredientRepository { get; }
        IAllergyRepository AllergyRepository { get; }

        int Complete();
    }
}
