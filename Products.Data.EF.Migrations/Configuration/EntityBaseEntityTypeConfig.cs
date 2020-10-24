using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels;
using Products.Domain.DataModels.Address;
using Products.Domain.DataModels.Customer;
using Products.Domain.DataModels.Organization;
using Products.Domain.DataModels.Product;
using Products.Domain.DataModels.Sales;
using Products.Domain.DataModels.Users;
using System;

namespace Products.Data.EF.Migrations.Configuration
{
    public class EntityBaseEntityTypeConfig : IEntityTypeConfiguration<EntityBase>
    {
        public void Configure(EntityTypeBuilder<EntityBase> builder)
        {
            builder.Property(b => b.DateCreated).IsRequired();
            builder.Property(b => b.RowVersion).IsRequired();
            builder.Property(b => b.SystemAdminId).IsRequired();

            builder.Property(b => b.Entity).HasColumnType("varchar(150)").IsRequired();
            builder.Property(b => b.EntityName).HasColumnType("varchar(100)").IsRequired();
            builder.Property(b => b.EntityType).HasColumnType("varchar(50)").IsRequired();
            builder.Property(b => b.EntityDescription).HasColumnType("varchar(1000)").IsRequired();
            builder.Property(b => b.EntityStatus).HasColumnType("varchar(50)").IsRequired();

            builder.HasData(
                new { Id = 1, Entity = "Organization", EntityName = nameof(OrganizationBase), EntityType = "Table", EntityDescription = "Organization Details", EntityStatus = "Active", DateCreated = DateTime.Parse("2020-10-11 14:52:26.697"), OrganizationBaseId = 1, SystemAdminId = 1 },
                new { Id = 2, Entity = "Customer", EntityName = nameof(CustomerBase), EntityType = "Table", EntityDescription = "Customer Details", EntityStatus = "Active", DateCreated = DateTime.Parse("2020-10-11 14:52:26.697"), OrganizationBaseId = 1, SystemAdminId = 1 },
                new { Id = 3, Entity = "User", EntityName = nameof(UserBase), EntityType = "Table", EntityDescription = "User Details", EntityStatus = "Active", DateCreated = DateTime.Parse("2020-10-11 14:52:26.697"), OrganizationBaseId = 1, SystemAdminId = 1 },
                new { Id = 4, Entity = "Product", EntityName = nameof(ProductBase), EntityType = "Table", EntityDescription = "Product Details", EntityStatus = "Active", DateCreated = DateTime.Parse("2020-10-11 14:52:26.697"), OrganizationBaseId = 1, SystemAdminId = 1 },
                new { Id = 5, Entity = "Product Category", EntityName = nameof(ProductCategoryBase), EntityType = "Table", EntityDescription = "Product Category Details", EntityStatus = "Active", DateCreated = DateTime.Parse("2020-10-11 14:52:26.697"), OrganizationBaseId = 1, SystemAdminId = 1 },
                new { Id = 6, Entity = "Product SubCategory", EntityName = nameof(ProductSubCategoryBase), EntityType = "Table", EntityDescription = "Product SubCategory Details", EntityStatus = "Active", DateCreated = DateTime.Parse("2020-10-11 14:52:26.697"), OrganizationBaseId = 1, SystemAdminId = 1 },
                new { Id = 7, Entity = "SalesOrder", EntityName = nameof(SalesOrderBase), EntityType = "Table", EntityDescription = "Sales  Order Header Details", EntityStatus = "Active", DateCreated = DateTime.Parse("2020-10-11 14:52:26.697"), OrganizationBaseId = 1, SystemAdminId = 1 },
                new { Id = 8, Entity = "SalesOrderProduct", EntityName = nameof(SalesOrderProductBase), EntityType = "Table", EntityDescription = "Sales Order Product line  Details", EntityStatus = "Active", DateCreated = DateTime.Parse("2020-10-11 14:52:26.697"), OrganizationBaseId = 1, SystemAdminId = 1 },
                new { Id = 9, Entity = "Address", EntityName = nameof(AddressBase), EntityType = "Table", EntityDescription = "Address Details", EntityStatus = "Active", DateCreated = DateTime.Parse("2020-10-11 14:52:26.697"), OrganizationBaseId = 1, SystemAdminId = 1 },
                new { Id = 10, Entity = "AddressType", EntityName = nameof(AddressTypeBase), EntityType = "Table", EntityDescription = "Address Type Details", EntityStatus = "Active", DateCreated = DateTime.Parse("2020-10-11 14:52:26.697"), OrganizationBaseId = 1, SystemAdminId = 1 },
                new { Id = 11, Entity = "SalesOrderStatus", EntityName = nameof(SalesOrderStatusBase), EntityType = "Table", EntityDescription = "Sales Order Status Codes", EntityStatus = "Active", DateCreated = DateTime.Parse("2020-10-11 14:52:26.697"), OrganizationBaseId = 1, SystemAdminId = 1 },
                new { Id = 12, Entity = "SalesOrderProductStatus", EntityName = nameof(SalesOrderProductStatusBase), EntityType = "Table", EntityDescription = "Sales Order Product lines  Status", EntityStatus = "Active", DateCreated = DateTime.Parse("2020-10-11 14:52:26.697"), OrganizationBaseId = 1, SystemAdminId = 1 }
            );
        }
    }
}
