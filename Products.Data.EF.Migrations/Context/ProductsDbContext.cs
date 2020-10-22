using Microsoft.EntityFrameworkCore;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
