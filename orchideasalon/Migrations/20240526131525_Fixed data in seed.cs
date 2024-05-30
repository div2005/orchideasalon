using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace orchideasalon.Migrations
{
    /// <inheritdoc />
    public partial class Fixeddatainseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4138b228-eee1-458d-b9a3-15a4bb1c4bb6");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b7fa2cc2-b102-41c1-91c0-27a5153e900a", "bc494a7c-cded-4efd-b30a-33cd035e93cd" });

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("00d43192-e4f6-4c96-a1bf-3af9ed94175b"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("3fc06ba9-a9f4-4125-8078-2785c620f280"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("609cefb9-1902-4a6c-b201-e392f3eead36"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("81576118-2449-4c76-86b3-6de2aa5e8780"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("ce8466f4-fcb4-4861-b1d4-ee7e0101eabb"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("f79ce862-8d6d-46ed-bdc3-26592d292cdd"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7fa2cc2-b102-41c1-91c0-27a5153e900a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc494a7c-cded-4efd-b30a-33cd035e93cd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7926c669-4bff-45bd-b582-a7e8c9ee7fc6", null, "manager", "MANAGER" },
                    { "e4b22151-bc10-4a23-ae65-4ea389259e6c", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e5db0b67-9591-460c-b304-d6aa1561b974", 0, "b545bed2-4803-4f22-995b-1d5bfb49f678", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAENQjPyO8TWFHS9HWOGGgEocMi6ebWOCT1EuUkAJOuEYKQtKox81tx3IQ+QbpKHjxYw==", null, true, "b9f5819d-52fc-4c23-81e7-199a7d0f9832", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "Id", "DayId", "FirstName", "Phone", "ServiceId", "Time" },
                values: new object[,]
                {
                    { new Guid("0330e2ae-3ea2-4363-8299-1c7f34f79555"), 3, "Леся", "0743957294", 3, new TimeOnly(9, 30, 0) },
                    { new Guid("0cfb6afb-a092-4325-975f-57bd96070c76"), 2, "Орися", "0893943003", 2, new TimeOnly(12, 0, 0) },
                    { new Guid("0f0e67c6-ab1a-4e37-9cc9-b1dbf7f24024"), 1, "Соломія", "0893943003", 1, new TimeOnly(16, 30, 0) },
                    { new Guid("69d83f27-590b-4519-bd3b-5913e8622f23"), 3, "Соломія", "0545748392", 3, new TimeOnly(13, 30, 0) },
                    { new Guid("dd32aaa1-61f9-4693-8a19-8c85132b04f6"), 4, "Галина", "0930943903", 3, new TimeOnly(18, 30, 0) },
                    { new Guid("e366ec5a-c5a4-45d1-ba1f-9097ea443f3f"), 5, "Катерина", "0645748392", 2, new TimeOnly(14, 30, 0) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e4b22151-bc10-4a23-ae65-4ea389259e6c", "e5db0b67-9591-460c-b304-d6aa1561b974" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7926c669-4bff-45bd-b582-a7e8c9ee7fc6");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e4b22151-bc10-4a23-ae65-4ea389259e6c", "e5db0b67-9591-460c-b304-d6aa1561b974" });

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("0330e2ae-3ea2-4363-8299-1c7f34f79555"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("0cfb6afb-a092-4325-975f-57bd96070c76"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("0f0e67c6-ab1a-4e37-9cc9-b1dbf7f24024"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("69d83f27-590b-4519-bd3b-5913e8622f23"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("dd32aaa1-61f9-4693-8a19-8c85132b04f6"));

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("e366ec5a-c5a4-45d1-ba1f-9097ea443f3f"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4b22151-bc10-4a23-ae65-4ea389259e6c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5db0b67-9591-460c-b304-d6aa1561b974");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4138b228-eee1-458d-b9a3-15a4bb1c4bb6", null, "manager", "MANAGER" },
                    { "b7fa2cc2-b102-41c1-91c0-27a5153e900a", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bc494a7c-cded-4efd-b30a-33cd035e93cd", 0, "28b7c472-6698-4f4a-8bba-dfda0f3b9147", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEFxLtsshf8Va+Gdyq+DZ7sGRAY91TEhHqLViUhkYd4L+N8/trSN2ckr1tXgEcX9BRw==", null, true, "7099f422-9560-4c90-91b6-13b7bf6aae7d", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "Id", "DayId", "FirstName", "Phone", "ServiceId", "Time" },
                values: new object[,]
                {
                    { new Guid("00d43192-e4f6-4c96-a1bf-3af9ed94175b"), 3, "Соломія", "0743957294", 3, new TimeOnly(9, 30, 0) },
                    { new Guid("3fc06ba9-a9f4-4125-8078-2785c620f280"), 2, "Соломія", "0893943003", 2, new TimeOnly(12, 0, 0) },
                    { new Guid("609cefb9-1902-4a6c-b201-e392f3eead36"), 4, "Соломія", "0930943903", 3, new TimeOnly(18, 30, 0) },
                    { new Guid("81576118-2449-4c76-86b3-6de2aa5e8780"), 5, "Соломія", "0645748392", 2, new TimeOnly(14, 30, 0) },
                    { new Guid("ce8466f4-fcb4-4861-b1d4-ee7e0101eabb"), 1, "Соломія", "0893943003", 1, new TimeOnly(16, 30, 0) },
                    { new Guid("f79ce862-8d6d-46ed-bdc3-26592d292cdd"), 3, "Соломія", "0545748392", 3, new TimeOnly(13, 30, 0) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b7fa2cc2-b102-41c1-91c0-27a5153e900a", "bc494a7c-cded-4efd-b30a-33cd035e93cd" });
        }
    }
}
