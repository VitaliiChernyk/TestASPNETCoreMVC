using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TestPage.Models
{
    public class ProductMap
    {
        public ProductMap(EntityTypeBuilder<Product> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Name).IsRequired();
            entityBuilder.Property(t=>t.Photo)
            entityBuilder.Property(t => t.Price).IsRequired();
            entityBuilder.Property(t => t.Quantity).IsRequired();
            entityBuilder.HasOne(t => t.ProductProfile).WithOne(p => p.Product).HasForeignKey<ProductProfile>(x => x.Id);
        }
    }
}
