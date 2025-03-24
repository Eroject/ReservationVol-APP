using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reservation.Migrations
{
    /// <inheritdoc />
    public partial class tst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "CIN", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nom", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prenom", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "05536694-9cc9-480d-8af2-dabdf5199cd5", 0, 30, "CIN1", "7c86cb23-5ce2-47f3-9ac1-03a24a28c194", "Client", null, false, false, null, "ClientNom1", null, null, null, null, false, "ClientPrenom1", "979780b9-3ee3-4eb1-86b7-cba4243451ed", false, null },
                    { "31939c97-bcc5-4466-8dec-e0d1c8ceda55", 0, 32, "CIN2", "ef5df05a-d65a-4b66-8599-f33c42c9a733", "Client", null, false, false, null, "ClientNom2", null, null, null, null, false, "ClientPrenom2", "464604cd-0e1f-4a16-91d8-e13dd6d157c5", false, null },
                    { "6285ad8f-b857-422d-8767-611f9f9fc349", 0, 28, "CIN3", "8e74afe2-a49e-4189-b9e7-f65adfadf118", "Client", null, false, false, null, "ClientNom3", null, null, null, null, false, "ClientPrenom3", "8ac332ab-2e59-4c5f-82d5-1df08e8cc6da", false, null },
                    { "86bda6fe-9cdd-46c6-a0ea-4dee477bf397", 0, 45, "CIN4", "fc76c9fe-243a-4ece-bd1f-583606c7ed68", "Client", null, false, false, null, "ClientNom4", null, null, null, null, false, "ClientPrenom4", "0776943e-06b9-4cca-a274-0d40a3f350e4", false, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05536694-9cc9-480d-8af2-dabdf5199cd5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31939c97-bcc5-4466-8dec-e0d1c8ceda55");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6285ad8f-b857-422d-8767-611f9f9fc349");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86bda6fe-9cdd-46c6-a0ea-4dee477bf397");
        }
    }
}
