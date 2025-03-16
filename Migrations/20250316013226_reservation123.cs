using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reservation.Migrations
{
    /// <inheritdoc />
    public partial class reservation123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Prix",
                table: "Vols",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Vols",
                keyColumn: "Id",
                keyValue: 1,
                column: "Prix",
                value: 1500);

            migrationBuilder.UpdateData(
                table: "Vols",
                keyColumn: "Id",
                keyValue: 2,
                column: "Prix",
                value: 3500);

            migrationBuilder.UpdateData(
                table: "Vols",
                keyColumn: "Id",
                keyValue: 3,
                column: "Prix",
                value: 2500);

            migrationBuilder.UpdateData(
                table: "Vols",
                keyColumn: "Id",
                keyValue: 4,
                column: "Prix",
                value: 4500);

            migrationBuilder.UpdateData(
                table: "Vols",
                keyColumn: "Id",
                keyValue: 5,
                column: "Prix",
                value: 2000);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Prix",
                table: "Vols",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Vols",
                keyColumn: "Id",
                keyValue: 1,
                column: "Prix",
                value: 1500m);

            migrationBuilder.UpdateData(
                table: "Vols",
                keyColumn: "Id",
                keyValue: 2,
                column: "Prix",
                value: 3500m);

            migrationBuilder.UpdateData(
                table: "Vols",
                keyColumn: "Id",
                keyValue: 3,
                column: "Prix",
                value: 2500m);

            migrationBuilder.UpdateData(
                table: "Vols",
                keyColumn: "Id",
                keyValue: 4,
                column: "Prix",
                value: 4500m);

            migrationBuilder.UpdateData(
                table: "Vols",
                keyColumn: "Id",
                keyValue: 5,
                column: "Prix",
                value: 2000m);
        }
    }
}
