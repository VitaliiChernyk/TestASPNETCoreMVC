using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.Data
{
    public class ProductProfileMap
    {
        public ProductProfileMap(EntityTypeBuilder<ProductProfile> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.ViderDescription).IsRequired();
            entityBuilder.Property(t => t.Country);
            entityBuilder.Property(t => t.ResponsibleLName).IsRequired();
        }
    }
}
