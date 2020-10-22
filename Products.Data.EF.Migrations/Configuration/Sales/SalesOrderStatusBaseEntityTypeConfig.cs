using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Common.Helpers;
using Products.Domain.DataModels.Sales;
using Products.Domain.Enums;
using System;

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

            builder.HasData(
          new { Id = (int)OrderStatusType.Booked, SalesOrderProductStatus = OrderStatusType.Booked.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:43.000"), SalesProductStatusSequence = 1, OrganizationBaseId = 1 },
          new { Id = (int)OrderStatusType.Dispatched, SalesOrderProductStatus = OrderStatusType.Dispatched.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:48.500"), SalesProductStatusSequence = 2, OrganizationBaseId = 1 },
          new { Id = (int)OrderStatusType.Delivered, SalesOrderProductStatus = OrderStatusType.Delivered.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:48.500"), SalesProductStatusSequence = 3, OrganizationBaseId = 1 },
          new { Id = (int)OrderStatusType.Invoiced, SalesOrderProductStatus = OrderStatusType.Invoiced.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:48.500"), SalesProductStatusSequence = 4, OrganizationBaseId = 1 },
          new { Id = (int)OrderStatusType.Paid, SalesOrderProductStatus = OrderStatusType.Paid.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:48.500"), SalesProductStatusSequence = 5, OrganizationBaseId = 1 },
          new { Id = (int)OrderStatusType.Cancelled, SalesOrderProductStatus = OrderStatusType.Cancelled.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:48.500"), SalesProductStatusSequence = 6, OrganizationBaseId = 1 },
          new { Id = (int)OrderStatusType.Returned, SalesOrderProductStatus = OrderStatusType.Returned.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:48.500"), SalesProductStatusSequence = 7, OrganizationBaseId = 1 },
          new { Id = (int)OrderStatusType.PartlyDispatched, SalesOrderProductStatus = OrderStatusType.PartlyDispatched.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:48.500"), SalesProductStatusSequence = 8, OrganizationBaseId = 1 },
          new { Id = (int)OrderStatusType.PartlyDelivered, SalesOrderProductStatus = OrderStatusType.PartlyDelivered.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:48.500"), SalesProductStatusSequence = 8, OrganizationBaseId = 1 }
            );
        }
    }
}
