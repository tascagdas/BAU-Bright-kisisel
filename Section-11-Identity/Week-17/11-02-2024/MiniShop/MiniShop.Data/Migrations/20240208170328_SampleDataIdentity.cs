using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class SampleDataIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2a02e1aa-94ce-418a-ab87-45b14dbc0cfa", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" },
                    { "95d6ab38-0ba7-46ea-aa4b-d10dac515aa5", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" },
                    { "e54e7d35-4e20-43f3-ac14-1a6e64102d6b", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "062b7757-e3b3-4925-a9fb-435ec283729a", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "dd8f254f-205a-4f75-a7a3-2e44493b92b5", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEPCWOspsa03BEB8DYRiZ2y70MzZEHIcyo2kAmAIiO6Llr1Jt4DhzB8E+q0qzdAHG9w==", "538996655", false, "fcb3c6e7-4192-4ceb-bb36-83ab64478b92", false, "aysenumay" },
                    { "3f1465c3-1bca-419e-80f7-41842a6bc308", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "0711491c-d113-4e60-b7f7-126d5e4bafb0", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEAQN6HZ8bkMBDv3CLTnupdsc6VuMHtaOAY8ER5fBgYYUA+onwSn1ftvN2fk4cwn1Pg==", "538996655", false, "f851aa2f-fa22-4d06-bfc3-5ad644cf921b", false, "kemaldurukan" },
                    { "b5a23069-fbc6-4751-a394-109c21107be9", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "cc36725b-04ef-4531-a9e8-98adb5149fa9", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAECR60QGIflrAOR5GQQ6kpUgleJU0y8ced0ZN8FqpYXrAALZ8sTx7pn6kRzfi9lcucA==", "5558779966", false, "9c0d7909-27dc-4e5a-b727-bad35331427b", false, "denizfoca" },
                    { "e62f016c-f101-4969-a597-81bcf8d69598", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "1c4b4dc6-1d05-4878-b5b4-9bc6ec90da1c", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEOqEiljd4wPpadk8wCnHbpFAPI+ZXepfWcS2dtUk4rclP23e+JdqqCjMNyiUPzYyRQ==", "538996655", false, "95549935-32ff-4695-81f0-53d5449b11a3", false, "selinmete" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 28, 559, DateTimeKind.Local).AddTicks(7840), new DateTime(2024, 2, 8, 20, 3, 28, 559, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 28, 559, DateTimeKind.Local).AddTicks(7860), new DateTime(2024, 2, 8, 20, 3, 28, 559, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 28, 559, DateTimeKind.Local).AddTicks(7860), new DateTime(2024, 2, 8, 20, 3, 28, 559, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 28, 559, DateTimeKind.Local).AddTicks(7860), new DateTime(2024, 2, 8, 20, 3, 28, 559, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 28, 559, DateTimeKind.Local).AddTicks(7870), new DateTime(2024, 2, 8, 20, 3, 28, 559, DateTimeKind.Local).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 28, 560, DateTimeKind.Local).AddTicks(2420), new DateTime(2024, 2, 8, 20, 3, 28, 560, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 28, 560, DateTimeKind.Local).AddTicks(2440), new DateTime(2024, 2, 8, 20, 3, 28, 560, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 28, 560, DateTimeKind.Local).AddTicks(2440), new DateTime(2024, 2, 8, 20, 3, 28, 560, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 28, 560, DateTimeKind.Local).AddTicks(2450), new DateTime(2024, 2, 8, 20, 3, 28, 560, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 28, 560, DateTimeKind.Local).AddTicks(2450), new DateTime(2024, 2, 8, 20, 3, 28, 560, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 28, 560, DateTimeKind.Local).AddTicks(2450), new DateTime(2024, 2, 8, 20, 3, 28, 560, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 28, 560, DateTimeKind.Local).AddTicks(2460), new DateTime(2024, 2, 8, 20, 3, 28, 560, DateTimeKind.Local).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 28, 560, DateTimeKind.Local).AddTicks(2460), new DateTime(2024, 2, 8, 20, 3, 28, 560, DateTimeKind.Local).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 28, 560, DateTimeKind.Local).AddTicks(2480), new DateTime(2024, 2, 8, 20, 3, 28, 560, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 28, 560, DateTimeKind.Local).AddTicks(2490), new DateTime(2024, 2, 8, 20, 3, 28, 560, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 28, 560, DateTimeKind.Local).AddTicks(2490), new DateTime(2024, 2, 8, 20, 3, 28, 560, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                columns: new[] { "Id", "CreatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 8, 20, 3, 28, 559, DateTimeKind.Local).AddTicks(4440), "b5a23069-fbc6-4751-a394-109c21107be9" },
                    { 2, new DateTime(2024, 2, 8, 20, 3, 28, 559, DateTimeKind.Local).AddTicks(4490), "e62f016c-f101-4969-a597-81bcf8d69598" },
                    { 3, new DateTime(2024, 2, 8, 20, 3, 28, 559, DateTimeKind.Local).AddTicks(4490), "3f1465c3-1bca-419e-80f7-41842a6bc308" },
                    { 4, new DateTime(2024, 2, 8, 20, 3, 28, 559, DateTimeKind.Local).AddTicks(4490), "062b7757-e3b3-4925-a9fb-435ec283729a" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2a02e1aa-94ce-418a-ab87-45b14dbc0cfa", "062b7757-e3b3-4925-a9fb-435ec283729a" },
                    { "e54e7d35-4e20-43f3-ac14-1a6e64102d6b", "3f1465c3-1bca-419e-80f7-41842a6bc308" },
                    { "95d6ab38-0ba7-46ea-aa4b-d10dac515aa5", "b5a23069-fbc6-4751-a394-109c21107be9" },
                    { "e54e7d35-4e20-43f3-ac14-1a6e64102d6b", "e62f016c-f101-4969-a597-81bcf8d69598" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2a02e1aa-94ce-418a-ab87-45b14dbc0cfa", "062b7757-e3b3-4925-a9fb-435ec283729a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e54e7d35-4e20-43f3-ac14-1a6e64102d6b", "3f1465c3-1bca-419e-80f7-41842a6bc308" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "95d6ab38-0ba7-46ea-aa4b-d10dac515aa5", "b5a23069-fbc6-4751-a394-109c21107be9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e54e7d35-4e20-43f3-ac14-1a6e64102d6b", "e62f016c-f101-4969-a597-81bcf8d69598" });

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a02e1aa-94ce-418a-ab87-45b14dbc0cfa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95d6ab38-0ba7-46ea-aa4b-d10dac515aa5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e54e7d35-4e20-43f3-ac14-1a6e64102d6b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "062b7757-e3b3-4925-a9fb-435ec283729a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f1465c3-1bca-419e-80f7-41842a6bc308");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5a23069-fbc6-4751-a394-109c21107be9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e62f016c-f101-4969-a597-81bcf8d69598");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8382), new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8397), new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8399), new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8400), new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8401), new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(2984), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(2995), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(2997), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(2999), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3000), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3002), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3003), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3004), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3006), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3007), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3009), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3009) });
        }
    }
}
