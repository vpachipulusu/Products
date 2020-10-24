using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Product;

namespace Products.Data.EF.Migrations.Configuration.Product
{
    public class ProductCategoryBaseEntityTypeConfig : IEntityTypeConfiguration<ProductCategoryBase>
    {
        public void Configure(EntityTypeBuilder<ProductCategoryBase> builder)
        {
            builder.Property(b => b.DateCreated).IsRequired();
            builder.Property(b => b.RowVersion).IsRequired();

            builder.Property(b => b.CategoryCode).HasColumnType("nvarchar(20)").IsRequired();
            builder.Property(b => b.Category).HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
