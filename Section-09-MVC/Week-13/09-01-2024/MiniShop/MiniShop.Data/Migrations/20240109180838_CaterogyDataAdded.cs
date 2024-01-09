using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class CaterogyDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Categories",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDelete", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 9, 21, 8, 38, 114, DateTimeKind.Local).AddTicks(1780), "Farklı çeşitlerde TV'ler", true, false, new DateTime(2024, 1, 9, 21, 8, 38, 114, DateTimeKind.Local).AddTicks(1810), "Televizyon", "televizyon" },
                    { 2, new DateTime(2024, 1, 9, 21, 8, 38, 114, DateTimeKind.Local).AddTicks(1820), "Laptop ve masaüstü bilgisayarlar", true, false, new DateTime(2024, 1, 9, 21, 8, 38, 114, DateTimeKind.Local).AddTicks(1820), "Bilgisayar", "bilgisayar" },
                    { 3, new DateTime(2024, 1, 9, 21, 8, 38, 114, DateTimeKind.Local).AddTicks(1820), "Elektronik eşyalar küçük ev eşyaları vb.", true, false, new DateTime(2024, 1, 9, 21, 8, 38, 114, DateTimeKind.Local).AddTicks(1820), "Elektronik Eşya", "elektronik-esya" },
                    { 4, new DateTime(2024, 1, 9, 21, 8, 38, 114, DateTimeKind.Local).AddTicks(1820), "Beyaz eşya kategorisi", true, false, new DateTime(2024, 1, 9, 21, 8, 38, 114, DateTimeKind.Local).AddTicks(1830), "Beyaz Eşya", "beyaz-esya" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);
        }
    }
}
