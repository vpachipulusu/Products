using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Sales;

namespace Products.Data.EF.Migrations.Configuration.Sales
{
    public class SalesOrderProductBaseEntityTypeConfig : IEntityTypeConfiguration<SalesOrderProductBase>
    {
        public void Configure(EntityTypeBuilder<SalesOrderProductBase> builder)
        {
            builder.Property(b => b.DateCreated).IsRequired();
            builder.Property(b => b.RowVersion).IsRequired();

            builder.HasIndex(c => new { c.OrganizationBaseId, c.SalesOrderProductStatusBaseId });
        }
    }
}
