using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingIdentityAndOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Note = table.Column<string>(type: "TEXT", nullable: true),
                    PaymentType = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderState = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    ShoppingCartId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 37, 516, DateTimeKind.Local).AddTicks(7393), new DateTime(2024, 2, 7, 21, 43, 37, 516, DateTimeKind.Local).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 37, 516, DateTimeKind.Local).AddTicks(7411), new DateTime(2024, 2, 7, 21, 43, 37, 516, DateTimeKind.Local).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 37, 516, DateTimeKind.Local).AddTicks(7413), new DateTime(2024, 2, 7, 21, 43, 37, 516, DateTimeKind.Local).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 37, 516, DateTimeKind.Local).AddTicks(7414), new DateTime(2024, 2, 7, 21, 43, 37, 516, DateTimeKind.Local).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 37, 516, DateTimeKind.Local).AddTicks(7415), new DateTime(2024, 2, 7, 21, 43, 37, 516, DateTimeKind.Local).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 37, 517, DateTimeKind.Local).AddTicks(3284), new DateTime(2024, 2, 7, 21, 43, 37, 517, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 37, 517, DateTimeKind.Local).AddTicks(3293), new DateTime(2024, 2, 7, 21, 43, 37, 517, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 37, 517, DateTimeKind.Local).AddTicks(3295), new DateTime(2024, 2, 7, 21, 43, 37, 517, DateTimeKind.Local).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 37, 517, DateTimeKind.Local).AddTicks(3297), new DateTime(2024, 2, 7, 21, 43, 37, 517, DateTimeKind.Local).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 37, 517, DateTimeKind.Local).AddTicks(3299), new DateTime(2024, 2, 7, 21, 43, 37, 517, DateTimeKind.Local).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 37, 517, DateTimeKind.Local).AddTicks(3301), new DateTime(2024, 2, 7, 21, 43, 37, 517, DateTimeKind.Local).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 37, 517, DateTimeKind.Local).AddTicks(3302), new DateTime(2024, 2, 7, 21, 43, 37, 517, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 37, 517, DateTimeKind.Local).AddTicks(3304), new DateTime(2024, 2, 7, 21, 43, 37, 517, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 37, 517, DateTimeKind.Local).AddTicks(3305), new DateTime(2024, 2, 7, 21, 43, 37, 517, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 37, 517, DateTimeKind.Local).AddTicks(3307), new DateTime(2024, 2, 7, 21, 43, 37, 517, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 37, 517, DateTimeKind.Local).AddTicks(3308), new DateTime(2024, 2, 7, 21, 43, 37, 517, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ShoppingCartId",
                table: "ShoppingCartItems",
                column: "ShoppingCartId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 23, 912, DateTimeKind.Local).AddTicks(5481), new DateTime(2024, 2, 6, 20, 55, 23, 912, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 23, 912, DateTimeKind.Local).AddTicks(5514), new DateTime(2024, 2, 6, 20, 55, 23, 912, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 23, 912, DateTimeKind.Local).AddTicks(5516), new DateTime(2024, 2, 6, 20, 55, 23, 912, DateTimeKind.Local).AddTicks(5516) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 23, 912, DateTimeKind.Local).AddTicks(5517), new DateTime(2024, 2, 6, 20, 55, 23, 912, DateTimeKind.Local).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 23, 912, DateTimeKind.Local).AddTicks(5518), new DateTime(2024, 2, 6, 20, 55, 23, 912, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 23, 913, DateTimeKind.Local).AddTicks(8655), new DateTime(2024, 2, 6, 20, 55, 23, 913, DateTimeKind.Local).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 23, 913, DateTimeKind.Local).AddTicks(8671), new DateTime(2024, 2, 6, 20, 55, 23, 913, DateTimeKind.Local).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 23, 913, DateTimeKind.Local).AddTicks(8672), new DateTime(2024, 2, 6, 20, 55, 23, 913, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 23, 913, DateTimeKind.Local).AddTicks(8674), new DateTime(2024, 2, 6, 20, 55, 23, 913, DateTimeKind.Local).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 23, 913, DateTimeKind.Local).AddTicks(8676), new DateTime(2024, 2, 6, 20, 55, 23, 913, DateTimeKind.Local).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 23, 913, DateTimeKind.Local).AddTicks(8677), new DateTime(2024, 2, 6, 20, 55, 23, 913, DateTimeKind.Local).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 23, 913, DateTimeKind.Local).AddTicks(8679), new DateTime(2024, 2, 6, 20, 55, 23, 913, DateTimeKind.Local).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 23, 913, DateTimeKind.Local).AddTicks(8681), new DateTime(2024, 2, 6, 20, 55, 23, 913, DateTimeKind.Local).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 23, 913, DateTimeKind.Local).AddTicks(8682), new DateTime(2024, 2, 6, 20, 55, 23, 913, DateTimeKind.Local).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 23, 913, DateTimeKind.Local).AddTicks(8684), new DateTime(2024, 2, 6, 20, 55, 23, 913, DateTimeKind.Local).AddTicks(8684) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 23, 913, DateTimeKind.Local).AddTicks(8685), new DateTime(2024, 2, 6, 20, 55, 23, 913, DateTimeKind.Local).AddTicks(8686) });
        }
    }
}
