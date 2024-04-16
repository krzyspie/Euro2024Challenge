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
            
            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Number", "GuestTeamId", "AwayTeamId", "GuestTeamGoals", "AwayTeamGoals", "StartHour" },
                values: new object[,]
                {
                    { 1, 1, 10, 17, 0, 0, "14/06/2024 21:00" },
                    { 2, 2, 11, 22, 0, 0, "15/06/2024 15:00" },
                    { 3, 3, 21, 4, 0, 0, "15/06/2024 18:00" },
                    { 4, 4, 12, 1, 0, 0, "15/06/2024 21:00" },
                    { 5, 5, 14, 13, 0, 0, "16/06/2024 15:00" },
                    { 6, 6, 20, 6, 0, 0, "16/06/2024 18:00" },
                    { 7, 7, 18, 7, 0, 0, "16/06/2024 21:00" },
                    { 8, 8, 16, 24, 0, 0, "17/06/2024 15:00" },
                    { 9, 9, 3, 19, 0, 0, "17/06/2024 18:00" },
                    { 10, 10, 2, 8, 0, 0, "17/06/2024 21:00" },
                    { 11, 11, 23, 9, 0, 0, "18/06/2024 18:00" },
                    { 12, 12, 15, 5, 0, 0, "18/06/2024 21:00" },
                    { 13, 13, 4, 1, 0, 0, "19/06/2024 15:00" },
                    { 14, 14, 10, 11, 0, 0, "19/06/2024 18:00" },
                    { 15, 15, 17, 22, 0, 0, "19/06/2024 21:00" },
                    { 16, 16, 20, 18, 0, 0, "20/06/2024 15:00" },
                    { 17, 17, 6, 7, 0, 0, "20/06/2024 18:00" },
                    { 18, 18, 21, 12, 0, 0, "20/06/2024 21:00" },
                    { 19, 19, 19, 24, 0, 0, "21/06/2024 15:00" },
                    { 20, 20, 14, 2, 0, 0, "21/06/2024 18:00" },
                    { 21, 21, 13, 8, 0, 0, "21/06/2024 21:00" },
                    { 22, 22, 9, 5, 0, 0, "22/06/2024 15:00" },
                    { 23, 23, 23, 15, 0, 0, "22/06/2024 18:00" },
                    { 24, 24, 3, 16, 0, 0, "22/06/2024 21:00" },
                    { 25, 25, 22, 10, 0, 0, "23/06/2024 21:00" },
                    { 26, 26, 17, 11, 0, 0, "23/06/2024 21:00" },
                    { 27, 27, 1, 21, 0, 0, "24/06/2024 21:00" },
                    { 28, 28, 4, 12, 0, 0, "24/06/2024 21:00" },
                    { 29, 29, 13, 2, 0, 0, "25/06/2024 18:00" },
                    { 30, 30, 8, 14, 0, 0, "25/06/2024 18:00" },
                    { 31, 31, 7, 20, 0, 0, "25/06/2024 21:00" },
                    { 32, 32, 6, 18, 0, 0, "25/06/2024 21:00" },
                    { 33, 33, 19, 16, 0, 0, "26/06/2024 18:00" },
                    { 34, 34, 24, 3, 0, 0, "26/06/2024 18:00" },
                    { 35, 35, 9, 15, 0, 0, "26/06/2024 21:00" },
                    { 36, 36, 5, 23, 0, 0, "26/06/2024 21:00" },
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
