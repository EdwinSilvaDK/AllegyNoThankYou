using System;
namespace DemoBLL.BusinessObjects
{
    public class AllergyBO : IBusinessObject
    {
        public AllergyBO()
        {
        }

        public int Id { get; set; }
        public string AllergyName { get; set; }

    }
}
