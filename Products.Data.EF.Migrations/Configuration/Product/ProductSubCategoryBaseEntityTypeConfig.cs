using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Product;

namespace Products.Data.EF.Migrations.Configuration.Product
{
    public class ProductSubCategoryBaseEntityTypeConfig : IEntityTypeConfiguration<ProductSubCategoryBase>
    {
        public void Configure(EntityTypeBuilder<ProductSubCategoryBase> builder)
        {
            builder.Property(b => b.DateCreated).IsRequired();
            builder.Property(b => b.RowVersion).IsRequired();

            builder.Property(b => b.SubCategoryCode).HasColumnType("nvarchar(20)").IsRequired();
            builder.Property(b => b.SubCategory).HasColumnType("nvarchar(60)").IsRequired();

            builder.HasIndex(c => new { c.OrganizationBaseId, c.ProductCategoryBaseId });
        }
    }
}
