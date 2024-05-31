using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace orchideasalon.Migrations
{
    /// <inheritdoc />
    public partial class RemovedServiceImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c35d7080-f89e-40ad-9bbb-684c90e913ab");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bf06e803-4e5c-41c4-a1ab-aae84d9629ca", "5d665815-5d7d-4fbf-b9ab-170039d0ac97" });

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("383f05ae-a1b3-400a-8b2e-299e29ca2f7b"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("4ff62c24-3a06-451c-828e-0ebb185da286"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("52236549-35e2-44db-94c4-992550385067"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("98123c31-d7e7-4024-937f-85660def7a5a"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("a609ffa0-41b3-4a4a-882e-69c360ae4939"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("a76dce4d-4f49-4693-a485-8ab8f9357c12"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("e7c4dd5e-34cc-4a35-ae7d-9b3581d18388"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("ed61402d-6271-4d55-82fa-2c3d46f9d914"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("f3bc0f4c-6250-4820-9b38-3d68956d7db1"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf06e803-4e5c-41c4-a1ab-aae84d9629ca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d665815-5d7d-4fbf-b9ab-170039d0ac97");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Services");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a33ae0dc-1ebc-4e97-915e-ac2c43d5bd7e", null, "manager", "manager" },
                    { "b8db1623-f33e-4513-be90-b07eb80cc29a", null, "admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e0c1bf77-5048-4c66-a481-b9f7510ca792", 0, "45bfd88f-47f9-43ff-9f3b-ee05ea8bb258", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEHHQlHUrymwC0EK9kfRFwNDKGKqCnCKYoiIQQ4JIY+r4Fr+xaWyOMZGT/ySIxgBzeg==", null, true, "9de4d3b5-f70a-4852-8fb3-15bb702a91ab", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "Id", "Approved", "Date", "FirstName", "Notes", "Phone", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("1603352b-9a02-4f60-93cb-c02ab5f847f1"), true, new DateTime(2024, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "Орися", "", "0893943003", 2 },
                    { new Guid("29845d38-5d1f-426a-bfc3-8064416d6c57"), false, null, "Антоніна", "", "0453243545", null },
                    { new Guid("36f8d1db-d5d0-411e-8c1a-4e20eac15177"), false, null, "Соломія", "", "0735748392", null },
                    { new Guid("75fe90fa-96ee-46c1-8441-8091ad6d7efb"), true, new DateTime(2024, 6, 30, 11, 45, 0, 0, DateTimeKind.Unspecified), "Галина", "", "0930943903", 3 },
                    { new Guid("8dce186e-7f0a-4393-a98f-b00416cbc550"), true, new DateTime(2024, 6, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), "Соломія", "Червоний манікюр", "0893943003", 1 },
                    { new Guid("a2eb6302-dee8-4c76-9153-ccbcadf03b2d"), false, null, "Тетяна", "", "0973932904", null },
                    { new Guid("ad85f26c-e9c0-4f77-8e4a-89dd4330112f"), true, new DateTime(2024, 5, 25, 12, 40, 0, 0, DateTimeKind.Unspecified), "Катерина", "", "0645748392", 2 },
                    { new Guid("bab62061-1b56-4deb-83f1-ede3235ab24f"), true, new DateTime(2024, 2, 1, 13, 45, 0, 0, DateTimeKind.Unspecified), "Леся", "", "0743957294", 3 },
                    { new Guid("d7f7ad9b-cc24-4eee-a816-4c2158ddb7ad"), true, new DateTime(2023, 12, 27, 18, 30, 0, 0, DateTimeKind.Unspecified), "Соломія", "", "0735748392", 3 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b8db1623-f33e-4513-be90-b07eb80cc29a", "e0c1bf77-5048-4c66-a481-b9f7510ca792" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a33ae0dc-1ebc-4e97-915e-ac2c43d5bd7e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b8db1623-f33e-4513-be90-b07eb80cc29a", "e0c1bf77-5048-4c66-a481-b9f7510ca792" });

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("1603352b-9a02-4f60-93cb-c02ab5f847f1"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("29845d38-5d1f-426a-bfc3-8064416d6c57"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("36f8d1db-d5d0-411e-8c1a-4e20eac15177"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("75fe90fa-96ee-46c1-8441-8091ad6d7efb"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("8dce186e-7f0a-4393-a98f-b00416cbc550"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("a2eb6302-dee8-4c76-9153-ccbcadf03b2d"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("ad85f26c-e9c0-4f77-8e4a-89dd4330112f"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("bab62061-1b56-4deb-83f1-ede3235ab24f"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("d7f7ad9b-cc24-4eee-a816-4c2158ddb7ad"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8db1623-f33e-4513-be90-b07eb80cc29a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0c1bf77-5048-4c66-a481-b9f7510ca792");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Services",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bf06e803-4e5c-41c4-a1ab-aae84d9629ca", null, "admin", "ADMIN" },
                    { "c35d7080-f89e-40ad-9bbb-684c90e913ab", null, "manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5d665815-5d7d-4fbf-b9ab-170039d0ac97", 0, "e4ac8761-48f5-4832-8487-e3dba4a21cee", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEMZ+9f16MM8IdLQ6t3IUCb2WsIXdtAVcDP9gWTt0MziwMpOs69IFw9+ncgHQn1Zniw==", null, true, "a6880ed0-d308-4eaa-8dc6-cd65e23b5a9a", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "Id", "Approved", "Date", "FirstName", "Notes", "Phone", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("383f05ae-a1b3-400a-8b2e-299e29ca2f7b"), false, null, "Тетяна", "", "0973932904", null },
                    { new Guid("4ff62c24-3a06-451c-828e-0ebb185da286"), true, new DateTime(2024, 2, 1, 13, 45, 0, 0, DateTimeKind.Unspecified), "Леся", "", "0743957294", 3 },
                    { new Guid("52236549-35e2-44db-94c4-992550385067"), false, null, "Антоніна", "", "0453243545", null },
                    { new Guid("98123c31-d7e7-4024-937f-85660def7a5a"), true, new DateTime(2024, 6, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), "Соломія", "Червоний манікюр", "0893943003", 1 },
                    { new Guid("a609ffa0-41b3-4a4a-882e-69c360ae4939"), true, new DateTime(2024, 5, 25, 12, 40, 0, 0, DateTimeKind.Unspecified), "Катерина", "", "0645748392", 2 },
                    { new Guid("a76dce4d-4f49-4693-a485-8ab8f9357c12"), true, new DateTime(2024, 6, 30, 11, 45, 0, 0, DateTimeKind.Unspecified), "Галина", "", "0930943903", 3 },
                    { new Guid("e7c4dd5e-34cc-4a35-ae7d-9b3581d18388"), false, null, "Соломія", "", "0735748392", null },
                    { new Guid("ed61402d-6271-4d55-82fa-2c3d46f9d914"), true, new DateTime(2023, 12, 27, 18, 30, 0, 0, DateTimeKind.Unspecified), "Соломія", "", "0735748392", 3 },
                    { new Guid("f3bc0f4c-6250-4820-9b38-3d68956d7db1"), true, new DateTime(2024, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "Орися", "", "0893943003", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://www.amberbeautysalon.ae/cdn/shop/products/FrenchM_Image4.png");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://images.prom.ua/3804692702_w600_h600_3804692702.jpg");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://2.bp.blogspot.com/-2W_7I7x0dlo/UglH9g6i9rI/AAAAAAAABHc/86PYR0EBYrU/s1600/shutterstock_114182782.jpg");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bf06e803-4e5c-41c4-a1ab-aae84d9629ca", "5d665815-5d7d-4fbf-b9ab-170039d0ac97" });
        }
    }
}
