using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Address;

namespace Products.Data.EF.Migrations.Configuration.Address
{
    public class AddressTypeBaseEntityTypeConfig : IEntityTypeConfiguration<AddressTypeBase>
    {
        public void Configure(EntityTypeBuilder<AddressTypeBase> builder)
        {
            builder.Property(b => b.DateCreated).IsRequired();
            builder.Property(b => b.RowVersion).IsRequired();

            builder.Property(b => b.AddressType).HasColumnType("varchar(50)").IsRequired();

            builder.HasIndex(c => new { c.OrganizationBaseId });
        }
    }
}
