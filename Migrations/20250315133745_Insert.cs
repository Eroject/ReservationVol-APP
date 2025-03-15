using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reservation.Migrations
{
    /// <inheritdoc />
    public partial class Insert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "ClientId", "DateReservation", "Etat", "VolId" },
                values: new object[,]
                {
                    { 5, 4, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 6, 4, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 7, 4, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 8, 4, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
