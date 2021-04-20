using System;
using System.Collections.Generic;
using System.Text;

namespace OA_Service
{
    public interface IProductService
    {
        IEnumerable<OA_DataAccess.Product> GetProduct();
        OA_DataAccess.Product GetProduct(int id);
    }
}
