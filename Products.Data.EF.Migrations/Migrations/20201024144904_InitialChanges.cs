using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Products.Data.EF.Migrations.Migrations
{
    public partial class InitialChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressTypeBase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateDeleted = table.Column<DateTime>(nullable: true),
                    AddressType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressTypeBase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntityBase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateDeleted = table.Column<DateTime>(nullable: true),
                    Entity = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    EntityName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    EntityType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    EntityDescription = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false),
                    EntityStatus = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    SystemAdminId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityBase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationBase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateDeleted = table.Column<DateTime>(nullable: true),
                    OrganizationName = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    Active = table.Column<int>(nullable: false),
                    SystemAdminId = table.Column<int>(nullable: false),
                    OAuthKey = table.Column<string>(maxLength: 8000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationBase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategoryBase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateDeleted = table.Column<DateTime>(nullable: true),
                    CategoryCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategoryBase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSubCategoryBase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateDeleted = table.Column<DateTime>(nullable: true),
                    SubCategoryCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SubCategory = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubCategoryBase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderProductStatusBase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateDeleted = table.Column<DateTime>(nullable: true),
                    SalesOrderProductStatus = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    SalesProductStatusSequence = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderProductStatusBase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoleBase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateDeleted = table.Column<DateTime>(nullable: true),
                    Role = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    SystemAdminId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoleBase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddressBase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateDeleted = table.Column<DateTime>(nullable: true),
                    AddressTypeBaseId = table.Column<int>(nullable: false),
                    EntityBaseId = table.Column<int>(nullable: true),
                    AddressL1 = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: true),
                    AddressL2 = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false),
                    AddressL3 = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: true),
                    AddressL4 = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: true),
                    AddressL5 = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: true),
                    AddressL6 = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    AddressL7 = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    AddressStatus = table.Column<int>(nullable: false),
                    OrganizationBaseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddressBase_AddressTypeBase_AddressTypeBaseId",
                        column: x => x.AddressTypeBaseId,
                        principalTable: "AddressTypeBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AddressBase_EntityBase_EntityBaseId",
                        column: x => x.EntityBaseId,
                        principalTable: "EntityBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AddressBase_OrganizationBase_OrganizationBaseId",
                        column: x => x.OrganizationBaseId,
                        principalTable: "OrganizationBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerBase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateDeleted = table.Column<DateTime>(nullable: true),
                    CustomerName = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    CustomerKeyContact = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    CustomerMobile = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    CustomerEmail = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    CustomerWeb = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    OrganizationBaseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerBase_OrganizationBase_OrganizationBaseId",
                        column: x => x.OrganizationBaseId,
                        principalTable: "OrganizationBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderStatusBase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateDeleted = table.Column<DateTime>(nullable: true),
                    SalesOrderStatus = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    SalesOrderStatusSequence = table.Column<int>(nullable: false),
                    OrganizationBaseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderStatusBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesOrderStatusBase_OrganizationBase_OrganizationBaseId",
                        column: x => x.OrganizationBaseId,
                        principalTable: "OrganizationBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductBase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateDeleted = table.Column<DateTime>(nullable: true),
                    ProductSubCategoryBaseId = table.Column<int>(nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ProductNetPrice = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    OrganizationBaseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductBase_OrganizationBase_OrganizationBaseId",
                        column: x => x.OrganizationBaseId,
                        principalTable: "OrganizationBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductBase_ProductSubCategoryBase_ProductSubCategoryBaseId",
                        column: x => x.ProductSubCategoryBaseId,
                        principalTable: "ProductSubCategoryBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategoryLink",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateDeleted = table.Column<DateTime>(nullable: true),
                    ProductCategoryBaseId = table.Column<int>(nullable: true),
                    ProductSubCategoryBaseId = table.Column<int>(nullable: true),
                    OrganizationBaseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategoryLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategoryLink_OrganizationBase_OrganizationBaseId",
                        column: x => x.OrganizationBaseId,
                        principalTable: "OrganizationBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategoryLink_ProductCategoryBase_ProductCategoryBaseId",
                        column: x => x.ProductCategoryBaseId,
                        principalTable: "ProductCategoryBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductCategoryLink_ProductSubCategoryBase_ProductSubCategoryBaseId",
                        column: x => x.ProductSubCategoryBaseId,
                        principalTable: "ProductSubCategoryBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderProductBase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateDeleted = table.Column<DateTime>(nullable: true),
                    ProductBaseId = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    NetPrice = table.Column<int>(nullable: true),
                    SalesOrderProductStatusBaseId = table.Column<int>(nullable: true),
                    OrganizationBaseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderProductBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesOrderProductBase_OrganizationBase_OrganizationBaseId",
                        column: x => x.OrganizationBaseId,
                        principalTable: "OrganizationBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrderProductBase_SalesOrderProductStatusBase_SalesOrderProductStatusBaseId",
                        column: x => x.SalesOrderProductStatusBaseId,
                        principalTable: "SalesOrderProductStatusBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserBase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateDeleted = table.Column<DateTime>(nullable: true),
                    UserRoleBaseId = table.Column<int>(nullable: false),
                    UserLogin = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UserName = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false),
                    UserType = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    UserStatus = table.Column<int>(nullable: false),
                    OrganizationBaseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserBase_OrganizationBase_OrganizationBaseId",
                        column: x => x.OrganizationBaseId,
                        principalTable: "OrganizationBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBase_UserRoleBase_UserRoleBaseId",
                        column: x => x.UserRoleBaseId,
                        principalTable: "UserRoleBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderBase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateDeleted = table.Column<DateTime>(nullable: true),
                    SalesOrderStatusBaseId = table.Column<int>(nullable: true),
                    CustomerBaseId = table.Column<int>(nullable: true),
                    SalesOrderDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    OrganizationBaseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesOrderBase_CustomerBase_CustomerBaseId",
                        column: x => x.CustomerBaseId,
                        principalTable: "CustomerBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesOrderBase_OrganizationBase_OrganizationBaseId",
                        column: x => x.OrganizationBaseId,
                        principalTable: "OrganizationBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrderBase_SalesOrderStatusBase_SalesOrderStatusBaseId",
                        column: x => x.SalesOrderStatusBaseId,
                        principalTable: "SalesOrderStatusBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AddressTypeBase",
                columns: new[] { "Id", "AddressType", "DateCreated", "DateDeleted", "DateUpdated" },
                values: new object[,]
                {
                    { 1, "Billing Address", new DateTime(2020, 10, 11, 17, 38, 5, 150, DateTimeKind.Unspecified), null, null },
                    { 2, "Deliver Address", new DateTime(2020, 10, 11, 17, 38, 15, 463, DateTimeKind.Unspecified), null, null },
                    { 3, "Office Address", new DateTime(2020, 10, 11, 17, 38, 25, 680, DateTimeKind.Unspecified), null, null },
                    { 4, "Shipping Address", new DateTime(2020, 10, 11, 17, 38, 37, 320, DateTimeKind.Unspecified), null, null }
                });

            migrationBuilder.InsertData(
                table: "EntityBase",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "Entity", "EntityDescription", "EntityName", "EntityStatus", "EntityType", "SystemAdminId" },
                values: new object[,]
                {
                    { 12, new DateTime(2020, 10, 11, 14, 52, 26, 697, DateTimeKind.Unspecified), null, null, "SalesOrderProductStatus", "Sales Order Product lines  Status", "SalesOrderProductStatusBase", "Active", "Table", 1 },
                    { 11, new DateTime(2020, 10, 11, 14, 52, 26, 697, DateTimeKind.Unspecified), null, null, "SalesOrderStatus", "Sales Order Status Codes", "SalesOrderStatusBase", "Active", "Table", 1 },
                    { 9, new DateTime(2020, 10, 11, 14, 52, 26, 697, DateTimeKind.Unspecified), null, null, "Address", "Address Details", "AddressBase", "Active", "Table", 1 },
                    { 8, new DateTime(2020, 10, 11, 14, 52, 26, 697, DateTimeKind.Unspecified), null, null, "SalesOrderProduct", "Sales Order Product line  Details", "SalesOrderProductBase", "Active", "Table", 1 },
                    { 7, new DateTime(2020, 10, 11, 14, 52, 26, 697, DateTimeKind.Unspecified), null, null, "SalesOrder", "Sales  Order Header Details", "SalesOrderBase", "Active", "Table", 1 },
                    { 10, new DateTime(2020, 10, 11, 14, 52, 26, 697, DateTimeKind.Unspecified), null, null, "AddressType", "Address Type Details", "AddressTypeBase", "Active", "Table", 1 },
                    { 5, new DateTime(2020, 10, 11, 14, 52, 26, 697, DateTimeKind.Unspecified), null, null, "Product Category", "Product Category Details", "ProductCategoryBase", "Active", "Table", 1 },
                    { 4, new DateTime(2020, 10, 11, 14, 52, 26, 697, DateTimeKind.Unspecified), null, null, "Product", "Product Details", "ProductBase", "Active", "Table", 1 },
                    { 3, new DateTime(2020, 10, 11, 14, 52, 26, 697, DateTimeKind.Unspecified), null, null, "User", "User Details", "UserBase", "Active", "Table", 1 },
                    { 2, new DateTime(2020, 10, 11, 14, 52, 26, 697, DateTimeKind.Unspecified), null, null, "Customer", "Customer Details", "CustomerBase", "Active", "Table", 1 },
                    { 1, new DateTime(2020, 10, 11, 14, 52, 26, 697, DateTimeKind.Unspecified), null, null, "Organization", "Organization Details", "OrganizationBase", "Active", "Table", 1 },
                    { 6, new DateTime(2020, 10, 11, 14, 52, 26, 697, DateTimeKind.Unspecified), null, null, "Product SubCategory", "Product SubCategory Details", "ProductSubCategoryBase", "Active", "Table", 1 }
                });

            migrationBuilder.InsertData(
                table: "OrganizationBase",
                columns: new[] { "Id", "Active", "DateCreated", "DateDeleted", "DateUpdated", "OAuthKey", "OrganizationName", "SystemAdminId" },
                values: new object[] { 1, 1, new DateTime(2020, 10, 11, 17, 39, 54, 463, DateTimeKind.Unspecified), null, null, "0xDC331C344414C71865960FB46413F1C1803565A2E8021AEC52A73B0688903FBB", "biznex", 1 });

            migrationBuilder.InsertData(
                table: "SalesOrderProductStatusBase",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "SalesOrderProductStatus", "SalesProductStatusSequence" },
                values: new object[,]
                {
                    { 8, new DateTime(2020, 10, 11, 18, 6, 48, 500, DateTimeKind.Unspecified), null, null, "Vendor Shipped", 8 },
                    { 7, new DateTime(2020, 10, 11, 18, 6, 48, 500, DateTimeKind.Unspecified), null, null, "Returned", 7 },
                    { 6, new DateTime(2020, 10, 11, 18, 6, 48, 500, DateTimeKind.Unspecified), null, null, "Cancelled", 6 },
                    { 5, new DateTime(2020, 10, 11, 18, 6, 48, 500, DateTimeKind.Unspecified), null, null, "Paid", 5 },
                    { 2, new DateTime(2020, 10, 11, 18, 6, 48, 500, DateTimeKind.Unspecified), null, null, "Dispatched", 2 },
                    { 3, new DateTime(2020, 10, 11, 18, 6, 48, 500, DateTimeKind.Unspecified), null, null, "Delivered", 3 },
                    { 1, new DateTime(2020, 10, 11, 18, 6, 43, 0, DateTimeKind.Unspecified), null, null, "Booked", 1 },
                    { 4, new DateTime(2020, 10, 11, 18, 6, 48, 500, DateTimeKind.Unspecified), null, null, "Invoiced", 4 }
                });

            migrationBuilder.InsertData(
                table: "UserRoleBase",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "Role", "SystemAdminId" },
                values: new object[,]
                {
                    { 2, new DateTime(2020, 10, 11, 17, 38, 15, 463, DateTimeKind.Unspecified), null, null, "Normal", 1 },
                    { 1, new DateTime(2020, 10, 11, 17, 38, 5, 150, DateTimeKind.Unspecified), null, null, "Administrator", 1 },
                    { 3, new DateTime(2020, 10, 11, 17, 38, 25, 680, DateTimeKind.Unspecified), null, null, "ProductOwner", 1 }
                });

            migrationBuilder.InsertData(
                table: "SalesOrderStatusBase",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "OrganizationBaseId", "SalesOrderStatus", "SalesOrderStatusSequence" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 10, 11, 18, 6, 43, 0, DateTimeKind.Unspecified), null, null, 1, "Booked", 1 },
                    { 2, new DateTime(2020, 10, 11, 18, 6, 48, 500, DateTimeKind.Unspecified), null, null, 1, "Dispatched", 2 },
                    { 3, new DateTime(2020, 10, 11, 18, 6, 48, 500, DateTimeKind.Unspecified), null, null, 1, "Delivered", 3 },
                    { 4, new DateTime(2020, 10, 11, 18, 6, 48, 500, DateTimeKind.Unspecified), null, null, 1, "Invoiced", 4 },
                    { 5, new DateTime(2020, 10, 11, 18, 6, 48, 500, DateTimeKind.Unspecified), null, null, 1, "Paid", 5 },
                    { 6, new DateTime(2020, 10, 11, 18, 6, 48, 500, DateTimeKind.Unspecified), null, null, 1, "Cancelled", 6 },
                    { 7, new DateTime(2020, 10, 11, 18, 6, 48, 500, DateTimeKind.Unspecified), null, null, 1, "Returned", 7 },
                    { 8, new DateTime(2020, 10, 11, 18, 6, 48, 500, DateTimeKind.Unspecified), null, null, 1, "Partly Dispatched", 8 },
                    { 9, new DateTime(2020, 10, 11, 18, 6, 48, 500, DateTimeKind.Unspecified), null, null, 1, "Partly Delivered", 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressBase_AddressTypeBaseId",
                table: "AddressBase",
                column: "AddressTypeBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressBase_EntityBaseId",
                table: "AddressBase",
                column: "EntityBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressBase_OrganizationBaseId",
                table: "AddressBase",
                column: "OrganizationBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBase_OrganizationBaseId",
                table: "CustomerBase",
                column: "OrganizationBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductBase_OrganizationBaseId",
                table: "ProductBase",
                column: "OrganizationBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductBase_ProductSubCategoryBaseId",
                table: "ProductBase",
                column: "ProductSubCategoryBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategoryLink_OrganizationBaseId",
                table: "ProductCategoryLink",
                column: "OrganizationBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategoryLink_ProductCategoryBaseId",
                table: "ProductCategoryLink",
                column: "ProductCategoryBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategoryLink_ProductSubCategoryBaseId",
                table: "ProductCategoryLink",
                column: "ProductSubCategoryBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderBase_CustomerBaseId",
                table: "SalesOrderBase",
                column: "CustomerBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderBase_OrganizationBaseId",
                table: "SalesOrderBase",
                column: "OrganizationBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderBase_SalesOrderStatusBaseId",
                table: "SalesOrderBase",
                column: "SalesOrderStatusBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderProductBase_OrganizationBaseId",
                table: "SalesOrderProductBase",
                column: "OrganizationBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderProductBase_SalesOrderProductStatusBaseId",
                table: "SalesOrderProductBase",
                column: "SalesOrderProductStatusBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderStatusBase_OrganizationBaseId",
                table: "SalesOrderStatusBase",
                column: "OrganizationBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBase_OrganizationBaseId",
                table: "UserBase",
                column: "OrganizationBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBase_UserRoleBaseId",
                table: "UserBase",
                column: "UserRoleBaseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressBase");

            migrationBuilder.DropTable(
                name: "ProductBase");

            migrationBuilder.DropTable(
                name: "ProductCategoryLink");

            migrationBuilder.DropTable(
                name: "SalesOrderBase");

            migrationBuilder.DropTable(
                name: "SalesOrderProductBase");

            migrationBuilder.DropTable(
                name: "UserBase");

            migrationBuilder.DropTable(
                name: "AddressTypeBase");

            migrationBuilder.DropTable(
                name: "EntityBase");

            migrationBuilder.DropTable(
                name: "ProductCategoryBase");

            migrationBuilder.DropTable(
                name: "ProductSubCategoryBase");

            migrationBuilder.DropTable(
                name: "CustomerBase");

            migrationBuilder.DropTable(
                name: "SalesOrderStatusBase");

            migrationBuilder.DropTable(
                name: "SalesOrderProductStatusBase");

            migrationBuilder.DropTable(
                name: "UserRoleBase");

            migrationBuilder.DropTable(
                name: "OrganizationBase");
        }
    }
}
