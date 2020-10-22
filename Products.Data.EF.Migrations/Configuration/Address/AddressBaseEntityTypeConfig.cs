using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Address;

namespace Products.Data.EF.Migrations.Configuration.Address
{
    public class AddressBaseEntityTypeConfig : IEntityTypeConfiguration<AddressBase>
    {
        public void Configure(EntityTypeBuilder<AddressBase> builder)
        {
            builder.Property(b => b.DateCreated).IsRequired();
            builder.Property(b => b.RowVersion).IsRequired();
            builder.Property(b => b.AddressStatus).IsRequired();

            builder.Property(b => b.AddressL1).HasColumnType("varchar(120)");
            builder.Property(b => b.AddressL2).HasColumnType("varchar(120)");
            builder.Property(b => b.AddressL3).HasColumnType("varchar(120)");
            builder.Property(b => b.AddressL4).HasColumnType("varchar(120)");
            builder.Property(b => b.AddressL5).HasColumnType("varchar(120)");
            builder.Property(b => b.AddressL6).HasColumnType("varchar(80)");
            builder.Property(b => b.AddressL7).HasColumnType("varchar(80)");

            builder.HasIndex(c => new { c.AddressTypeBaseId, c.OrganizationBaseId, c.EntityBaseId });
        }
    }
}
