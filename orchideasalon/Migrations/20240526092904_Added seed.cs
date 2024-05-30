using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace orchideasalon.Migrations
{
    /// <inheritdoc />
    public partial class Addedseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Services_ServiceIdId",
                table: "Registrations");

            migrationBuilder.RenameColumn(
                name: "ServiceIdId",
                table: "Registrations",
                newName: "ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_Registrations_ServiceIdId",
                table: "Registrations",
                newName: "IX_Registrations_ServiceId");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "159dd13e-b418-480e-aa97-f70d5283a9bb", 0, "22a93481-9b36-451b-bdf3-d27a8dde0a49", "admin@admin.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEJqFB0ClRq40hq1JmGCOpYfnJsuKEDkow6cbH0cvrr54A7BqHXkQVVCLwNWV+Ow2kA==", null, true, "1ebe72cc-5a80-41ea-98f7-6d8e3baef72d", false, "admin" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "Duration", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Класичний", 30, "https://www.amberbeautysalon.ae/cdn/shop/products/FrenchM_Image4.png", "Манікюр", 300m },
                    { 2, "+ укладка", 30, "https://images.prom.ua/3804692702_w600_h600_3804692702.jpg", "Стрижка жіноча", 600m },
                    { 3, "+ масаж", 30, "https://2.bp.blogspot.com/-2W_7I7x0dlo/UglH9g6i9rI/AAAAAAAABHc/86PYR0EBYrU/s1600/shutterstock_114182782.jpg", "SPA", 750m }
                });

            migrationBuilder.InsertData(
                table: "WorkingDays",
                columns: new[] { "Id", "BeginTime", "Date", "EndTime" },
                values: new object[] { 1, new TimeOnly(9, 0, 0), new DateOnly(2000, 10, 2), new TimeOnly(18, 0, 0) });

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "Id", "DayId", "FirstName", "Phone", "ServiceId", "Time" },
                values: new object[] { new Guid("01485e1e-7364-425f-85ad-8be60010a98c"), 1, "Соломія", "0893943003", 2, new TimeOnly(9, 30, 0) });

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Services_ServiceId",
                table: "Registrations",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Services_ServiceId",
                table: "Registrations");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "159dd13e-b418-480e-aa97-f70d5283a9bb");

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: new Guid("01485e1e-7364-425f-85ad-8be60010a98c"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "Registrations",
                newName: "ServiceIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Registrations_ServiceId",
                table: "Registrations",
                newName: "IX_Registrations_ServiceIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Services_ServiceIdId",
                table: "Registrations",
                column: "ServiceIdId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
