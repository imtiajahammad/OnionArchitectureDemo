using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA_DataAccess
{
    public class ProductDetailMap
    {
        public ProductDetailMap(EntityTypeBuilder<ProductDetails> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(p => p.ProductId);
            entityTypeBuilder.Property(p => p.StockAvailable).IsRequired();
            entityTypeBuilder.Property(p => p.Price);
        }
    }
}
