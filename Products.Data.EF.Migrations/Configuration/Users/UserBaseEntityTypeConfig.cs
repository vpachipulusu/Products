using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Users;
using System;

namespace Products.Data.EF.Migrations.Configuration.Users
{
    public class UserBaseEntityTypeConfig : IEntityTypeConfiguration<UserBase>
    {
        public void Configure(EntityTypeBuilder<UserBase> builder)
        {
            throw new NotImplementedException();
        }
    }
}
