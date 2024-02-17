using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class tascagdasuserpassworderrorfixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "941796f2-4244-4f40-b6e8-408dfbea6239", "0721a11b-a581-454d-b324-94c827604634" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "941796f2-4244-4f40-b6e8-408dfbea6239", "304732e5-815d-4e46-931e-f2a54dda193f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5edeaabd-608d-4276-964c-4e58c4f6be53", "55a25305-36b7-48d0-aef3-9a5961cba2d7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7cca824a-4ef6-4db0-83ed-68d8a9b9af49", "7ac74a7b-435d-4414-b050-26db8798a087" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7cca824a-4ef6-4db0-83ed-68d8a9b9af49", "9bf66199-297a-48d6-b1a0-2a4482cd46f4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5edeaabd-608d-4276-964c-4e58c4f6be53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7cca824a-4ef6-4db0-83ed-68d8a9b9af49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "941796f2-4244-4f40-b6e8-408dfbea6239");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0721a11b-a581-454d-b324-94c827604634");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "304732e5-815d-4e46-931e-f2a54dda193f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55a25305-36b7-48d0-aef3-9a5961cba2d7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ac74a7b-435d-4414-b050-26db8798a087");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9bf66199-297a-48d6-b1a0-2a4482cd46f4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "69809eca-dc03-43d9-b8fb-c9e113ac2b53", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" },
                    { "876ca2e4-7840-4b41-97f8-8a42181af7c0", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" },
                    { "97eff7d0-e6a5-499e-bb1b-3e6c5925c4c0", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "426d2b14-2a1c-4132-a961-9d556e756166", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "75212823-6ff0-444a-a6ff-60d3215f0a3c", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEMMAR2wWqBKrCuND8p2qvWqOCaZRtezl8GAC3dIaRx7BXyKUVIWrKtIgb1IZL6H34w==", "5558779966", false, "6313a5c5-09f2-4ad8-a4d1-f8705d944c41", false, "denizfoca" },
                    { "8a7c8647-082c-48b5-bced-b4d773eb0660", 0, "Sevda Caddesi Çırçır Sokak No:4 D:2 Eyüp", "İstanbul", "0b55d961-bc2e-4ab8-b83a-4a53c13c4cf0", new DateTime(1995, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "tascagdas@gmail.com", true, "Çağdaş", "Erkek", "Taş", false, null, "TASCAGDAS@GMAIL.COM", "TASCAGDAS", "AQAAAAIAAYagAAAAEE5uPbYZmXsFJQTi/yNixLxP58G6ptk4zGOxy9REujVmYHEabhzDIlI8qd50aAtfJQ==", "5397166827", false, "7255e027-1354-4896-8187-7b9df87125b3", false, "tascagdas" },
                    { "8f5b6c10-5112-431c-8951-0aff83b8884b", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "799a166d-41a3-4606-bda0-bd251c58a5b3", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAELJ+cFL1etBdDa7/oK3Q3NGSuhL2ElCZiNG9w0QBTX6A8rjY7anjgM1rpIQFSS+igw==", "538996655", false, "2652777d-23e3-4921-9241-5df0cbd69c58", false, "selinmete" },
                    { "c9c799cb-5fb6-475f-a166-1a9919366166", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "d56f8927-0e82-4a91-bac2-7cc4b11db81f", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEEyUpk8FuHAxyyWaGQwciqEpkmeRz7CbthZl62dpWRqKAwQLzpmbURfw/7sDZui9bA==", "538996655", false, "e78097b2-28be-4cf1-b275-39f3618e9cd3", false, "aysenumay" },
                    { "eb713289-5854-41ef-bf31-5fdb6abff55e", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "92cfa22b-24a8-4c81-8492-4df14d10819e", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEK2hVQbxgGJwUK9OCRhlaENg6REVagqNJ2nCENtZQxwt4B8b4x/lTAmoPCz+MLujDw==", "538996655", false, "7ccd4aaf-965b-4760-8073-d0fc2757f1d8", false, "kemaldurukan" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 51, 32, 200, DateTimeKind.Local).AddTicks(7450), new DateTime(2024, 2, 17, 12, 51, 32, 200, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 51, 32, 200, DateTimeKind.Local).AddTicks(7470), new DateTime(2024, 2, 17, 12, 51, 32, 200, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 51, 32, 200, DateTimeKind.Local).AddTicks(7470), new DateTime(2024, 2, 17, 12, 51, 32, 200, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 51, 32, 200, DateTimeKind.Local).AddTicks(7480), new DateTime(2024, 2, 17, 12, 51, 32, 200, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 51, 32, 200, DateTimeKind.Local).AddTicks(7480), new DateTime(2024, 2, 17, 12, 51, 32, 200, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 51, 32, 201, DateTimeKind.Local).AddTicks(970), new DateTime(2024, 2, 17, 12, 51, 32, 201, DateTimeKind.Local).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 51, 32, 201, DateTimeKind.Local).AddTicks(990), new DateTime(2024, 2, 17, 12, 51, 32, 201, DateTimeKind.Local).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 51, 32, 201, DateTimeKind.Local).AddTicks(1000), new DateTime(2024, 2, 17, 12, 51, 32, 201, DateTimeKind.Local).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 51, 32, 201, DateTimeKind.Local).AddTicks(1000), new DateTime(2024, 2, 17, 12, 51, 32, 201, DateTimeKind.Local).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 51, 32, 201, DateTimeKind.Local).AddTicks(1000), new DateTime(2024, 2, 17, 12, 51, 32, 201, DateTimeKind.Local).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 51, 32, 201, DateTimeKind.Local).AddTicks(1010), new DateTime(2024, 2, 17, 12, 51, 32, 201, DateTimeKind.Local).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 51, 32, 201, DateTimeKind.Local).AddTicks(1010), new DateTime(2024, 2, 17, 12, 51, 32, 201, DateTimeKind.Local).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 51, 32, 201, DateTimeKind.Local).AddTicks(1010), new DateTime(2024, 2, 17, 12, 51, 32, 201, DateTimeKind.Local).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 51, 32, 201, DateTimeKind.Local).AddTicks(1030), new DateTime(2024, 2, 17, 12, 51, 32, 201, DateTimeKind.Local).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 51, 32, 201, DateTimeKind.Local).AddTicks(1040), new DateTime(2024, 2, 17, 12, 51, 32, 201, DateTimeKind.Local).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 51, 32, 201, DateTimeKind.Local).AddTicks(1040), new DateTime(2024, 2, 17, 12, 51, 32, 201, DateTimeKind.Local).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 51, 32, 200, DateTimeKind.Local).AddTicks(3450), "426d2b14-2a1c-4132-a961-9d556e756166" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 51, 32, 200, DateTimeKind.Local).AddTicks(3530), "8f5b6c10-5112-431c-8951-0aff83b8884b" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 51, 32, 200, DateTimeKind.Local).AddTicks(3530), "eb713289-5854-41ef-bf31-5fdb6abff55e" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 51, 32, 200, DateTimeKind.Local).AddTicks(3540), "c9c799cb-5fb6-475f-a166-1a9919366166" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "876ca2e4-7840-4b41-97f8-8a42181af7c0", "426d2b14-2a1c-4132-a961-9d556e756166" },
                    { "876ca2e4-7840-4b41-97f8-8a42181af7c0", "8a7c8647-082c-48b5-bced-b4d773eb0660" },
                    { "69809eca-dc03-43d9-b8fb-c9e113ac2b53", "8f5b6c10-5112-431c-8951-0aff83b8884b" },
                    { "97eff7d0-e6a5-499e-bb1b-3e6c5925c4c0", "c9c799cb-5fb6-475f-a166-1a9919366166" },
                    { "69809eca-dc03-43d9-b8fb-c9e113ac2b53", "eb713289-5854-41ef-bf31-5fdb6abff55e" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "876ca2e4-7840-4b41-97f8-8a42181af7c0", "426d2b14-2a1c-4132-a961-9d556e756166" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "876ca2e4-7840-4b41-97f8-8a42181af7c0", "8a7c8647-082c-48b5-bced-b4d773eb0660" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "69809eca-dc03-43d9-b8fb-c9e113ac2b53", "8f5b6c10-5112-431c-8951-0aff83b8884b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "97eff7d0-e6a5-499e-bb1b-3e6c5925c4c0", "c9c799cb-5fb6-475f-a166-1a9919366166" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "69809eca-dc03-43d9-b8fb-c9e113ac2b53", "eb713289-5854-41ef-bf31-5fdb6abff55e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69809eca-dc03-43d9-b8fb-c9e113ac2b53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "876ca2e4-7840-4b41-97f8-8a42181af7c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97eff7d0-e6a5-499e-bb1b-3e6c5925c4c0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "426d2b14-2a1c-4132-a961-9d556e756166");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a7c8647-082c-48b5-bced-b4d773eb0660");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f5b6c10-5112-431c-8951-0aff83b8884b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9c799cb-5fb6-475f-a166-1a9919366166");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb713289-5854-41ef-bf31-5fdb6abff55e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5edeaabd-608d-4276-964c-4e58c4f6be53", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" },
                    { "7cca824a-4ef6-4db0-83ed-68d8a9b9af49", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" },
                    { "941796f2-4244-4f40-b6e8-408dfbea6239", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0721a11b-a581-454d-b324-94c827604634", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "9f09af19-a506-4d5f-a3b3-479794bf9706", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEMI2w4wFix9iH6krbuEFwMxiu8obSWid+5T86ICzknKBL6lJQsBx7cpyB0GEPV+ANQ==", "5558779966", false, "435de7aa-32a4-473d-96c3-234b90cd6fd0", false, "denizfoca" },
                    { "304732e5-815d-4e46-931e-f2a54dda193f", 0, "Sevda Caddesi Çırçır Sokak No:4 D:2 Eyüp", "İstanbul", "1fd5c6fd-a8b9-4de4-b0c9-f613a7e87fe9", new DateTime(1995, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "tascagdas@gmail.com", true, "Çağdaş", "Erkek", "Taş", false, null, "TASCAGDAS@GMAIL.COM", "TASCAGDAS", null, "5397166827", false, "78c47053-deb6-4fd3-ba1b-17bb90f7b20f", false, "tascagdas" },
                    { "55a25305-36b7-48d0-aef3-9a5961cba2d7", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "85cb9c73-0227-4c5f-af54-9483aa0d11bf", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEFUPFx7bDZSHE0UgBHSkCvDniM5bMv9N/Um0FQ4qeZmz1bVazsrhYlxw5QlhL1Jy4A==", "538996655", false, "34632608-acc0-4238-8dce-29c9ceac072d", false, "aysenumay" },
                    { "7ac74a7b-435d-4414-b050-26db8798a087", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "d5b99c52-d7ff-4418-ba8e-bcb458dbf72a", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEDss+3hlS1VB1FxBeaTB53SWCBZ+3i7/b6vS5WYcuWpPmHJs7+cxaKWgPP1loA/XUg==", "538996655", false, "2f35fa42-a60d-4e13-a66f-74ae98cfcb19", false, "selinmete" },
                    { "9bf66199-297a-48d6-b1a0-2a4482cd46f4", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "d0843cdb-54b5-40c3-b63c-cd046f5cee5c", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAECHa8SNEVy/A7d8om0GlAIUugcITV+ZjyYW/2cZtAi26Hh8j+SJakaI9rQtELnsntw==", "538996655", false, "2d8bd8e5-8cdc-4e56-8d91-ef8321ab8288", false, "kemaldurukan" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(4440), new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(4450), new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(4460), new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(4460), new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(4460), new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(7140), new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(7160), new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(7160), new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(7170), new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(7170), new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(7170), new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(7170), new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(7180), new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(7190), new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(7200), new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(7200), new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(1900), "0721a11b-a581-454d-b324-94c827604634" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(1970), "7ac74a7b-435d-4414-b050-26db8798a087" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(1970), "9bf66199-297a-48d6-b1a0-2a4482cd46f4" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 1, 54, 165, DateTimeKind.Local).AddTicks(1970), "55a25305-36b7-48d0-aef3-9a5961cba2d7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "941796f2-4244-4f40-b6e8-408dfbea6239", "0721a11b-a581-454d-b324-94c827604634" },
                    { "941796f2-4244-4f40-b6e8-408dfbea6239", "304732e5-815d-4e46-931e-f2a54dda193f" },
                    { "5edeaabd-608d-4276-964c-4e58c4f6be53", "55a25305-36b7-48d0-aef3-9a5961cba2d7" },
                    { "7cca824a-4ef6-4db0-83ed-68d8a9b9af49", "7ac74a7b-435d-4414-b050-26db8798a087" },
                    { "7cca824a-4ef6-4db0-83ed-68d8a9b9af49", "9bf66199-297a-48d6-b1a0-2a4482cd46f4" }
                });
        }
    }
}
