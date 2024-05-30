using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace orchideasalon.Migrations
{
    /// <inheritdoc />
    public partial class AddedRolestoseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "159dd13e-b418-480e-aa97-f70d5283a9bb");

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("01485e1e-7364-425f-85ad-8be60010a98c"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "33e5e5f0-7b07-4a5c-982b-509b88ada25c", null, "admin", "ADMIN" },
                    { "9eef98e4-a195-4398-986a-1cae65817d5b", null, "manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fa5c44be-39db-40f3-9a97-9eaa47fa045a", 0, "98b65e58-7df2-4c36-916d-7eb470ed14cc", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEFIqvOnTe819GYy0sfpLzxUYT6j6AAxTvmP+c7KnngwHRoGS2qNal6fhZk4tc8MGxw==", null, true, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "Id", "DayId", "FirstName", "Phone", "ServiceId", "Time" },
                values: new object[] { new Guid("13daa688-8041-4e0f-8815-6982fe348026"), 1, "Соломія", "0893943003", 2, new TimeOnly(9, 30, 0) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "33e5e5f0-7b07-4a5c-982b-509b88ada25c", "fa5c44be-39db-40f3-9a97-9eaa47fa045a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9eef98e4-a195-4398-986a-1cae65817d5b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33e5e5f0-7b07-4a5c-982b-509b88ada25c", "fa5c44be-39db-40f3-9a97-9eaa47fa045a" });

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("13daa688-8041-4e0f-8815-6982fe348026"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33e5e5f0-7b07-4a5c-982b-509b88ada25c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa5c44be-39db-40f3-9a97-9eaa47fa045a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "159dd13e-b418-480e-aa97-f70d5283a9bb", 0, "22a93481-9b36-451b-bdf3-d27a8dde0a49", "admin@admin.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEJqFB0ClRq40hq1JmGCOpYfnJsuKEDkow6cbH0cvrr54A7BqHXkQVVCLwNWV+Ow2kA==", null, true, "1ebe72cc-5a80-41ea-98f7-6d8e3baef72d", false, "admin" });

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "Id", "DayId", "FirstName", "Phone", "ServiceId", "Time" },
                values: new object[] { new Guid("01485e1e-7364-425f-85ad-8be60010a98c"), 1, "Соломія", "0893943003", 2, new TimeOnly(9, 30, 0) });
        }
    }
}
