using Euro2024Challenge.Backend.Modules.Tournaments.Core.Cache;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Services;
using NSubstitute;

namespace Modules.Tournamnets.Core.Tests.Services
{
    [TestFixture]
    public class TeamServiceTests
    {
        private ITeamRepository _teamRepositorSubstitute;
        private ITeamsCache _teamCacheSubstitute;
        private TeamService _teamService;

        [SetUp]
        public void Setup()
        {
            _teamRepositorSubstitute = Substitute.For<ITeamRepository>();
            _teamCacheSubstitute = Substitute.For<ITeamsCache>();
        }

        [Test]
        public async Task GetTeamReturnsTeamWithGivenId()
        {
            //Arrange
            int teamId = 2;
            string teamName = "Germany";
            Dictionary<int, string> allTeams = new (){{1, "Poland"}, {2, teamName}, {3, "France"}};

            _teamCacheSubstitute.TryGetValue(out Arg.Any<Dictionary<int, string>?>()).Returns(false);
            _teamRepositorSubstitute.GetAllTeamsAsync().Returns(allTeams);

            _teamService = new TeamService(_teamRepositorSubstitute, _teamCacheSubstitute);
            
            //Act
            var result = await _teamService.GetTeamAsync(teamId);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(result.Id, Is.EqualTo(teamId));
                Assert.That(result.Name, Is.EqualTo(teamName));
            });

            _teamCacheSubstitute.Received(1).Set(allTeams);
        }

        [Test]
        public async Task GetTeamReturnsTeamWithGivenIdFromCache()
        {
            //Arrange
            int teamId = 2;
            string teamName = "Germany";
            Dictionary<int, string> allTeams = new (){{1, "Poland"}, {2, teamName}, {3, "France"}};

            _teamCacheSubstitute.TryGetValue(out Arg.Any<Dictionary<int, string>?>()).Returns(x => {
                x[0] = allTeams;
                return true;
                });

            _teamService = new TeamService(_teamRepositorSubstitute, _teamCacheSubstitute);
            
            //Act
            var result = await _teamService.GetTeamAsync(teamId);

            //Assert
            Assert.That(result.Id, Is.EqualTo(teamId));
            Assert.That(result.Name, Is.EqualTo(teamName));

            await _teamRepositorSubstitute.DidNotReceive().GetAllTeamsAsync();
            _teamCacheSubstitute.DidNotReceive().Set(Arg.Any<Dictionary<int, string>>());
        }
    }
}