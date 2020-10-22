using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Users;

namespace Products.Data.EF.Migrations.Configuration.Users
{
    public class UserBaseEntityTypeConfig : IEntityTypeConfiguration<UserBase>
    {
        public void Configure(EntityTypeBuilder<UserBase> builder)
        {
            builder.Property(b => b.DateCreated).IsRequired();
            builder.Property(b => b.RowVersion).IsRequired();
            builder.Property(b => b.UserStatus).IsRequired();

            builder.Property(b => b.UserLogin).HasColumnType("varchar(60)").IsRequired();
            builder.Property(b => b.UserPassword).HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(b => b.UserName).HasColumnType("varchar(120)").IsRequired();
            builder.Property(b => b.UserType).HasColumnType("varchar(20)").IsRequired();

            builder.HasIndex(c => new { c.OrganizationBaseId, c.UserRoleBaseId });
        }
    }
}
