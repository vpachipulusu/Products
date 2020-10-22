using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Sales;
using System;

namespace Products.Data.EF.Migrations.Configuration.Sales
{
    public class SalesOrderStatusBaseEntityTypeConfig : IEntityTypeConfiguration<SalesOrderStatusBase>
    {
        public void Configure(EntityTypeBuilder<SalesOrderStatusBase> builder)
        {
            throw new NotImplementedException();
        }
    }
}
