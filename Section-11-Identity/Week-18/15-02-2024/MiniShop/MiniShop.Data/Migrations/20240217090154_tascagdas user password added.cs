using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class tascagdasuserpasswordadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "967b939e-3128-49af-bc51-9d0add24f0da", "00631f10-17a5-4431-9d9a-9480c3b5d5b6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5638fe4d-db73-4c85-af6e-b6d032939989", "075b6a15-29e2-444c-92a5-d18015bea126" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d528a17f-24da-4708-8d91-cdabc333cc77", "22862445-f85e-4460-8d4a-e74c73c2f1fd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5638fe4d-db73-4c85-af6e-b6d032939989", "2b31a4a3-beab-41be-923e-9c9a158582a2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d528a17f-24da-4708-8d91-cdabc333cc77", "a5c0b889-bfc3-4ebb-a8a4-ae4d4113ee5a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5638fe4d-db73-4c85-af6e-b6d032939989");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "967b939e-3128-49af-bc51-9d0add24f0da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d528a17f-24da-4708-8d91-cdabc333cc77");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00631f10-17a5-4431-9d9a-9480c3b5d5b6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "075b6a15-29e2-444c-92a5-d18015bea126");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22862445-f85e-4460-8d4a-e74c73c2f1fd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b31a4a3-beab-41be-923e-9c9a158582a2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5c0b889-bfc3-4ebb-a8a4-ae4d4113ee5a");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "5638fe4d-db73-4c85-af6e-b6d032939989", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" },
                    { "967b939e-3128-49af-bc51-9d0add24f0da", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" },
                    { "d528a17f-24da-4708-8d91-cdabc333cc77", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00631f10-17a5-4431-9d9a-9480c3b5d5b6", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "0078ba1b-3b7b-440f-9740-fa228144763b", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEAc4p2AWGq9n3d3NC1TTkRCFp5ip0Cd9EU7MSQk29WOD8fVVWYst4mUeou6MaLcFzw==", "538996655", false, "c9d6ed54-77af-4310-9922-fc1bf20bc222", false, "aysenumay" },
                    { "075b6a15-29e2-444c-92a5-d18015bea126", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "f2ebe5f1-cb41-4d61-8bf4-baa7bf76a544", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEH7PdK1wwFOVR5tGsEYcv2IXaPxZYRT4HoBKGDU9RjWt3wVbyJjMPEsIxyQD9HN3UQ==", "538996655", false, "e8e1ae00-bdb5-41dd-bed1-6382eb4bd067", false, "selinmete" },
                    { "22862445-f85e-4460-8d4a-e74c73c2f1fd", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "42738a2b-3614-4a67-9525-1dfd04e5892d", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEPUuZsrCcFjWw7v53OycFw8kR0yReByezqV6WvT9E1nDzU6gtPOCUCzUm1flntSZTA==", "5558779966", false, "f6b67131-4ad4-4384-9991-8d36748814ea", false, "denizfoca" },
                    { "2b31a4a3-beab-41be-923e-9c9a158582a2", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "dcb56d8c-f6b7-4db5-a23c-1d7a317de272", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEL4p9ihzI51uyAsahQ/pvlrTqhHCSysgwzDF2lG1qzaWPGTOcQXoXeXz9WXZN5J4+A==", "538996655", false, "6d09bf6e-f6ea-49ef-a126-d65fef5e7d28", false, "kemaldurukan" },
                    { "a5c0b889-bfc3-4ebb-a8a4-ae4d4113ee5a", 0, "Sevda Caddesi Çırçır Sokak No:4 D:2 Eyüp", "İstanbul", "9e5f4ae1-a546-408f-b8db-af939336915c", new DateTime(1995, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "tascagdas@gmail.com", true, "Çağdaş", "Erkek", "Taş", false, null, "TASCAGDAS@GMAIL.COM", "TASCAGDAS", null, "5397166827", false, "210bbe3b-f0b1-40ff-b092-afb50044a5fb", false, "tascagdas" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(1500), new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(1500), new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(1510), new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(1510), new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(1510), new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(5050), new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(5060), new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(5060), new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(5070), new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(5070), new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(5070), new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(5070), new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(5080), new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(5080), new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(5090), new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(5090), new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 2, 17, 11, 58, 5, 928, DateTimeKind.Local).AddTicks(8050), "22862445-f85e-4460-8d4a-e74c73c2f1fd" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 2, 17, 11, 58, 5, 928, DateTimeKind.Local).AddTicks(8120), "075b6a15-29e2-444c-92a5-d18015bea126" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 2, 17, 11, 58, 5, 928, DateTimeKind.Local).AddTicks(8120), "2b31a4a3-beab-41be-923e-9c9a158582a2" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 2, 17, 11, 58, 5, 928, DateTimeKind.Local).AddTicks(8120), "00631f10-17a5-4431-9d9a-9480c3b5d5b6" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "967b939e-3128-49af-bc51-9d0add24f0da", "00631f10-17a5-4431-9d9a-9480c3b5d5b6" },
                    { "5638fe4d-db73-4c85-af6e-b6d032939989", "075b6a15-29e2-444c-92a5-d18015bea126" },
                    { "d528a17f-24da-4708-8d91-cdabc333cc77", "22862445-f85e-4460-8d4a-e74c73c2f1fd" },
                    { "5638fe4d-db73-4c85-af6e-b6d032939989", "2b31a4a3-beab-41be-923e-9c9a158582a2" },
                    { "d528a17f-24da-4708-8d91-cdabc333cc77", "a5c0b889-bfc3-4ebb-a8a4-ae4d4113ee5a" }
                });
        }
    }
}
