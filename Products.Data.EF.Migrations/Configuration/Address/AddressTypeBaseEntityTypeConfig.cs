using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Common.Helpers;
using Products.Domain.DataModels.Address;
using Products.Domain.Enums;
using System;

namespace Products.Data.EF.Migrations.Configuration.Address
{
    public class AddressTypeBaseEntityTypeConfig : IEntityTypeConfiguration<AddressTypeBase>
    {
        public void Configure(EntityTypeBuilder<AddressTypeBase> builder)
        {
            builder.Property(b => b.DateCreated).IsRequired();
            builder.Property(b => b.RowVersion).IsRequired();

            builder.Property(b => b.AddressType).HasColumnType("varchar(50)").IsRequired();

            builder.HasIndex(c => new { c.OrganizationBaseId });
            builder.HasData(
                new { Id = (int)AddressType.Billing, AddressType = AddressType.Billing.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 17:38:05.150"), OrganizationBaseId = 1 },
                new { Id = (int)AddressType.Delivery, AddressType = AddressType.Delivery.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 17:38:15.463"), OrganizationBaseId = 1 },
                new { Id = (int)AddressType.Office, AddressType = AddressType.Office.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 17:38:25.680"), OrganizationBaseId = 1 },
                new { Id = (int)AddressType.Shipping, AddressType = AddressType.Shipping.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 17:38:37.320"), OrganizationBaseId = 1 }
            );
        }
    }
}
