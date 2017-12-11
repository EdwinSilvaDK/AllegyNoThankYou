using System;
using System.Collections.Generic;
using DemoBLL.BusinessObjects;
using DemoDAL.Entities;

namespace DemoBLL
{
    public interface IProductService : IService<ProductBO>
    {
        List<IngredientBO> GetAllIndgredients();

        List<IngredientBO> GetAllFilteredIngredient(List<int> ids);

    }
}
