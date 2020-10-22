using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Product;
using System;

namespace Products.Data.EF.Migrations.Configuration.Product
{
    public class ProductBaseEntityTypeConfig : IEntityTypeConfiguration<ProductBase>
    {
        public void Configure(EntityTypeBuilder<ProductBase> builder)
        {
            throw new NotImplementedException();
        }
    }
}
