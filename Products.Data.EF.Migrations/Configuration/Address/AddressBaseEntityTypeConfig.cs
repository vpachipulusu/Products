using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Address;
using System;

namespace Products.Data.EF.Migrations.Configuration.Address
{
    public class AddressBaseEntityTypeConfig : IEntityTypeConfiguration<AddressBase>
    {
        public void Configure(EntityTypeBuilder<AddressBase> builder)
        {
            throw new NotImplementedException();
        }
    }
}
