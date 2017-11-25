using System;
namespace DemoBLL.BusinessObjects
{
    public class IngredientBO : IBusinessObject
    {
        public IngredientBO()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int AllergyId { get; set; }
    }
}
