using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Services;
using Euro2024Challenge.Shared;
using NSubstitute;

namespace Modules.Tournamnets.Core.Tests.Services;

[TestFixture]
public class MatchServiceTests
{
    private IMatchRepository _matchRepositorySubstitute;
    private ITeamRepository _teamRepositorSubstitute;
    private IEventBus _eventBusSubstitute;
    MatchService matchService;

    [SetUp]
    public void Setup()
    {
        _matchRepositorySubstitute = Substitute.For<IMatchRepository>();
        _teamRepositorSubstitute = Substitute.For<ITeamRepository>();
        _eventBusSubstitute = Substitute.For<IEventBus>();
    }

    [Test]
    public async Task GetAllReturnsAllMatches()
    {
        //Arrange
        var matchDate = DateTime.Today;
        var matches = new List<Match>()
        {
            new() {
                Id = 1,
                Number = 1,
                AwayTeamId = 111,
                AwayTeamGoals = 0,
                GuestTeamId = 112,
                GuestTeamGoals = 1,
                StartHour = matchDate
            },
            new() {
                Id = 2,
                Number = 2,
                AwayTeamId = 113,
                AwayTeamGoals = 2,
                GuestTeamId = 114,
                GuestTeamGoals = 2,
                StartHour = matchDate
            }
        };

        var teams = new Dictionary<int, string>()
        {
            { 111, "Albania" },
            { 112, "Belgium" },
            { 113, "Croatia" },
            { 114, "Portugal" },
        };
        
        _matchRepositorySubstitute.GetAll().Returns(matches);
        _teamRepositorSubstitute.GetAllTeamsAsync().Returns(teams);

        matchService = new MatchService(_matchRepositorySubstitute, _teamRepositorSubstitute, _eventBusSubstitute);

        //Act
        var result = await matchService.GetAll();

        //Assert
        Assert.That(result, Is.Not.Empty);
        Assert.That(result, Has.Count.EqualTo(2));
        
        var first = result.First();
        Assert.Multiple(() =>
        {
            Assert.That(first.Id, Is.EqualTo(1));
            Assert.That(first.Number, Is.EqualTo(1));
            Assert.That(first.GuestTeamId, Is.EqualTo(112));
            Assert.That(first.GuestTeamName, Is.EqualTo("Belgium"));
            Assert.That(first.GuestTeamGoals, Is.EqualTo(1));
            Assert.That(first.AwayTeamId, Is.EqualTo(111));
            Assert.That(first.AwayTeamName, Is.EqualTo("Albania"));
            Assert.That(first.AwayTeamGoals, Is.EqualTo(0));
            Assert.That(first.StartHour, Is.EqualTo(matchDate));
        });

        var second = result.Last();
        Assert.Multiple(() =>
        {
            Assert.That(second.Id, Is.EqualTo(2));
            Assert.That(second.Number, Is.EqualTo(2));
            Assert.That(second.GuestTeamId, Is.EqualTo(114));
            Assert.That(second.GuestTeamName, Is.EqualTo("Portugal"));
            Assert.That(second.GuestTeamGoals, Is.EqualTo(2));
            Assert.That(second.AwayTeamId, Is.EqualTo(113));
            Assert.That(second.AwayTeamName, Is.EqualTo("Croatia"));
            Assert.That(second.AwayTeamGoals, Is.EqualTo(2));
            Assert.That(second.StartHour, Is.EqualTo(matchDate));
        });
    }

    [Test]
    public async Task GetByNumberReturnsMatchWithGivenNumber()
    {
        //Arrange
        var matchNumber = 3;
        var matchDate = DateTime.Today;
        var match = new Match
        {
            Id = 1,
            Number = matchNumber,
            AwayTeamId = 111,
            AwayTeamGoals = 0,
            GuestTeamId = 112,
            GuestTeamGoals = 1,
            StartHour = matchDate
        };

        var teams = new Dictionary<int, string>()
        {
            { 111, "Albania" },
            { 112, "Belgium" },
            { 113, "Croatia" },
            { 114, "Portugal" },
        };
        
        _matchRepositorySubstitute.GetByNumber(matchNumber).Returns(match);
        _teamRepositorSubstitute.GetAllTeamsAsync().Returns(teams);

        matchService = new MatchService(_matchRepositorySubstitute, _teamRepositorSubstitute, _eventBusSubstitute);

        //Act
        var result = await matchService.GetByNumber(matchNumber);

        //Assert
        Assert.That(result, Is.Not.Null);    
        Assert.Multiple(() =>
        {
            Assert.That(result.Id, Is.EqualTo(match.Id));
            Assert.That(result.Number, Is.EqualTo(matchNumber));
            Assert.That(result.GuestTeamId, Is.EqualTo(match.GuestTeamId));
            Assert.That(result.GuestTeamName, Is.EqualTo("Belgium"));
            Assert.That(result.GuestTeamGoals, Is.EqualTo(match.GuestTeamGoals));
            Assert.That(result.AwayTeamId, Is.EqualTo(match.AwayTeamId));
            Assert.That(result.AwayTeamName, Is.EqualTo("Albania"));
            Assert.That(result.AwayTeamGoals, Is.EqualTo(match.AwayTeamGoals));
            Assert.That(result.StartHour, Is.EqualTo(matchDate));
        });
    }
}