namespace Euro2024Challenge.Backend.Modules.Tournament.Shared.IntegrationEvents;

public record class TournamentEnd(string TeamWinner, int TopScoresFootballer, int TopScoresFootballerGoals);