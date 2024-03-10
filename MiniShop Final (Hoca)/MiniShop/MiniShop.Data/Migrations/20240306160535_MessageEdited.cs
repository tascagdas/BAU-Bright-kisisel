using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class MessageEdited : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bc710cbf-5bcb-4b0c-b1f4-01b9945441bd", "2b41ce0a-dadf-421b-9326-86440c12de5c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "806f26d9-683f-4165-97c6-884a67c8ec8a", "6697f2f5-a886-43f4-9830-0944372fd7a6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad987dfc-d418-4ac7-bb81-644b030e31c2", "d0ccea6d-a4a1-4224-8471-c512bc22fc0e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "806f26d9-683f-4165-97c6-884a67c8ec8a", "dc3f38d5-4095-4f13-8eaf-f9c65d604baf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "806f26d9-683f-4165-97c6-884a67c8ec8a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad987dfc-d418-4ac7-bb81-644b030e31c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc710cbf-5bcb-4b0c-b1f4-01b9945441bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b41ce0a-dadf-421b-9326-86440c12de5c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6697f2f5-a886-43f4-9830-0944372fd7a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0ccea6d-a4a1-4224-8471-c512bc22fc0e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc3f38d5-4095-4f13-8eaf-f9c65d604baf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "52ba2d1f-4ddf-432a-bc86-ee60c5e38d8b", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" },
                    { "9236b847-131e-4e64-bae8-18174ba04f1a", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" },
                    { "c9141b08-411e-41d9-82ae-09d2c859b1d3", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "61ecda7d-4f79-4cd0-af83-7fa59ccb1316", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "ea24d0f2-d3ee-46fb-938e-f90d9c052903", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAELffvT9PBh6jNvvJzFUeIrczQ8soUfrbgu80II169UYeMKQ1AiJ1RgWXEIV4jiHr/g==", "5387996655", false, "c20c5efd-151b-426a-8971-30a151946b0c", false, "aysenumay" },
                    { "93b7b7ec-730b-4bae-89bf-b2ec92b35211", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "98ebbf42-ee46-4478-b99c-8b7467a5fa59", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEB53+TmCzFVXvIKzYIMO7pBMhecI1GC09ajK1Px/66lC2fqu/pP22WRMkconXf8ouQ==", "5387996655", false, "65be6a2b-204e-4d39-8e82-9c04001ca046", false, "selinmete" },
                    { "bf6a8751-ac14-4209-a740-489b58e6d3c1", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "0ef462f8-bda9-4ed4-ad14-558065116b1e", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEFhAqZHRZa+Eh20FQitKSI6pdxMYnPykly8JmVEVnqdrkehWBsCE+tD1D9i6x12Piw==", "5387996655", false, "6ff35c9e-8885-42d0-9a2b-1ccb9ac2ec6e", false, "kemaldurukan" },
                    { "d626d827-fa4b-4895-8c32-c4fd0cfeb209", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "6f64fbaa-a656-4418-beff-364240ef3ea2", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEE8vtSGvOdtApG3fn1pGsBOlzXO/YHlq3x+aXSa1UuLoJVsMQITRWP316ZgJ96xSwQ==", "5558779966", false, "3211e809-da66-4d87-99bb-8b87da7caafb", false, "denizfoca" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 35, 512, DateTimeKind.Local).AddTicks(4158), new DateTime(2024, 3, 6, 19, 5, 35, 512, DateTimeKind.Local).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 35, 512, DateTimeKind.Local).AddTicks(4171), new DateTime(2024, 3, 6, 19, 5, 35, 512, DateTimeKind.Local).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 35, 512, DateTimeKind.Local).AddTicks(4174), new DateTime(2024, 3, 6, 19, 5, 35, 512, DateTimeKind.Local).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 35, 512, DateTimeKind.Local).AddTicks(4175), new DateTime(2024, 3, 6, 19, 5, 35, 512, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 35, 512, DateTimeKind.Local).AddTicks(4177), new DateTime(2024, 3, 6, 19, 5, 35, 512, DateTimeKind.Local).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 35, 513, DateTimeKind.Local).AddTicks(4267), new DateTime(2024, 3, 6, 19, 5, 35, 513, DateTimeKind.Local).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 35, 513, DateTimeKind.Local).AddTicks(4286), new DateTime(2024, 3, 6, 19, 5, 35, 513, DateTimeKind.Local).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 35, 513, DateTimeKind.Local).AddTicks(4289), new DateTime(2024, 3, 6, 19, 5, 35, 513, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 35, 513, DateTimeKind.Local).AddTicks(4291), new DateTime(2024, 3, 6, 19, 5, 35, 513, DateTimeKind.Local).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 35, 513, DateTimeKind.Local).AddTicks(4294), new DateTime(2024, 3, 6, 19, 5, 35, 513, DateTimeKind.Local).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 35, 513, DateTimeKind.Local).AddTicks(4296), new DateTime(2024, 3, 6, 19, 5, 35, 513, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 35, 513, DateTimeKind.Local).AddTicks(4298), new DateTime(2024, 3, 6, 19, 5, 35, 513, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 35, 513, DateTimeKind.Local).AddTicks(4301), new DateTime(2024, 3, 6, 19, 5, 35, 513, DateTimeKind.Local).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 35, 513, DateTimeKind.Local).AddTicks(4391), new DateTime(2024, 3, 6, 19, 5, 35, 513, DateTimeKind.Local).AddTicks(4392) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 35, 513, DateTimeKind.Local).AddTicks(4394), new DateTime(2024, 3, 6, 19, 5, 35, 513, DateTimeKind.Local).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 35, 513, DateTimeKind.Local).AddTicks(4397), new DateTime(2024, 3, 6, 19, 5, 35, 513, DateTimeKind.Local).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 35, 511, DateTimeKind.Local).AddTicks(7036), "d626d827-fa4b-4895-8c32-c4fd0cfeb209" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 35, 511, DateTimeKind.Local).AddTicks(7061), "93b7b7ec-730b-4bae-89bf-b2ec92b35211" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 35, 511, DateTimeKind.Local).AddTicks(7063), "bf6a8751-ac14-4209-a740-489b58e6d3c1" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 35, 511, DateTimeKind.Local).AddTicks(7065), "61ecda7d-4f79-4cd0-af83-7fa59ccb1316" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "52ba2d1f-4ddf-432a-bc86-ee60c5e38d8b", "61ecda7d-4f79-4cd0-af83-7fa59ccb1316" },
                    { "c9141b08-411e-41d9-82ae-09d2c859b1d3", "93b7b7ec-730b-4bae-89bf-b2ec92b35211" },
                    { "c9141b08-411e-41d9-82ae-09d2c859b1d3", "bf6a8751-ac14-4209-a740-489b58e6d3c1" },
                    { "9236b847-131e-4e64-bae8-18174ba04f1a", "d626d827-fa4b-4895-8c32-c4fd0cfeb209" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "52ba2d1f-4ddf-432a-bc86-ee60c5e38d8b", "61ecda7d-4f79-4cd0-af83-7fa59ccb1316" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c9141b08-411e-41d9-82ae-09d2c859b1d3", "93b7b7ec-730b-4bae-89bf-b2ec92b35211" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c9141b08-411e-41d9-82ae-09d2c859b1d3", "bf6a8751-ac14-4209-a740-489b58e6d3c1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9236b847-131e-4e64-bae8-18174ba04f1a", "d626d827-fa4b-4895-8c32-c4fd0cfeb209" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52ba2d1f-4ddf-432a-bc86-ee60c5e38d8b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9236b847-131e-4e64-bae8-18174ba04f1a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9141b08-411e-41d9-82ae-09d2c859b1d3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61ecda7d-4f79-4cd0-af83-7fa59ccb1316");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93b7b7ec-730b-4bae-89bf-b2ec92b35211");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf6a8751-ac14-4209-a740-489b58e6d3c1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d626d827-fa4b-4895-8c32-c4fd0cfeb209");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "806f26d9-683f-4165-97c6-884a67c8ec8a", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" },
                    { "ad987dfc-d418-4ac7-bb81-644b030e31c2", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" },
                    { "bc710cbf-5bcb-4b0c-b1f4-01b9945441bd", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2b41ce0a-dadf-421b-9326-86440c12de5c", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "394f1e15-bd43-458f-860d-4c6d0c4b10aa", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEIXgWXtkkoYZYXvnWfwho9ZoiwhggYA6RSAjCdCb0QIrbdtplphrBSgKQKqVove37w==", "5387996655", false, "2364f5d3-d4f3-41fd-8cc2-20f9a5605b49", false, "aysenumay" },
                    { "6697f2f5-a886-43f4-9830-0944372fd7a6", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "d02914a6-5a09-4a92-8874-bca08d2a0fa3", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEDdmOv7WJG9N8EBPej4e9MXYOHxVLckMxBdH6xje9cjhlp18REUr4l/8M+O7j0rBHw==", "5387996655", false, "134c416a-8593-49a9-8c21-005776bcf28b", false, "kemaldurukan" },
                    { "d0ccea6d-a4a1-4224-8471-c512bc22fc0e", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "b779580e-7a73-4c6e-be53-4dceaa96a2a0", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEEeKC9LS9IDcuB9I9UzutvLiautjHjnzIY0ViTrOW5DP3UMVylRdHwOpz1E9ro0hVg==", "5558779966", false, "ef6625c9-3fdb-41db-99df-0401c52887b8", false, "denizfoca" },
                    { "dc3f38d5-4095-4f13-8eaf-f9c65d604baf", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "22d93f21-7ed9-4687-ac47-ffbeba93c8de", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAED64J0MlHiE6eZmhSnDQw6IUitW0OiBugrzzFrDVf6sHSfL7AGYh0rVChezSylhLFA==", "5387996655", false, "2a12cb38-cd9c-43ed-8850-ee96ea984a51", false, "selinmete" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(9631), new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(9644), new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(9646), new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(9647), new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(9648), new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7376), new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7391), new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7393), new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7395), new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7397), new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7398), new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7400), new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7404), new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7425), new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7427), new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7429), new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(4295), "d0ccea6d-a4a1-4224-8471-c512bc22fc0e" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(4335), "dc3f38d5-4095-4f13-8eaf-f9c65d604baf" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(4336), "6697f2f5-a886-43f4-9830-0944372fd7a6" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(4337), "2b41ce0a-dadf-421b-9326-86440c12de5c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bc710cbf-5bcb-4b0c-b1f4-01b9945441bd", "2b41ce0a-dadf-421b-9326-86440c12de5c" },
                    { "806f26d9-683f-4165-97c6-884a67c8ec8a", "6697f2f5-a886-43f4-9830-0944372fd7a6" },
                    { "ad987dfc-d418-4ac7-bb81-644b030e31c2", "d0ccea6d-a4a1-4224-8471-c512bc22fc0e" },
                    { "806f26d9-683f-4165-97c6-884a67c8ec8a", "dc3f38d5-4095-4f13-8eaf-f9c65d604baf" }
                });
        }
    }
}
