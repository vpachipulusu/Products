using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Product;
using System;

namespace Products.Data.EF.Migrations.Configuration.Product
{
    public class ProductSubCategoryBaseEntityTypeConfig : IEntityTypeConfiguration<ProductSubCategoryBase>
    {
        public void Configure(EntityTypeBuilder<ProductSubCategoryBase> builder)
        {
            throw new NotImplementedException();
        }
    }
}
