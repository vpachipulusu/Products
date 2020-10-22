using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels;
using System;

namespace Products.Data.EF.Migrations.Configuration
{
    public class EntityBaseEntityTypeConfig : IEntityTypeConfiguration<EntityBase>
    {
        public void Configure(EntityTypeBuilder<EntityBase> builder)
        {
            throw new NotImplementedException();
        }
    }
}
