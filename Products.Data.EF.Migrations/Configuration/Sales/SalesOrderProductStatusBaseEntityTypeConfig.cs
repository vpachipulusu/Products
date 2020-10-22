using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Sales;

namespace Products.Data.EF.Migrations.Configuration.Sales
{
    public class SalesOrderProductStatusBaseEntityTypeConfig : IEntityTypeConfiguration<SalesOrderProductStatusBase>
    {
        public void Configure(EntityTypeBuilder<SalesOrderProductStatusBase> builder)
        {
            builder.Property(b => b.DateCreated).IsRequired();
            builder.Property(b => b.RowVersion).IsRequired();
            builder.Property(b => b.SalesProductStatusSequence).IsRequired();

            builder.Property(b => b.SalesOrderProductStatus).HasColumnType("varchar(150)").IsRequired();

            builder.HasIndex(c => new { c.OrganizationBaseId });
        }
    }
}
