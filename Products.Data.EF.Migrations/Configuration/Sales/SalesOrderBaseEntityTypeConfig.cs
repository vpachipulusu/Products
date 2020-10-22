using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Sales;
using System;

namespace Products.Data.EF.Migrations.Configuration.Sales
{
    public class SalesOrderBaseEntityTypeConfig : IEntityTypeConfiguration<SalesOrderBase>
    {
        public void Configure(EntityTypeBuilder<SalesOrderBase> builder)
        {
            throw new NotImplementedException();
        }
    }
}
