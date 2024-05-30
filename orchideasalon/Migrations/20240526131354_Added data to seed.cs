using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace orchideasalon.Migrations
{
    /// <inheritdoc />
    public partial class Addeddatatoseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f87ba3fd-0baa-4bb9-b043-dfba11f3cf9d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0d7dba35-151a-41a8-a1a6-e2aaf2791817", "2225ecf5-a12e-4dce-8754-72910c2219cf" });

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("0c568130-93c4-44f0-b87f-b25d374e55a9"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d7dba35-151a-41a8-a1a6-e2aaf2791817");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2225ecf5-a12e-4dce-8754-72910c2219cf");

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
                values: new object[] { new Guid("ce8466f4-fcb4-4861-b1d4-ee7e0101eabb"), 1, "Соломія", "0893943003", 1, new TimeOnly(16, 30, 0) });

            migrationBuilder.UpdateData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BeginTime", "Date" },
                values: new object[] { new TimeOnly(10, 0, 0), new DateOnly(2024, 6, 30) });

            migrationBuilder.InsertData(
                table: "WorkingDays",
                columns: new[] { "Id", "BeginTime", "Date", "EndTime" },
                values: new object[,]
                {
                    { 2, new TimeOnly(11, 30, 0), new DateOnly(2024, 1, 2), new TimeOnly(15, 0, 0) },
                    { 3, new TimeOnly(9, 0, 0), new DateOnly(2023, 10, 25), new TimeOnly(18, 0, 0) },
                    { 4, new TimeOnly(9, 0, 0), new DateOnly(2023, 12, 3), new TimeOnly(18, 0, 0) },
                    { 5, new TimeOnly(9, 0, 0), new DateOnly(2024, 6, 29), new TimeOnly(18, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b7fa2cc2-b102-41c1-91c0-27a5153e900a", "bc494a7c-cded-4efd-b30a-33cd035e93cd" });

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "Id", "DayId", "FirstName", "Phone", "ServiceId", "Time" },
                values: new object[,]
                {
                    { new Guid("00d43192-e4f6-4c96-a1bf-3af9ed94175b"), 3, "Соломія", "0743957294", 3, new TimeOnly(9, 30, 0) },
                    { new Guid("3fc06ba9-a9f4-4125-8078-2785c620f280"), 2, "Соломія", "0893943003", 2, new TimeOnly(12, 0, 0) },
                    { new Guid("609cefb9-1902-4a6c-b201-e392f3eead36"), 4, "Соломія", "0930943903", 3, new TimeOnly(18, 30, 0) },
                    { new Guid("81576118-2449-4c76-86b3-6de2aa5e8780"), 5, "Соломія", "0645748392", 2, new TimeOnly(14, 30, 0) },
                    { new Guid("f79ce862-8d6d-46ed-bdc3-26592d292cdd"), 3, "Соломія", "0545748392", 3, new TimeOnly(13, 30, 0) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d7dba35-151a-41a8-a1a6-e2aaf2791817", null, "admin", "ADMIN" },
                    { "f87ba3fd-0baa-4bb9-b043-dfba11f3cf9d", null, "manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2225ecf5-a12e-4dce-8754-72910c2219cf", 0, "4cd3f3d8-f056-4dbd-ab57-5ab7d89126de", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEEYncq5XDqsKGVsF2fnh+hlT4Ck9kFzM4KsMLlxQY2Uxc2IEtm5T19jPZaVge6BSsg==", null, true, "83fa2a1c-deed-4802-9396-598aeb47ce5b", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "Id", "DayId", "FirstName", "Phone", "ServiceId", "Time" },
                values: new object[] { new Guid("0c568130-93c4-44f0-b87f-b25d374e55a9"), 1, "Соломія", "0893943003", 2, new TimeOnly(9, 30, 0) });

            migrationBuilder.UpdateData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BeginTime", "Date" },
                values: new object[] { new TimeOnly(9, 0, 0), new DateOnly(2000, 10, 2) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0d7dba35-151a-41a8-a1a6-e2aaf2791817", "2225ecf5-a12e-4dce-8754-72910c2219cf" });
        }
    }
}
