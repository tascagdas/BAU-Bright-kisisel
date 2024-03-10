using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class MessageEntitiyEdited : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "14f532cc-1dc7-482c-9c1f-7cec7b7c9db6", "467e3b7e-a55b-4c3a-a869-706cc8c696d1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "eaaa8270-87bc-42ae-a211-8b633873a99c", "63e1f5d9-0f7e-41c6-b1a5-e923d7bbb8c6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c5cabd46-482c-4289-8174-578738b4330d", "945441f3-3152-4016-aec5-b018a56752c8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "14f532cc-1dc7-482c-9c1f-7cec7b7c9db6", "bce7b65a-a946-491d-bf31-e7cc4a402f94" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c5cabd46-482c-4289-8174-578738b4330d", "be660a2e-f2bc-44db-919e-e4716f81c670" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14f532cc-1dc7-482c-9c1f-7cec7b7c9db6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5cabd46-482c-4289-8174-578738b4330d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eaaa8270-87bc-42ae-a211-8b633873a99c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "467e3b7e-a55b-4c3a-a869-706cc8c696d1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63e1f5d9-0f7e-41c6-b1a5-e923d7bbb8c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "945441f3-3152-4016-aec5-b018a56752c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bce7b65a-a946-491d-bf31-e7cc4a402f94");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be660a2e-f2bc-44db-919e-e4716f81c670");

            migrationBuilder.AddColumn<int>(
                name: "RelatedId",
                table: "Messages",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15f4c688-15aa-4e99-a8f4-fb6fa9b24eb1", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" },
                    { "6b203393-abcf-47fa-9100-7ced0c1cabd0", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" },
                    { "92c0a3d7-0e29-4a4d-ba47-fb4106d163f1", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8a4bf93f-41ac-4f48-99cb-c12f08eaee4b", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "17139dd9-3303-40f9-8fd1-3ec4209df9c0", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEH5yXIlyf0E0+v841sY27KAMGC92wgALSAmVNgXWtlPPfixG+5z5maqfOGOEuPKoZw==", "538996655", false, "0267bb62-ac75-4829-b955-7122e116cacf", false, "kemaldurukan" },
                    { "95148837-5ca2-41d6-a132-df5d08165da8", 0, "Sevda Caddesi Çırçır Sokak No:4 D:2 Eyüp", "İstanbul", "e61d8db7-1463-4c9c-a3e1-bf7ba2814b03", new DateTime(1995, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "tascagdas@gmail.com", true, "Çağdaş", "Erkek", "Taş", false, null, "TASCAGDAS@GMAIL.COM", "TASCAGDAS", "AQAAAAIAAYagAAAAEOK2UJzcyQANhO0/O45LZaVJBEmZVDQzHIUwjn5nmlvV2EI8lKj6UZxKZeFbjL/8+Q==", "5397166827", false, "5f92a5bd-199c-4b41-b949-5558bdcaf4f7", false, "tascagdas" },
                    { "97bca521-00bc-400c-aafe-dbe2bcc57bd9", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "94f7d01f-ce22-4f1c-b6e1-61e1fae5f91b", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEH1yQTqOHstiRT0VMW2gK2b9RBfDHRK06p7xFHrBcTlCfQbukTrHYIvXlo96l1+eDQ==", "5558779966", false, "aa864c67-8389-48bf-8f24-d72a5fc253e4", false, "denizfoca" },
                    { "d2f2d868-a5b5-4e2c-a0ee-1d85feb33bf3", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "3628d3ee-c3b9-4134-ae1d-ad13f4c49131", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEG+hI1AwouVJWwV41xR1b5ZN2ZpaPZ+dCoh/yoKVF6B8jBPEhMp/iO9krr/pYImy4g==", "538996655", false, "ffb16bce-c1fa-4132-8abf-a4cf4099ecdb", false, "selinmete" },
                    { "d4b9bd98-93bf-4425-8384-eceb0dccfa79", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "0d65e1eb-2707-40fd-b9af-9e98983ff5ad", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAECYZshk1JLo7XYj368m0xnqqR1Oqj0hZQIvamAvyXcXocgvs7aty4Wbwedjxc2Jf9A==", "538996655", false, "0317a222-8213-4983-9296-f9117ded8303", false, "aysenumay" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 36, 862, DateTimeKind.Local).AddTicks(9740), new DateTime(2024, 3, 7, 20, 19, 36, 862, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 36, 862, DateTimeKind.Local).AddTicks(9750), new DateTime(2024, 3, 7, 20, 19, 36, 862, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 36, 862, DateTimeKind.Local).AddTicks(9750), new DateTime(2024, 3, 7, 20, 19, 36, 862, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 36, 862, DateTimeKind.Local).AddTicks(9750), new DateTime(2024, 3, 7, 20, 19, 36, 862, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 36, 862, DateTimeKind.Local).AddTicks(9760), new DateTime(2024, 3, 7, 20, 19, 36, 862, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 36, 863, DateTimeKind.Local).AddTicks(2640), new DateTime(2024, 3, 7, 20, 19, 36, 863, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 36, 863, DateTimeKind.Local).AddTicks(2650), new DateTime(2024, 3, 7, 20, 19, 36, 863, DateTimeKind.Local).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 36, 863, DateTimeKind.Local).AddTicks(2650), new DateTime(2024, 3, 7, 20, 19, 36, 863, DateTimeKind.Local).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 36, 863, DateTimeKind.Local).AddTicks(2650), new DateTime(2024, 3, 7, 20, 19, 36, 863, DateTimeKind.Local).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 36, 863, DateTimeKind.Local).AddTicks(2650), new DateTime(2024, 3, 7, 20, 19, 36, 863, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 36, 863, DateTimeKind.Local).AddTicks(2660), new DateTime(2024, 3, 7, 20, 19, 36, 863, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 36, 863, DateTimeKind.Local).AddTicks(2660), new DateTime(2024, 3, 7, 20, 19, 36, 863, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 36, 863, DateTimeKind.Local).AddTicks(2660), new DateTime(2024, 3, 7, 20, 19, 36, 863, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 36, 863, DateTimeKind.Local).AddTicks(2690), new DateTime(2024, 3, 7, 20, 19, 36, 863, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 36, 863, DateTimeKind.Local).AddTicks(2690), new DateTime(2024, 3, 7, 20, 19, 36, 863, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 36, 863, DateTimeKind.Local).AddTicks(2690), new DateTime(2024, 3, 7, 20, 19, 36, 863, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 36, 862, DateTimeKind.Local).AddTicks(6980), "97bca521-00bc-400c-aafe-dbe2bcc57bd9" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 36, 862, DateTimeKind.Local).AddTicks(7030), "d2f2d868-a5b5-4e2c-a0ee-1d85feb33bf3" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 36, 862, DateTimeKind.Local).AddTicks(7030), "8a4bf93f-41ac-4f48-99cb-c12f08eaee4b" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 36, 862, DateTimeKind.Local).AddTicks(7030), "d4b9bd98-93bf-4425-8384-eceb0dccfa79" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 36, 862, DateTimeKind.Local).AddTicks(7030), "95148837-5ca2-41d6-a132-df5d08165da8" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "15f4c688-15aa-4e99-a8f4-fb6fa9b24eb1", "8a4bf93f-41ac-4f48-99cb-c12f08eaee4b" },
                    { "92c0a3d7-0e29-4a4d-ba47-fb4106d163f1", "95148837-5ca2-41d6-a132-df5d08165da8" },
                    { "92c0a3d7-0e29-4a4d-ba47-fb4106d163f1", "97bca521-00bc-400c-aafe-dbe2bcc57bd9" },
                    { "15f4c688-15aa-4e99-a8f4-fb6fa9b24eb1", "d2f2d868-a5b5-4e2c-a0ee-1d85feb33bf3" },
                    { "6b203393-abcf-47fa-9100-7ced0c1cabd0", "d4b9bd98-93bf-4425-8384-eceb0dccfa79" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "15f4c688-15aa-4e99-a8f4-fb6fa9b24eb1", "8a4bf93f-41ac-4f48-99cb-c12f08eaee4b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "92c0a3d7-0e29-4a4d-ba47-fb4106d163f1", "95148837-5ca2-41d6-a132-df5d08165da8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "92c0a3d7-0e29-4a4d-ba47-fb4106d163f1", "97bca521-00bc-400c-aafe-dbe2bcc57bd9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "15f4c688-15aa-4e99-a8f4-fb6fa9b24eb1", "d2f2d868-a5b5-4e2c-a0ee-1d85feb33bf3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6b203393-abcf-47fa-9100-7ced0c1cabd0", "d4b9bd98-93bf-4425-8384-eceb0dccfa79" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15f4c688-15aa-4e99-a8f4-fb6fa9b24eb1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b203393-abcf-47fa-9100-7ced0c1cabd0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92c0a3d7-0e29-4a4d-ba47-fb4106d163f1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a4bf93f-41ac-4f48-99cb-c12f08eaee4b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95148837-5ca2-41d6-a132-df5d08165da8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97bca521-00bc-400c-aafe-dbe2bcc57bd9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2f2d868-a5b5-4e2c-a0ee-1d85feb33bf3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4b9bd98-93bf-4425-8384-eceb0dccfa79");

            migrationBuilder.DropColumn(
                name: "RelatedId",
                table: "Messages");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14f532cc-1dc7-482c-9c1f-7cec7b7c9db6", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" },
                    { "c5cabd46-482c-4289-8174-578738b4330d", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" },
                    { "eaaa8270-87bc-42ae-a211-8b633873a99c", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "467e3b7e-a55b-4c3a-a869-706cc8c696d1", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "beeeb03d-8271-4196-93b8-13eb8a73459c", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEOn+0xST+LM8KEmtHuo/3tPQuZhkTf0L/tH545i17OTAUCZPdfpi5m8oaZH9R8kmmQ==", "538996655", false, "1828c424-1666-467b-bc89-d454cf0d224d", false, "kemaldurukan" },
                    { "63e1f5d9-0f7e-41c6-b1a5-e923d7bbb8c6", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "711c54d1-426a-4681-bf4c-82ee45ee9057", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEMAMf1mY7U/KbV21uuLdGc8PVmeYAKuZHUTipIceo/0Gt0pF0SbgZxZu42bEH7YZIw==", "538996655", false, "6a1937bb-6fbd-41e8-b1db-24f2bf46924f", false, "aysenumay" },
                    { "945441f3-3152-4016-aec5-b018a56752c8", 0, "Sevda Caddesi Çırçır Sokak No:4 D:2 Eyüp", "İstanbul", "e1f8e46c-71ea-416f-b2e7-0d748149c2d0", new DateTime(1995, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "tascagdas@gmail.com", true, "Çağdaş", "Erkek", "Taş", false, null, "TASCAGDAS@GMAIL.COM", "TASCAGDAS", "AQAAAAIAAYagAAAAEKbAeZldilXGbx//cVx/TmVeKBVx/iVcYWzjgAXwbNH/lBTJALSphfiG4RGLZLbLDw==", "5397166827", false, "dcf970b4-5ea6-4441-bccd-58c55b540420", false, "tascagdas" },
                    { "bce7b65a-a946-491d-bf31-e7cc4a402f94", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "d0c21062-a039-4400-b79f-049dd90c0fac", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEChR/PloSq7FoeTpSqcsJGMWlMd8MJvqu2vsUN3Z3Tpj6iRi1GoEk2J6qF5YJVtqgQ==", "538996655", false, "7aa83f03-7957-4af6-81df-276af4c624b8", false, "selinmete" },
                    { "be660a2e-f2bc-44db-919e-e4716f81c670", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "3ca805a9-c837-49f4-a841-214715f5fd4c", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEBbGqvsxFd1RTEFMJVsoI9VuCj7z/tX22XebongadLx0UaEOogiHld1d15HzGDyfvg==", "5558779966", false, "3caf6e72-d8cd-4d62-b573-f4f4eff1137e", false, "denizfoca" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 37, 46, 467, DateTimeKind.Local).AddTicks(8920), new DateTime(2024, 3, 6, 19, 37, 46, 467, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 37, 46, 467, DateTimeKind.Local).AddTicks(8930), new DateTime(2024, 3, 6, 19, 37, 46, 467, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 37, 46, 467, DateTimeKind.Local).AddTicks(8930), new DateTime(2024, 3, 6, 19, 37, 46, 467, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 37, 46, 467, DateTimeKind.Local).AddTicks(8940), new DateTime(2024, 3, 6, 19, 37, 46, 467, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 37, 46, 467, DateTimeKind.Local).AddTicks(8940), new DateTime(2024, 3, 6, 19, 37, 46, 467, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 37, 46, 468, DateTimeKind.Local).AddTicks(2080), new DateTime(2024, 3, 6, 19, 37, 46, 468, DateTimeKind.Local).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 37, 46, 468, DateTimeKind.Local).AddTicks(2090), new DateTime(2024, 3, 6, 19, 37, 46, 468, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 37, 46, 468, DateTimeKind.Local).AddTicks(2090), new DateTime(2024, 3, 6, 19, 37, 46, 468, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 37, 46, 468, DateTimeKind.Local).AddTicks(2090), new DateTime(2024, 3, 6, 19, 37, 46, 468, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 37, 46, 468, DateTimeKind.Local).AddTicks(2090), new DateTime(2024, 3, 6, 19, 37, 46, 468, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 37, 46, 468, DateTimeKind.Local).AddTicks(2100), new DateTime(2024, 3, 6, 19, 37, 46, 468, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 37, 46, 468, DateTimeKind.Local).AddTicks(2100), new DateTime(2024, 3, 6, 19, 37, 46, 468, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 37, 46, 468, DateTimeKind.Local).AddTicks(2110), new DateTime(2024, 3, 6, 19, 37, 46, 468, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 37, 46, 468, DateTimeKind.Local).AddTicks(2130), new DateTime(2024, 3, 6, 19, 37, 46, 468, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 37, 46, 468, DateTimeKind.Local).AddTicks(2130), new DateTime(2024, 3, 6, 19, 37, 46, 468, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 37, 46, 468, DateTimeKind.Local).AddTicks(2140), new DateTime(2024, 3, 6, 19, 37, 46, 468, DateTimeKind.Local).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 37, 46, 467, DateTimeKind.Local).AddTicks(6040), "be660a2e-f2bc-44db-919e-e4716f81c670" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 37, 46, 467, DateTimeKind.Local).AddTicks(6100), "bce7b65a-a946-491d-bf31-e7cc4a402f94" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 37, 46, 467, DateTimeKind.Local).AddTicks(6100), "467e3b7e-a55b-4c3a-a869-706cc8c696d1" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 37, 46, 467, DateTimeKind.Local).AddTicks(6100), "63e1f5d9-0f7e-41c6-b1a5-e923d7bbb8c6" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 37, 46, 467, DateTimeKind.Local).AddTicks(6100), "945441f3-3152-4016-aec5-b018a56752c8" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "14f532cc-1dc7-482c-9c1f-7cec7b7c9db6", "467e3b7e-a55b-4c3a-a869-706cc8c696d1" },
                    { "eaaa8270-87bc-42ae-a211-8b633873a99c", "63e1f5d9-0f7e-41c6-b1a5-e923d7bbb8c6" },
                    { "c5cabd46-482c-4289-8174-578738b4330d", "945441f3-3152-4016-aec5-b018a56752c8" },
                    { "14f532cc-1dc7-482c-9c1f-7cec7b7c9db6", "bce7b65a-a946-491d-bf31-e7cc4a402f94" },
                    { "c5cabd46-482c-4289-8174-578738b4330d", "be660a2e-f2bc-44db-919e-e4716f81c670" }
                });
        }
    }
}
