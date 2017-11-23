using System;
namespace DemoDAL
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository ProductRepository { get; }

        int Complete();
    }
}
