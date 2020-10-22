using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Common.Helpers;
using Products.Domain.DataModels.Sales;
using Products.Domain.Enums;
using System;

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
            builder.HasData(
                new { Id = (int)OrderProductStatusType.Booked, SalesOrderProductStatus = OrderProductStatusType.Booked.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:43.000"), SalesProductStatusSequence = 1, OrganizationBaseId = 1 },
                new { Id = (int)OrderProductStatusType.Dispatched, SalesOrderProductStatus = OrderProductStatusType.Dispatched.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:48.500"), SalesProductStatusSequence = 2, OrganizationBaseId = 1 },
                new { Id = (int)OrderProductStatusType.Delivered, SalesOrderProductStatus = OrderProductStatusType.Delivered.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:48.500"), SalesProductStatusSequence = 3, OrganizationBaseId = 1 },
                new { Id = (int)OrderProductStatusType.Invoiced, SalesOrderProductStatus = OrderProductStatusType.Invoiced.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:48.500"), SalesProductStatusSequence = 4, OrganizationBaseId = 1 },
                new { Id = (int)OrderProductStatusType.Paid, SalesOrderProductStatus = OrderProductStatusType.Paid.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:48.500"), SalesProductStatusSequence = 5, OrganizationBaseId = 1 },
                new { Id = (int)OrderProductStatusType.Cancelled, SalesOrderProductStatus = OrderProductStatusType.Cancelled.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:48.500"), SalesProductStatusSequence = 6, OrganizationBaseId = 1 },
                new { Id = (int)OrderProductStatusType.Returned, SalesOrderProductStatus = OrderProductStatusType.Returned.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:48.500"), SalesProductStatusSequence = 7, OrganizationBaseId = 1 },
                new { Id = (int)OrderProductStatusType.VendorShipped, SalesOrderProductStatus = OrderProductStatusType.VendorShipped.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:48.500"), SalesProductStatusSequence = 8, OrganizationBaseId = 1 }
                );
        }
    }
}
