using System;
using System.Collections.Generic;
using DemoBLL.BusinessObjects;
using DemoDAL.Entities;

namespace DemoBLL
{
    public interface IProductService : IService<ProductBO>
    {



        List<ProductBO> FilteretProduct(List<int> ids);
        List<ProductBO> Getfilteredlist();
    }
}
