using System;
namespace AllegyNoThankYouDAL
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository ProductRepository { get; }
        IIngredientRepository IngredientRepository { get; }


        int Complete();
    }
}
