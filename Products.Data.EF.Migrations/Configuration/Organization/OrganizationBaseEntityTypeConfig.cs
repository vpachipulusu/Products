using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Organization;
using System;

namespace Products.Data.EF.Migrations.Configuration.Organization
{
    public class OrganizationBaseEntityTypeConfig : IEntityTypeConfiguration<OrganizationBase>
    {
        public void Configure(EntityTypeBuilder<OrganizationBase> builder)
        {
            throw new NotImplementedException();
        }
    }
}
