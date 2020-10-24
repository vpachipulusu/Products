using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Product;

namespace Products.Data.EF.Migrations.Configuration.Product
{
    public class ProductCategoryLinkEntityTypeConfig : IEntityTypeConfiguration<ProductCategoryLink>
    {
        public void Configure(EntityTypeBuilder<ProductCategoryLink> builder)
        {
            builder.Property(b => b.DateCreated).IsRequired();
            builder.Property(b => b.RowVersion).IsRequired();

        }
    }
}
