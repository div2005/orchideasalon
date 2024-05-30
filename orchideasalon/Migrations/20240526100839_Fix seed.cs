using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace orchideasalon.Migrations
{
    /// <inheritdoc />
    public partial class Fixseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5288826d-bebf-46a2-be62-92cb68a3e1c3", null, "admin", "ADMIN" },
                    { "6d03284e-cb82-43f7-a881-e5586fc46ddb", null, "manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b4bcc7f7-35a6-41e0-bf8c-fe30ca6083b1", 0, "eba913a6-c52f-4e92-b43c-e093f03af12e", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEK5GjlwQrAA2e0/mi7GqLSjYS/ALAKggYsbBRZdHA7hwI4EfoYxewFQ0AVRWycgedQ==", null, true, "43e96bb5-898e-4809-adc0-ecc295ca93a9", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "Id", "DayId", "FirstName", "Phone", "ServiceId", "Time" },
                values: new object[] { new Guid("f82f9d80-4595-4fd4-a08c-c1696309be37"), 1, "Соломія", "0893943003", 2, new TimeOnly(9, 30, 0) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5288826d-bebf-46a2-be62-92cb68a3e1c3", "b4bcc7f7-35a6-41e0-bf8c-fe30ca6083b1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d03284e-cb82-43f7-a881-e5586fc46ddb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5288826d-bebf-46a2-be62-92cb68a3e1c3", "b4bcc7f7-35a6-41e0-bf8c-fe30ca6083b1" });

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("f82f9d80-4595-4fd4-a08c-c1696309be37"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5288826d-bebf-46a2-be62-92cb68a3e1c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4bcc7f7-35a6-41e0-bf8c-fe30ca6083b1");

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
    }
}
