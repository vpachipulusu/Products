using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Product;
using System;

namespace Products.Data.EF.Migrations.Configuration.Product
{
    public class ProductCategoryBaseEntityTypeConfig : IEntityTypeConfiguration<ProductCategoryBase>
    {
        public void Configure(EntityTypeBuilder<ProductCategoryBase> builder)
        {
            throw new NotImplementedException();
        }
    }
}
