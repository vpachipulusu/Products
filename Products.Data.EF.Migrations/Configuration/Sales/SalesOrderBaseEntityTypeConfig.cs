using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Sales;

namespace Products.Data.EF.Migrations.Configuration.Sales
{
    public class SalesOrderBaseEntityTypeConfig : IEntityTypeConfiguration<SalesOrderBase>
    {
        public void Configure(EntityTypeBuilder<SalesOrderBase> builder)
        {
            builder.Property(b => b.DateCreated).IsRequired();
            builder.Property(b => b.RowVersion).IsRequired();
            builder.Property(b => b.SalesOrderDate).IsRequired();

            builder.HasIndex(c => new { c.OrganizationBaseId, c.SalesOrderStatusBaseId, c.CustomerBaseId });
        }
    }
}
