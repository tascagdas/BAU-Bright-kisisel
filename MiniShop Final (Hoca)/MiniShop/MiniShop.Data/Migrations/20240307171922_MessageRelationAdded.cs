using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class MessageRelationAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72ed418b-1713-49b5-8d92-3674963cc2ec", "558dc500-54b0-4c59-a963-c9f29d966cd3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "334a316f-006b-48a7-81be-d8db90274d1e", "c631cb5f-3ab5-4c05-b8c8-1d4803e2d234" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fc5e5049-ab54-4341-9a3b-2394aaf48bff", "cb963dc9-bc2c-4e92-a9bb-2a8b121e2773" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "334a316f-006b-48a7-81be-d8db90274d1e", "f2f1d981-7ad4-4c34-970f-34bd15997520" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "334a316f-006b-48a7-81be-d8db90274d1e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72ed418b-1713-49b5-8d92-3674963cc2ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc5e5049-ab54-4341-9a3b-2394aaf48bff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "558dc500-54b0-4c59-a963-c9f29d966cd3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c631cb5f-3ab5-4c05-b8c8-1d4803e2d234");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb963dc9-bc2c-4e92-a9bb-2a8b121e2773");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2f1d981-7ad4-4c34-970f-34bd15997520");

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
                    { "1f481422-e5a5-4bd0-b000-64b966a6cd48", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" },
                    { "b03ab881-05b6-4f6d-8b98-d6cbd1298c8d", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" },
                    { "d3ad35e4-e525-403b-a3e1-3b62394a240a", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "08b1bebe-63cc-4379-b9cf-d10e9af8679a", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "2a57adb5-99fd-4fc8-b607-f6c59fe89550", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEPm4L4rprHVfQ9y/xs6FgFyWNiepMgJXm3CjDs3UxEv3Gf2Yl0bE8rHs+UCMdlFzhQ==", "5387996655", false, "34c2df7d-4153-4bb6-99ec-43470be6f5ba", false, "kemaldurukan" },
                    { "5271eb15-a0f2-4832-a841-c0f54469014e", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "d92cf42b-55e4-48dd-a8e4-b88bb422e02b", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEFuBr2JhhDUsgwNr6KHGcEcI3OE0vtH+9GXmN4AKOA+ss46lQYeRTFLGD+0P9Rp2hg==", "5558779966", false, "7e272e4e-68da-4b55-80e1-336dc061c6ad", false, "denizfoca" },
                    { "da5ace6d-6bbf-4aaa-89c0-325f329f4e1e", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "d4cdb3c3-62e3-4f28-af56-5db1152c3c73", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEHnUDHd1p+Y26rq1d5+DuRofs5Mq2rppbja0yq64d3LCvuGc0waZc6ayD/QYhk86ZA==", "5387996655", false, "39c11497-a315-43ff-92de-7f8afd49fdea", false, "aysenumay" },
                    { "f582545a-91a2-46e1-af2b-24eb9373a420", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "237f187f-5c16-4f3f-bf08-afea3bf30665", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEKU6CT0T9f4yoNh+f/Zk5H7BigL7z6/mt7pNfWBVy7wZYlU4RHrJLtwyA+y8oLnw5Q==", "5387996655", false, "632c8ca8-064a-4182-849b-53a0a8ee41db", false, "selinmete" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(3366), new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(3376), new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(3378), new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(3379), new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(3380), new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(9774), new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(9783), new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(9785), new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(9787), new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(9787) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(9789), new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(9790), new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(9792), new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(9794), new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(9798) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(9808), new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(9809), new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(9811), new DateTime(2024, 3, 7, 20, 19, 22, 105, DateTimeKind.Local).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 22, 104, DateTimeKind.Local).AddTicks(7148), "5271eb15-a0f2-4832-a841-c0f54469014e" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 22, 104, DateTimeKind.Local).AddTicks(7166), "f582545a-91a2-46e1-af2b-24eb9373a420" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 22, 104, DateTimeKind.Local).AddTicks(7167), "08b1bebe-63cc-4379-b9cf-d10e9af8679a" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 22, 104, DateTimeKind.Local).AddTicks(7168), "da5ace6d-6bbf-4aaa-89c0-325f329f4e1e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b03ab881-05b6-4f6d-8b98-d6cbd1298c8d", "08b1bebe-63cc-4379-b9cf-d10e9af8679a" },
                    { "d3ad35e4-e525-403b-a3e1-3b62394a240a", "5271eb15-a0f2-4832-a841-c0f54469014e" },
                    { "1f481422-e5a5-4bd0-b000-64b966a6cd48", "da5ace6d-6bbf-4aaa-89c0-325f329f4e1e" },
                    { "b03ab881-05b6-4f6d-8b98-d6cbd1298c8d", "f582545a-91a2-46e1-af2b-24eb9373a420" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b03ab881-05b6-4f6d-8b98-d6cbd1298c8d", "08b1bebe-63cc-4379-b9cf-d10e9af8679a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d3ad35e4-e525-403b-a3e1-3b62394a240a", "5271eb15-a0f2-4832-a841-c0f54469014e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1f481422-e5a5-4bd0-b000-64b966a6cd48", "da5ace6d-6bbf-4aaa-89c0-325f329f4e1e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b03ab881-05b6-4f6d-8b98-d6cbd1298c8d", "f582545a-91a2-46e1-af2b-24eb9373a420" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f481422-e5a5-4bd0-b000-64b966a6cd48");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b03ab881-05b6-4f6d-8b98-d6cbd1298c8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ad35e4-e525-403b-a3e1-3b62394a240a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08b1bebe-63cc-4379-b9cf-d10e9af8679a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5271eb15-a0f2-4832-a841-c0f54469014e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da5ace6d-6bbf-4aaa-89c0-325f329f4e1e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f582545a-91a2-46e1-af2b-24eb9373a420");

            migrationBuilder.DropColumn(
                name: "RelatedId",
                table: "Messages");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "334a316f-006b-48a7-81be-d8db90274d1e", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" },
                    { "72ed418b-1713-49b5-8d92-3674963cc2ec", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" },
                    { "fc5e5049-ab54-4341-9a3b-2394aaf48bff", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "558dc500-54b0-4c59-a963-c9f29d966cd3", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "827e3ef8-5480-4c4e-b226-7ac41c799109", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEIz56KyriwsoDhxyxRWEmoi5E5HugpMRHRRYAKLjcInEe1+oyHZMFV+RDMySlqJqPA==", "5387996655", false, "ba8d040c-0830-4ee1-bf22-0afb09d00a4a", false, "aysenumay" },
                    { "c631cb5f-3ab5-4c05-b8c8-1d4803e2d234", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "66b5f4af-88be-4b95-a392-614e494bb4db", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEMxg/YUT5U3SegTOgfP0aYekIrbbEhrc5O/UisIDfXU3Jw7NaItzkqb3ivNsauAozw==", "5387996655", false, "59620a05-66d9-4a9d-96ce-4fa4ea44fd80", false, "kemaldurukan" },
                    { "cb963dc9-bc2c-4e92-a9bb-2a8b121e2773", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "fc010fb2-1e71-466a-bec8-0bb148a4daef", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEBwz21Hmz2JF8/mOHkWl5aaKIvSwKipnXXKg5QOgIgvuIvJkTu3CZZjDEkB8bWmQ0A==", "5558779966", false, "887e9ed7-82b0-4c9c-9201-752818f20a24", false, "denizfoca" },
                    { "f2f1d981-7ad4-4c34-970f-34bd15997520", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "1a9e1ef4-ee23-4c33-90d9-62601dbe8769", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAENnpzPJZ0R0NVlZh9RPQ4MSA3DvNuaNZTK3zgxSb77MJORHrvutxdHj/Fyd0UWR4iQ==", "5387996655", false, "ddf8df0f-e7e4-441b-800e-35fcaefe8643", false, "selinmete" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(5377), new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(5393), new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(5394) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(5395), new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(5396), new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(5397), new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1410), new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1425), new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1427), new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1428), new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1430), new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1431), new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1433), new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1434), new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1450), new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1452), new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1452) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1453), new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(1214), "cb963dc9-bc2c-4e92-a9bb-2a8b121e2773" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(1244), "f2f1d981-7ad4-4c34-970f-34bd15997520" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(1246), "c631cb5f-3ab5-4c05-b8c8-1d4803e2d234" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(1247), "558dc500-54b0-4c59-a963-c9f29d966cd3" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "72ed418b-1713-49b5-8d92-3674963cc2ec", "558dc500-54b0-4c59-a963-c9f29d966cd3" },
                    { "334a316f-006b-48a7-81be-d8db90274d1e", "c631cb5f-3ab5-4c05-b8c8-1d4803e2d234" },
                    { "fc5e5049-ab54-4341-9a3b-2394aaf48bff", "cb963dc9-bc2c-4e92-a9bb-2a8b121e2773" },
                    { "334a316f-006b-48a7-81be-d8db90274d1e", "f2f1d981-7ad4-4c34-970f-34bd15997520" }
                });
        }
    }
}
