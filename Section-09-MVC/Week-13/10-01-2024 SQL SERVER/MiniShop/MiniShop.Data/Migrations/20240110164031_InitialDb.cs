using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Properties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsHome = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProducts",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProducts", x => new { x.CategoryId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_CategoryProducts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDelete", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 10, 19, 40, 31, 673, DateTimeKind.Local).AddTicks(9960), "Farklı çeşitlerde TV'ler", true, false, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local), "Televizyon", "televizyon" },
                    { 2, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local), "Laptop ve masaüstü bilgisayarlar", true, false, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(10), "Bilgisayar", "bilgisayar" },
                    { 3, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(10), "Elektronik eşyalar küçük ev eşyaları vb.", true, false, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(10), "Elektronik Eşya", "elektronik-esya" },
                    { 4, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(10), "Beyaz eşya kategorisi", true, false, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(10), "Beyaz Eşya", "beyaz-esya" },
                    { 5, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(10), "Cep Telefonu", true, false, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(10), "Telefon", "telefon" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "IsActive", "IsDelete", "IsHome", "ModifiedDate", "Name", "Price", "Properties", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(360), "1.png", true, false, true, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(360), "Iphone 14", 59000m, "Harika bir telefon", "iphone-14" },
                    { 2, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(370), "2.png", true, false, false, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(370), "Iphone 14 Pro", 69000m, "Buda harika bir telefon", "iphone-14-pro" },
                    { 3, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(370), "3.png", true, false, true, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(370), "Samsung S23", 49000m, "İdare eder bir telefon", "samsung-s23" },
                    { 4, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(370), "4.png", true, false, true, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(370), "Xiaomi Note 4", 39000m, "Harika bir telefon", "xiaomi-note-4" },
                    { 5, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(380), "5.png", true, false, true, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(380), "Macbook Air M2", 52000m, "M2'nin gücü", "macbook-air-m2" },
                    { 6, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(380), "6.png", true, false, false, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(380), "Macbook Pro M3", 79000m, "16gb RAM", "macbook-pro-m3" },
                    { 7, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(380), "7.png", true, false, true, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(380), "Vestel Çamaşır Makinesi X65", 19000m, "Akıllı makine", "vestel-camasir-makinesi-x65" },
                    { 8, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(380), "8.png", true, false, false, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(390), "Arçelik Çamaşır Makinesi A-4", 21000m, "Süper hızlı makine.", "arcelik-camasir-makinesi-a-4" },
                    { 9, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(390), "9.png", true, false, true, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(390), "Hoop Dijital Radyo x96", 1250m, "Klasik radyo keyfi", "hoop-dijital-radyo-x96" },
                    { 10, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(390), "10.png", true, false, true, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(390), "Xiaomi Dijital Baskül", 2100m, "Kilonuzu kontrol edin.", "xiaomi-dijital-baskul" },
                    { 11, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(390), "11.png", true, false, true, new DateTime(2024, 1, 10, 19, 40, 31, 674, DateTimeKind.Local).AddTicks(390), "Blaupunkt AC69 Led TV", 9800m, "Android Tv", "blaupunkt-ac69-led-tv" }
                });

            migrationBuilder.InsertData(
                table: "CategoryProducts",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 11 },
                    { 2, 5 },
                    { 2, 6 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 },
                    { 4, 7 },
                    { 4, 8 },
                    { 4, 10 },
                    { 4, 11 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProducts_ProductId",
                table: "CategoryProducts",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProducts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
