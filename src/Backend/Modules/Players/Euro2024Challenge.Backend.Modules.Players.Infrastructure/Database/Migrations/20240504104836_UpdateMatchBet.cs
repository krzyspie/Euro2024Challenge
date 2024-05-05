using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Euro2024Challenge.Backend.Modules.Players.Infrastructure.Database.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMatchBet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Result",
                schema: "players",
                table: "MatchBets",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "Winner",
                schema: "players",
                table: "MatchBets",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Winner",
                schema: "players",
                table: "MatchBets");

            migrationBuilder.AlterColumn<string>(
                name: "Result",
                schema: "players",
                table: "MatchBets",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
