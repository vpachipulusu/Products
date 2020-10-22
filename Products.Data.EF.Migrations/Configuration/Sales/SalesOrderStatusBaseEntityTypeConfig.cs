using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Sales;

namespace Products.Data.EF.Migrations.Configuration.Sales
{
    public class SalesOrderStatusBaseEntityTypeConfig : IEntityTypeConfiguration<SalesOrderStatusBase>
    {
        public void Configure(EntityTypeBuilder<SalesOrderStatusBase> builder)
        {
            builder.Property(b => b.DateCreated).IsRequired();
            builder.Property(b => b.RowVersion).IsRequired();
            builder.Property(b => b.SalesOrderStatusSequence).IsRequired();

            builder.Property(b => b.SalesOrderStatus).HasColumnType("varchar(150)").IsRequired();

            builder.HasIndex(c => new { c.OrganizationBaseId });
        }
    }
}
