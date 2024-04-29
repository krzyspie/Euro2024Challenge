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

    public static MatchResult CreateNew(string result)
    {
        string[] goals = result.Split(':');
        return new MatchResult(
            ushort.Parse(goals[0]), 
            ushort.Parse(goals[1])
            );
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return HomeTeamGoals;
        yield return AwayTeamGoals;
    }
    
    public override string ToString() => $"{HomeTeamGoals} : {AwayTeamGoals}";
}