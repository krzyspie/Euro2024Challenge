using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Euro2024Challenge.Backend.Modules.Players.Infrastructure.Database.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "players");

            migrationBuilder.CreateTable(
                name: "Players",
                schema: "players",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Username = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MatchBets",
                schema: "players",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PlayerId = table.Column<Guid>(type: "uuid", nullable: false),
                    MatchId = table.Column<int>(type: "integer", nullable: false),
                    Result = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchBets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchBets_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalSchema: "players",
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TopScorerBet",
                schema: "players",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PlayerId = table.Column<Guid>(type: "uuid", nullable: false),
                    FootballerId = table.Column<int>(type: "integer", nullable: false),
                    Goals = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopScorerBet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TopScorerBet_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalSchema: "players",
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TournamentWinnerBets",
                schema: "players",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PlayerId = table.Column<Guid>(type: "uuid", nullable: false),
                    TeamId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentWinnerBets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TournamentWinnerBets_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalSchema: "players",
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MatchBets_PlayerId",
                schema: "players",
                table: "MatchBets",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_Email",
                schema: "players",
                table: "Players",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TopScorerBet_PlayerId",
                schema: "players",
                table: "TopScorerBet",
                column: "PlayerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TournamentWinnerBets_PlayerId",
                schema: "players",
                table: "TournamentWinnerBets",
                column: "PlayerId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchBets",
                schema: "players");

            migrationBuilder.DropTable(
                name: "TopScorerBet",
                schema: "players");

            migrationBuilder.DropTable(
                name: "TournamentWinnerBets",
                schema: "players");

            migrationBuilder.DropTable(
                name: "Players",
                schema: "players");
        }
    }
}
