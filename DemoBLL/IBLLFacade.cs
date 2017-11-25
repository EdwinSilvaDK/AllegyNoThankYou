using System;
using DemoDAL;
namespace DemoBLL
{
    public interface IBLLFacade
    {
        IProductService ProductService { get; }
        IIngredientRepository IngredientRepository { get; }
    }
}
