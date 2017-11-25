using System;
using DemoDAL;
using DemoBLL.Services;
namespace DemoBLL
{
    public interface IBLLFacade
    {
        IProductService ProductService { get; }
        IIngredientService IngredientService { get; }
    }
}
