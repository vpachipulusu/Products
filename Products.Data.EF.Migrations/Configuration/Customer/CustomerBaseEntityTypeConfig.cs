using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.DataModels.Customer;

namespace Products.Data.EF.Migrations.Configuration.Customer
{
    public class CustomerBaseEntityTypeConfig : IEntityTypeConfiguration<CustomerBase>
    {
        public void Configure(EntityTypeBuilder<CustomerBase> builder)
        {
            builder.Property(b => b.DateCreated).IsRequired();
            builder.Property(b => b.RowVersion).IsRequired();

            builder.Property(b => b.CustomerName).HasColumnType("varchar(250)").IsRequired();
            builder.Property(b => b.CustomerKeyContact).HasColumnType("varchar(250)").IsRequired();
            builder.Property(b => b.CustomerMobile).HasColumnType("varchar(15)").IsRequired();
            builder.Property(b => b.CustomerEmail).HasColumnType("varchar(150)").IsRequired();
            builder.Property(b => b.CustomerWeb).HasColumnType("varchar(250)").IsRequired();
        }
    }
}
