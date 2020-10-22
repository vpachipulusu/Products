using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Organization;

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
        }
    }
}
