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
            builder.HasData(
          new { Id = (int)OrderStatusType.Booked, SalesOrderStatus = OrderStatusType.Booked.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:43.000"), SalesOrderStatusSequence = 1, OrganizationBaseId = 1 },
          new { Id = (int)OrderStatusType.Dispatched, SalesOrderStatus = OrderStatusType.Dispatched.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:48.500"), SalesOrderStatusSequence = 2, OrganizationBaseId = 1 },
          new { Id = (int)OrderStatusType.Delivered, SalesOrderStatus = OrderStatusType.Delivered.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:48.500"), SalesOrderStatusSequence = 3, OrganizationBaseId = 1 },
          new { Id = (int)OrderStatusType.Invoiced, SalesOrderStatus = OrderStatusType.Invoiced.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:48.500"), SalesOrderStatusSequence = 4, OrganizationBaseId = 1 },
          new { Id = (int)OrderStatusType.Paid, SalesOrderStatus = OrderStatusType.Paid.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:48.500"), SalesOrderStatusSequence = 5, OrganizationBaseId = 1 },
          new { Id = (int)OrderStatusType.Cancelled, SalesOrderStatus = OrderStatusType.Cancelled.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:48.500"), SalesOrderStatusSequence = 6, OrganizationBaseId = 1 },
          new { Id = (int)OrderStatusType.Returned, SalesOrderStatus = OrderStatusType.Returned.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:48.500"), SalesOrderStatusSequence = 7, OrganizationBaseId = 1 },
          new { Id = (int)OrderStatusType.PartlyDispatched, SalesOrderStatus = OrderStatusType.PartlyDispatched.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:48.500"), SalesOrderStatusSequence = 8, OrganizationBaseId = 1 },
          new { Id = (int)OrderStatusType.PartlyDelivered, SalesOrderStatus = OrderStatusType.PartlyDelivered.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 18:06:48.500"), SalesOrderStatusSequence = 8, OrganizationBaseId = 1 }
            );
        }
    }
}
