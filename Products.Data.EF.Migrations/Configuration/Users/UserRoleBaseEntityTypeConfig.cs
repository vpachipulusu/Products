using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Common.Helpers;
using Products.Domain.DataModels.Users;
using Products.Domain.Enums;
using System;

namespace Products.Data.EF.Migrations.Configuration.Users
{
    public class UserRoleBaseEntityTypeConfig : IEntityTypeConfiguration<UserRoleBase>
    {
        public void Configure(EntityTypeBuilder<UserRoleBase> builder)
        {
            builder.Property(b => b.DateCreated).IsRequired();
            builder.Property(b => b.RowVersion).IsRequired();
            builder.Property(b => b.SystemAdminId).IsRequired();

            builder.Property(b => b.Role).HasColumnType("varchar(150)").IsRequired();

            builder.HasData(
                new { Id = (int)UserRoleType.Administrator, Role = UserRoleType.Administrator.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 17:38:05.150"), OrganizationBaseId = 1, SystemAdminId = 1 },
                new { Id = (int)UserRoleType.Normal, Role = UserRoleType.Normal.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 17:38:15.463"), OrganizationBaseId = 1, SystemAdminId = 1 },
                new { Id = (int)UserRoleType.ProductOwner, Role = UserRoleType.ProductOwner.GetDescription(), DateCreated = DateTime.Parse("2020-10-11 17:38:25.680"), OrganizationBaseId = 1, SystemAdminId = 1 }
            );
        }
    }
}
