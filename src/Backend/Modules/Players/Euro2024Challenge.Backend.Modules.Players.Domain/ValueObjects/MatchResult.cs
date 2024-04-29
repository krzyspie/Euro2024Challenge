using Euro2024Challenge.Shared.Domain;

namespace Euro2024Challenge.Backend.Modules.Players.Domain.ValueObjects;

public class MatchResult : ValueObject
{
    public ushort HomeTeamGoals { get; }
    public ushort AwayTeamGoals { get; }

    private MatchResult(ushort homeTeamGoals, ushort awayTeamGoals)
    {
        HomeTeamGoals = homeTeamGoals;
        AwayTeamGoals = awayTeamGoals;
    }

    public static MatchResult CreateNew(ushort homeTeamGoals, ushort awayTeamGoals)
    {
        return new MatchResult(homeTeamGoals, awayTeamGoals);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return HomeTeamGoals;
        yield return AwayTeamGoals;
    }
    
    public override string ToString() => $"{HomeTeamGoals} : {AwayTeamGoals}";
}