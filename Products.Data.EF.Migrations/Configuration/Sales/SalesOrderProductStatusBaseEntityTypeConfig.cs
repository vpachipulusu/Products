using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Sales;
using System;

namespace Products.Data.EF.Migrations.Configuration.Sales
{
    public class SalesOrderProductStatusBaseEntityTypeConfig : IEntityTypeConfiguration<SalesOrderProductStatusBase>
    {
        public void Configure(EntityTypeBuilder<SalesOrderProductStatusBase> builder)
        {
            throw new NotImplementedException();
        }
    }
}
