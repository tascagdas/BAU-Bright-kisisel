using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class useradded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(1500), "Son model TV'leirn bulunduğu kategorisi", new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(1500), "Süper hızlı Bilgisayarı bulabileceğiniz kategori", new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(1510), "Elektronik Eşyaların bulunduğu kategorisi", new DateTime(2024, 2, 17, 11, 58, 5, 929, DateTimeKind.Local).AddTicks(1510) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 28, 559, DateTimeKind.Local).AddTicks(7840), "TV kategorisi", new DateTime(2024, 2, 8, 20, 3, 28, 559, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 28, 559, DateTimeKind.Local).AddTicks(7860), "Bilgisayar kategorisi", new DateTime(2024, 2, 8, 20, 3, 28, 559, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 28, 559, DateTimeKind.Local).AddTicks(7860), "Elektronik Eşya kategorisi", new DateTime(2024, 2, 8, 20, 3, 28, 559, DateTimeKind.Local).AddTicks(7860) });

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

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 28, 559, DateTimeKind.Local).AddTicks(4440), "b5a23069-fbc6-4751-a394-109c21107be9" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 28, 559, DateTimeKind.Local).AddTicks(4490), "e62f016c-f101-4969-a597-81bcf8d69598" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 28, 559, DateTimeKind.Local).AddTicks(4490), "3f1465c3-1bca-419e-80f7-41842a6bc308" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 28, 559, DateTimeKind.Local).AddTicks(4490), "062b7757-e3b3-4925-a9fb-435ec283729a" });

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
    }
}
