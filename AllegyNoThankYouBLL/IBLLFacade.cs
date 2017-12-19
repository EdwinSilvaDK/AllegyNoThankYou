using System;
using AllegyNoThankYouDAL;
using AllegyNoThankYouBLL.Services;
namespace AllegyNoThankYouBLL
{
    public interface IBLLFacade
    {
        IProductService ProductService { get; }
        IIngredientService IngredientService { get; }
    }
}
