using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Users;

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

            builder.HasIndex(c => new { c.OrganizationBaseId });
        }
    }
}
