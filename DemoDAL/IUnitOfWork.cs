using System;
namespace DemoDAL
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository ProductRepository { get; }
        IIngredientRepository IngredientRepository { get; }


        int Complete();
    }
}
