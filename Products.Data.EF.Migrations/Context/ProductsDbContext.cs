using Microsoft.EntityFrameworkCore;
using Products.Data.EF.Migrations.Configuration;
using Products.Data.EF.Migrations.Configuration.Address;
using Products.Data.EF.Migrations.Configuration.Customer;
using Products.Data.EF.Migrations.Configuration.Organization;
using Products.Data.EF.Migrations.Configuration.Product;
using Products.Data.EF.Migrations.Configuration.Sales;
using Products.Data.EF.Migrations.Configuration.Users;
using Products.Domain.DataModels;
using Products.Domain.DataModels.Address;
using Products.Domain.DataModels.Customer;
using Products.Domain.DataModels.Organization;
using Products.Domain.DataModels.Product;
using Products.Domain.DataModels.Sales;
using Products.Domain.DataModels.Users;

namespace Products.Data.EF.Migrations.Context
{
    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options) { }

        public DbSet<AddressBase> AddressBase { get; set; }
        public DbSet<AddressTypeBase> AddressTypeBase { get; set; }
        public DbSet<CustomerBase> CustomerBase { get; set; }
        public DbSet<OrganizationBase> OrganizationBase { get; set; }
        public DbSet<ProductBase> ProductBase { get; set; }
        public DbSet<ProductCategoryBase> ProductCategoryBase { get; set; }
        public DbSet<ProductSubCategoryBase> ProductSubCategoryBase { get; set; }
        public DbSet<SalesOrderBase> SalesOrderBase { get; set; }
        public DbSet<SalesOrderProductBase> SalesOrderProductBase { get; set; }
        public DbSet<SalesOrderProductStatusBase> SalesOrderProductStatusBase { get; set; }
        public DbSet<SalesOrderStatusBase> SalesOrderStatusBase { get; set; }
        public DbSet<UserBase> UserBase { get; set; }
        public DbSet<UserRoleBase> UserRoleBase { get; set; }
        public DbSet<EntityBase> EntityBase { get; set; }
        public DbSet<ProductCategoryLink> ProductCategoryLink { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressBaseEntityTypeConfig());
            modelBuilder.ApplyConfiguration(new AddressTypeBaseEntityTypeConfig());

            modelBuilder.ApplyConfiguration(new CustomerBaseEntityTypeConfig());

            modelBuilder.ApplyConfiguration(new OrganizationBaseEntityTypeConfig());

            modelBuilder.ApplyConfiguration(new ProductBaseEntityTypeConfig());
            modelBuilder.ApplyConfiguration(new ProductCategoryBaseEntityTypeConfig());
            modelBuilder.ApplyConfiguration(new ProductCategoryLinkEntityTypeConfig());
            modelBuilder.ApplyConfiguration(new ProductSubCategoryBaseEntityTypeConfig());

            modelBuilder.ApplyConfiguration(new SalesOrderBaseEntityTypeConfig());
            modelBuilder.ApplyConfiguration(new SalesOrderProductBaseEntityTypeConfig());
            modelBuilder.ApplyConfiguration(new SalesOrderProductStatusBaseEntityTypeConfig());
            modelBuilder.ApplyConfiguration(new SalesOrderStatusBaseEntityTypeConfig());

            modelBuilder.ApplyConfiguration(new UserBaseEntityTypeConfig());
            modelBuilder.ApplyConfiguration(new UserRoleBaseEntityTypeConfig());

            modelBuilder.ApplyConfiguration(new EntityBaseEntityTypeConfig());
        }
    }
}
