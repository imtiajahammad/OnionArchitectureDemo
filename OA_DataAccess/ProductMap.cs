using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA_DataAccess
{
    public class ProductMap
    {
        public ProductMap(EntityTypeBuilder<Product> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(p => p.ProductId);
            entityTypeBuilder.HasOne(p => p.ProductDetails)
                .WithOne(p => p.Product)
                .HasForeignKey<ProductDetails>(x => x.ProductId);
        }
    }
}
