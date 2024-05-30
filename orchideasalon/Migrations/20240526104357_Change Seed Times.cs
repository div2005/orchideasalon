using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace orchideasalon.Migrations
{
    /// <inheritdoc />
    public partial class ChangeSeedTimes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0d7dba35-151a-41a8-a1a6-e2aaf2791817", "2225ecf5-a12e-4dce-8754-72910c2219cf" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
