using System;
using System.Collections.Generic;
using System.Text;

namespace OA_DataAccess
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public virtual ProductDetails ProductDetails { get; set; }
        //https://www.c-sharpcorner.com/article/implementing-onion-architecture-in-asp-net-core-3-om/
    }
}
