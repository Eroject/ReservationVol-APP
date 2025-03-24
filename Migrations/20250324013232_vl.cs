using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reservation.Migrations
{
    /// <inheritdoc />
    public partial class vl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Gestionnaires",
                columns: new[] { "Id", "AnneeRecrutement", "Code", "Nom" },
                values: new object[,]
                {
                    { 1, 2018, "GEST123", "Ali" },
                    { 2, 2020, "GEST456", "Nadia" },
                    { 3, 2021, "GEST789", "Yassine" },
                    { 4, 2019, "GEST999", "Omar" },
                    { 5, 2022, "GEST222", "Sofia" }
                });

            migrationBuilder.InsertData(
                table: "Vols",
                columns: new[] { "Id", "DateArrivee", "Depart", "Destination", "NombrePlacesMax", "PlacesDisponibles", "Prix" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casablanca", "Paris", 200, 50, 1500 },
                    { 2, new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marrakech", "New York", 300, 100, 3500 },
                    { 3, new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rabat", "Dubai", 250, 150, 2500 },
                    { 4, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casablanca", "Tokyo", 150, 80, 4500 },
                    { 5, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marrakech", "London", 180, 60, 2000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gestionnaires",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gestionnaires",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Gestionnaires",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Gestionnaires",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Gestionnaires",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vols",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vols",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vols",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vols",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vols",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
