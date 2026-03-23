using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem2025.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UniqueConstraintForPhoneNumberAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Agents",
                comment: "House Agent");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8cb533f-7993-461a-9788-26a7a85ae451", "AQAAAAIAAYagAAAAEP4wWSP9OmlH2Cyewr1mk9pfHUx4M+NSUznGpbzWAEdQq9ClySAa2mErpiIbAs9xHA==", "0875f3cb-6a8b-41ae-9d55-134d1785c5b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7903e576-65cd-4fdc-818b-37c93a282782", "AQAAAAIAAYagAAAAEGQWKGkKhzA7x4Y+tYQUejUjT+OicDjngXxnBRpsEJK5bYoprMl7qaViOX0ty97G1w==", "1fa18481-69cd-47a8-8c0b-cb8b15e7b1b9" });

            migrationBuilder.CreateIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents",
                column: "PhoneNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents");

            migrationBuilder.AlterTable(
                name: "Agents",
                oldComment: "House Agent");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7490ca1-628c-4be7-b252-42f9596c3195", "AQAAAAIAAYagAAAAEHU+6d64L6UjiGDZxUXjuKyODKeT6wcwDyC5LLrybpfBJcYhaQHBrO84YKEaiLC2rw==", "4e99e77b-8c43-4eda-99ff-27e4244b1c30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b5e8448-2c10-4bfa-b101-ecdd6065c8cf", "AQAAAAIAAYagAAAAEDuOBzjMNOqiX1QJVIN8BJu9TDC6hnmoA7xZMfo4rp4nxJldKJB+zOTG1SsDhwlDhQ==", "f53676a9-fe37-46e0-b92c-be019554208e" });
        }
    }
}
