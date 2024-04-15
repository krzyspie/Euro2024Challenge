using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Database.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "tournaments");

            migrationBuilder.CreateTable(
                name: "Matches",
                schema: "tournaments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    GuestTeamId = table.Column<int>(type: "integer", nullable: false),
                    AwayTeamId = table.Column<int>(type: "integer", nullable: false),
                    GuestTeamGoals = table.Column<int>(type: "integer", nullable: false),
                    AwayTeamGoals = table.Column<int>(type: "integer", nullable: false),
                    StartHour = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                schema: "tournaments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(16)", maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Footballers",
                schema: "tournaments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    Golas = table.Column<int>(type: "integer", nullable: false),
                    TeamId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Footballers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Footballers_Teams_TeamId",
                        column: x => x.TeamId,
                        principalSchema: "tournaments",
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Footballers_TeamId",
                schema: "tournaments",
                table: "Footballers",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Name",
                schema: "tournaments",
                table: "Teams",
                column: "Name",
                unique: true);
            
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Albania" },
                    { 2, "Austria" },
                    { 3, "Belgium" },
                    { 4, "Croatia" },
                    { 5, "Czechia" },
                    { 6, "Denmark" },
                    { 7, "England" },
                    { 8, "France" },
                    { 9, "Georgia" },
                    { 10, "Germany" },
                    { 11, "Hungary" },
                    { 12, "Italy" },
                    { 13, "Netherlands" },
                    { 14, "Poland" },
                    { 15, "Portugal" },
                    { 16, "Romania" },
                    { 17, "Scotland" },
                    { 18, "Serbia" },
                    { 19, "Slovakia" },
                    { 20, "Slovenia" },
                    { 21, "Spain" },
                    { 22, "Switzerland" },
                    { 23, "Türkiye" },
                    { 24, "Ukraine" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Footballers",
                schema: "tournaments");

            migrationBuilder.DropTable(
                name: "Matches",
                schema: "tournaments");

            migrationBuilder.DropTable(
                name: "Teams",
                schema: "tournaments");
        }
    }
}
