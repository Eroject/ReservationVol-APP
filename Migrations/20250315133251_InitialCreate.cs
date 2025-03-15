using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reservation.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gestionnaires",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnneeRecrutement = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gestionnaires", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vols",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Depart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateArrivee = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prix = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NombrePlacesMax = table.Column<int>(type: "int", nullable: false),
                    PlacesDisponibles = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vols", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    VolId = table.Column<int>(type: "int", nullable: false),
                    Etat = table.Column<int>(type: "int", nullable: false),
                    DateReservation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Vols_VolId",
                        column: x => x.VolId,
                        principalTable: "Vols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Age", "CIN", "Nom", "Prenom" },
                values: new object[,]
                {
                    { 1, 30, "CIN1", "ClientNom1", "ClientPrenom1" },
                    { 2, 32, "CIN2", "ClientNom2", "ClientPrenom2" },
                    { 3, 28, "CIN3", "ClientNom3", "ClientPrenom3" },
                    { 4, 45, "CIN4", "ClientNom4", "ClientPrenom4" }
                });

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
                    { 1, new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casablanca", "Paris", 200, 50, 1500m },
                    { 2, new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marrakech", "New York", 300, 100, 3500m },
                    { 3, new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rabat", "Dubai", 250, 150, 2500m },
                    { 4, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casablanca", "Tokyo", 150, 80, 4500m },
                    { 5, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marrakech", "London", 180, 60, 2000m }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "ClientId", "DateReservation", "Etat", "VolId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, 2, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 3, 3, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 },
                    { 4, 4, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ClientId",
                table: "Reservations",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_VolId",
                table: "Reservations",
                column: "VolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gestionnaires");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Vols");
        }
    }
}
