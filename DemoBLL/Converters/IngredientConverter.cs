﻿using System;
using AllegyNoThankYouBLL.BusinessObjects;
using AllegyNoThankYouDAL.Entities;

namespace AllegyNoThankYouBLL.Converters
{
    public class IngredientConverter : IConverter<Ingredient, IngredientBO>
    {
        public IngredientConverter()
        {
        }

        public Ingredient Convert(IngredientBO ind)
        {
            if (ind == null) { return null; }
            return new Ingredient()
            {
                Id = ind.Id,
                Name = ind.Name,


            };
        }

        public IngredientBO Convert(Ingredient ind)
        {
            if (ind == null) { return null; }
            return new IngredientBO()
            {
                Id = ind.Id,
                Name = ind.Name,

            };
        }
    }
}
