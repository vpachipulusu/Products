using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Organization;
using System;

namespace Products.Data.EF.Migrations.Configuration.Organization
{
    public class OrganizationBaseEntityTypeConfig : IEntityTypeConfiguration<OrganizationBase>
    {
        public void Configure(EntityTypeBuilder<OrganizationBase> builder)
        {
            builder.Property(b => b.DateCreated).IsRequired();
            builder.Property(b => b.RowVersion).IsRequired();
            builder.Property(b => b.SystemAdminId).IsRequired();
            builder.Property(b => b.OAuthKey).IsRequired();

            builder.Property(b => b.OrganizationName).HasColumnType("varchar(150)").IsRequired();

            builder.HasData(
                new { Id = 1, OrganizationName = "biznex", DateCreated = DateTime.Parse("2020-10-11 17:39:54.463"), Active = 1, SystemAdminId = 1, OAuthKey = "0xDC331C344414C71865960FB46413F1C1803565A2E8021AEC52A73B0688903FBB" });
        }
    }
}
