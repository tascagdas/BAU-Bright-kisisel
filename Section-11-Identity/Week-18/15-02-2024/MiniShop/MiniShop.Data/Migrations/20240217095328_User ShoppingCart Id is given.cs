using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserShoppingCartIdisgiven : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "22f393ee-fc8c-4fb2-a8ff-43abd2268754", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" },
                    { "f6634436-7f8e-4603-957b-40481ae94ea9", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" },
                    { "f7140f4d-362b-4c11-bd2f-e96aedecd21d", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "01396e67-8a1f-4fd3-8991-f41f1cc6afff", 0, "Sevda Caddesi Çırçır Sokak No:4 D:2 Eyüp", "İstanbul", "2b28aeea-a3a2-4f81-98e4-79f4daefe44b", new DateTime(1995, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "tascagdas@gmail.com", true, "Çağdaş", "Erkek", "Taş", false, null, "TASCAGDAS@GMAIL.COM", "TASCAGDAS", "AQAAAAIAAYagAAAAEEpjU65u4Jl6QbqQ4qmVOGeM0TC9sDk7sfqLaUk+xIef1UEo+XhOk5vac3Fse336RQ==", "5397166827", false, "bcf39ded-62bf-4e60-98ee-cfcd439f508e", false, "tascagdas" },
                    { "095872ea-f5cf-496b-9bb8-97d2a5dda472", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "b48834d9-1d5d-45a3-908e-2fa02c2587c3", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEKq4fvtluV/TbGzspbHNIgd9dbhXs1BeFG3EXSpVfLQIg2qu5kw52nPz8vDefgnCMg==", "5558779966", false, "80a8dd2d-3f6d-4fd4-a2e1-481d20b75d96", false, "denizfoca" },
                    { "67a52561-10da-4650-bac5-11313fb762ac", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "4c258c62-2f77-4ed3-8cfd-19d0d06e482c", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAENvP/ShJ7SRt+qiBKSjV5QsgBm2xmWjTq9+8OMAO7TvDiIiYS5xnJTv7A91HFVFyvw==", "538996655", false, "2de441c6-3b4e-472f-821b-d7a49d256c4a", false, "aysenumay" },
                    { "e3378504-4f71-4f3a-9eae-b1477d3cbdfe", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "b088c7a3-f529-43e9-9737-ddbcd09f7d55", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEEENXuRdj2rY5SRkjnpH8EMK0pTNCv9+KJE+H45TVV0NwrTBXy/O2FYzj0ScWfAt8Q==", "538996655", false, "dd475e5f-bf11-4217-aa99-51200af731eb", false, "selinmete" },
                    { "f367eb60-e861-4237-ba91-decab7252f58", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "dcc374e8-33e8-4845-8d1e-58f4750e51eb", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEMZJKVM3T5hmE/hwwrstCdS1jKqxhjeo52cUZL7ls1QJPD5aQkAsBiBxQmwX4ipXKg==", "538996655", false, "3ca7cc18-f0c9-4232-a5e5-9da5b6d82785", false, "kemaldurukan" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(1140), new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(1160), new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(1160), new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(1160), new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(1160), new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(4930), new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(4940), new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(4940), new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(4950), new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(4950), new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(4950), new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(4960), new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(4960), new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(4970), new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(4980), new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(4980), new DateTime(2024, 2, 17, 12, 53, 27, 987, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 53, 27, 986, DateTimeKind.Local).AddTicks(8290), "095872ea-f5cf-496b-9bb8-97d2a5dda472" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 53, 27, 986, DateTimeKind.Local).AddTicks(8320), "e3378504-4f71-4f3a-9eae-b1477d3cbdfe" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 53, 27, 986, DateTimeKind.Local).AddTicks(8320), "f367eb60-e861-4237-ba91-decab7252f58" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 53, 27, 986, DateTimeKind.Local).AddTicks(8330), "67a52561-10da-4650-bac5-11313fb762ac" });

            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                columns: new[] { "Id", "CreatedDate", "UserId" },
                values: new object[] { 5, new DateTime(2024, 2, 17, 12, 53, 27, 986, DateTimeKind.Local).AddTicks(8330), "01396e67-8a1f-4fd3-8991-f41f1cc6afff" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "22f393ee-fc8c-4fb2-a8ff-43abd2268754", "01396e67-8a1f-4fd3-8991-f41f1cc6afff" },
                    { "22f393ee-fc8c-4fb2-a8ff-43abd2268754", "095872ea-f5cf-496b-9bb8-97d2a5dda472" },
                    { "f6634436-7f8e-4603-957b-40481ae94ea9", "67a52561-10da-4650-bac5-11313fb762ac" },
                    { "f7140f4d-362b-4c11-bd2f-e96aedecd21d", "e3378504-4f71-4f3a-9eae-b1477d3cbdfe" },
                    { "f7140f4d-362b-4c11-bd2f-e96aedecd21d", "f367eb60-e861-4237-ba91-decab7252f58" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "22f393ee-fc8c-4fb2-a8ff-43abd2268754", "01396e67-8a1f-4fd3-8991-f41f1cc6afff" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "22f393ee-fc8c-4fb2-a8ff-43abd2268754", "095872ea-f5cf-496b-9bb8-97d2a5dda472" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f6634436-7f8e-4603-957b-40481ae94ea9", "67a52561-10da-4650-bac5-11313fb762ac" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f7140f4d-362b-4c11-bd2f-e96aedecd21d", "e3378504-4f71-4f3a-9eae-b1477d3cbdfe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f7140f4d-362b-4c11-bd2f-e96aedecd21d", "f367eb60-e861-4237-ba91-decab7252f58" });

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22f393ee-fc8c-4fb2-a8ff-43abd2268754");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6634436-7f8e-4603-957b-40481ae94ea9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7140f4d-362b-4c11-bd2f-e96aedecd21d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01396e67-8a1f-4fd3-8991-f41f1cc6afff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "095872ea-f5cf-496b-9bb8-97d2a5dda472");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67a52561-10da-4650-bac5-11313fb762ac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3378504-4f71-4f3a-9eae-b1477d3cbdfe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f367eb60-e861-4237-ba91-decab7252f58");

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
    }
}
