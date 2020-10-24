using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Product;

namespace Products.Data.EF.Migrations.Configuration.Product
{
    public class ProductBaseEntityTypeConfig : IEntityTypeConfiguration<ProductBase>
    {
        public void Configure(EntityTypeBuilder<ProductBase> builder)
        {
            builder.Property(b => b.DateCreated).IsRequired();
            builder.Property(b => b.RowVersion).IsRequired();

            builder.Property(b => b.ProductCode).HasColumnType("nvarchar(20)").IsRequired();
            builder.Property(b => b.ProductName).HasColumnType("nvarchar(20)").IsRequired();
            builder.Property(b => b.ProductDescription).HasColumnType("nvarchar(20)").IsRequired();
            builder.Property(b => b.ProductNetPrice).HasColumnType("decimal(18, 4)").IsRequired();
        }
    }
}
