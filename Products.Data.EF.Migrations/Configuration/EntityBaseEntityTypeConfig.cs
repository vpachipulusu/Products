using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels;

namespace Products.Data.EF.Migrations.Configuration
{
    public class EntityBaseEntityTypeConfig : IEntityTypeConfiguration<EntityBase>
    {
        public void Configure(EntityTypeBuilder<EntityBase> builder)
        {
            builder.Property(b => b.DateCreated).IsRequired();
            builder.Property(b => b.RowVersion).IsRequired();
            builder.Property(b => b.SystemAdminId).IsRequired();

            builder.Property(b => b.Entity).HasColumnType("varchar(150)").IsRequired();
            builder.Property(b => b.EntityName).HasColumnType("varchar(100)").IsRequired();
            builder.Property(b => b.EntityType).HasColumnType("varchar(50)").IsRequired();
            builder.Property(b => b.EntityDescription).HasColumnType("varchar(1000)").IsRequired();
            builder.Property(b => b.EntityStatus).HasColumnType("varchar(50)").IsRequired();

            builder.HasIndex(c => new { c.OrganizationBaseId });
        }
    }
}
