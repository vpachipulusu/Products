using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Products.Data.EF.Migrations.Configuration.Customer
{
    public class CustomerBaseEntityTypeConfig : IEntityTypeConfiguration<CustomerBaseEntityTypeConfig>
    {
        public void Configure(EntityTypeBuilder<CustomerBaseEntityTypeConfig> builder)
        {
            throw new NotImplementedException();
        }
    }
}
