using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class MessageEdited2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SendingDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    ToId = table.Column<string>(type: "TEXT", nullable: true),
                    ToName = table.Column<string>(type: "TEXT", nullable: true),
                    FromId = table.Column<string>(type: "TEXT", nullable: true),
                    FromName = table.Column<string>(type: "TEXT", nullable: true),
                    IsRead = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

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
    }
}
