using System;
using System.Collections.Generic;
using System.Text;

namespace OA_Service
{
    public interface IProductDetailsService
    {
        OA_DataAccess.ProductDetails GetProductDetail(int id);
    }
}
