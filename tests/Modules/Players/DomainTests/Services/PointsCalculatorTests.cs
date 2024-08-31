using Euro2024Challenge.Backend.Modules.Players.Domain.Services;
using Euro2024Challenge.Backend.Modules.Players.Domain.ValueObjects;

namespace Modules.Players.Domain.Tests.Services;

public class Tests
{
    [Test]
    public void CalculateMatchPointsWhenMissingMatchResult()
    {
        //Arrange
        PointsCalculator pointsCalculator = new();

        //Act
        var result = pointsCalculator.CalculateMatchPoints(0, 0, null);

        //Assert
        Assert.That(result, Is.Zero);
    }

    [Test]
    public void CalculateMatchPointsWhenBetsGoalsAndMatchGoalsEquals()
    {
        //Arrange
        PointsCalculator pointsCalculator = new();
        var matchResult = MatchResult.CreateNew(2, 1);

        //Act
        var result = pointsCalculator.CalculateMatchPoints(2, 1, matchResult);

        //Assert
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void CalculateMatchPointsWhenBetsGoalsAndMatchGoalsDifferenceEquals()
    {
        //Arrange
        PointsCalculator pointsCalculator = new();
        var matchResult = MatchResult.CreateNew(3, 2);

        //Act
        var result = pointsCalculator.CalculateMatchPoints(2, 1, matchResult);

        //Assert
        Assert.That(result, Is.EqualTo(3));
    }


    [TestCase(2, 1, 3, 1)]
    [TestCase(1, 2, 1, 3)]
    public void CalculateMatchPointsWhenBetWinnerAndMatchWinnerEquals(int homeTeamGoals, int awayTeamGoals, int betHomeTeamGoals, int betAwayTemaGoals)
    {
        //Arrange
        PointsCalculator pointsCalculator = new();
        var matchResult = MatchResult.CreateNew((ushort)betHomeTeamGoals, (ushort)betAwayTemaGoals);

        //Act
        var result = pointsCalculator.CalculateMatchPoints(homeTeamGoals, awayTeamGoals, matchResult);

        //Assert
        Assert.That(result, Is.EqualTo(2));
    }
}