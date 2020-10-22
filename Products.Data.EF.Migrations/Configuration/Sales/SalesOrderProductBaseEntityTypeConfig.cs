using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Sales;
using System;

namespace Products.Data.EF.Migrations.Configuration.Sales
{
    public class SalesOrderProductBaseEntityTypeConfig : IEntityTypeConfiguration<SalesOrderProductBase>
    {
        public void Configure(EntityTypeBuilder<SalesOrderProductBase> builder)
        {
            throw new NotImplementedException();
        }
    }
}
