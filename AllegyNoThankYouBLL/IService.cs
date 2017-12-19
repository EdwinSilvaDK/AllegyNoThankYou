using AllegyNoThankYouBLL.BusinessObjects;
using System.Collections.Generic;

namespace AllegyNoThankYouBLL
{
    public interface IService<IBusinessObject>
    {
        //C
        IBusinessObject Create(IBusinessObject bo);
        //R
        List<IBusinessObject> GetAll();
        IBusinessObject Get(int Id);
        //U
        IBusinessObject Update(IBusinessObject bo);
        //D
        IBusinessObject Delete(int Id);
    }

}
