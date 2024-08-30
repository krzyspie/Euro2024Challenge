using Euro2024Challenge.Backend.Modules.Players.Domain.Services;
using Euro2024Challenge.Backend.Modules.Players.Domain.ValueObjects;

namespace DomainTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

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
}