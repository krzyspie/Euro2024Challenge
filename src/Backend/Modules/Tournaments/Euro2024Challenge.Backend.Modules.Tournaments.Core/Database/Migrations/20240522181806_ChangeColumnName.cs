using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Database.Migrations
{
    /// <inheritdoc />
    public partial class ChangeColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Golas",
                schema: "tournaments",
                table: "Footballers",
                newName: "Goals");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Goals",
                schema: "tournaments",
                table: "Footballers",
                newName: "Golas");
        }
    }
}
