using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Users;
using System;

namespace Products.Data.EF.Migrations.Configuration.Users
{
    public class UserRoleBaseEntityTypeConfig : IEntityTypeConfiguration<UserRoleBase>
    {
        public void Configure(EntityTypeBuilder<UserRoleBase> builder)
        {
            throw new NotImplementedException();
        }
    }
}
