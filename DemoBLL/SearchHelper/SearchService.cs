using System;
using System.Collections.Generic;
using System.Linq;
using DemoBLL.BusinessObjects;
using DemoBLL.Converters;
using DemoDAL;
using DemoDAL.Entities;
namespace DemoBLL.SearchHelper
{
    public class SearchService
    {
        IDALFacade facade;

        List<IngredientBO> Ingredients { get; set; }
        List<IngredientBO> ExcludeIngredients { get; set; }
        List<IngredientBO> IncludeIngredients { get; set; }

        private IngredientConverter Iconv = new IngredientConverter();

        public SearchService(IDALFacade facade)
        {
            this.facade = facade;
        }




    }
}
