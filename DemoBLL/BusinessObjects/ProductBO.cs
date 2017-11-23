using System;
namespace DemoBLL.BusinessObjects
{
    public class ProductBO : IBusinessObject
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
    }
}
