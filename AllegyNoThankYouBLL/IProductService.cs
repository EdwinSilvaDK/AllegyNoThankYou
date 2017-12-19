using System;
using System.Collections.Generic;
using AllegyNoThankYouBLL.BusinessObjects;
using AllegyNoThankYouDAL.Entities;

namespace AllegyNoThankYouBLL
{
    public interface IProductService : IService<ProductBO>
    {



        List<ProductBO> FilteretProduct(List<int> ids);
        List<ProductBO> Getfilteredlist();
    }
}
