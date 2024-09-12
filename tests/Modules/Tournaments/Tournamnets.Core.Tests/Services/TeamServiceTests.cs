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

        [Test]
        public async Task GetTeamsReturnsTeamsWithGivenIds()
        {
            //Arrange
            int teamId = 2;
            int teamId2 = 3;
            string teamName = "Germany";
            string teamName2 = "France";
            Dictionary<int, string> allTeams = new (){{ 1, "Poland" }, { teamId, teamName }, { teamId2, teamName2 }};

            _teamCacheSubstitute.TryGetValue(out Arg.Any<Dictionary<int, string>?>()).Returns(false);
            _teamRepositorSubstitute.GetAllTeamsAsync().Returns(allTeams);

            _teamService = new TeamService(_teamRepositorSubstitute, _teamCacheSubstitute);
            
            //Act
            var result = await _teamService.GetTeamsAsync([teamId, teamId2]);

            //Assert
            Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count(), Is.EqualTo(2));
            var item1 = result.Single(x => x.Id == teamId);
            Assert.That(item1.Name, Is.EqualTo(teamName));
            var item2 = result.Single(x => x.Id == teamId2);
            Assert.That(item2.Name, Is.EqualTo(teamName2));

            _teamCacheSubstitute.Received(1).Set(allTeams);
        }

        [Test]
        public async Task GetTeamsReturnsTeamsWithGivenIdsFromCache()
        {
            //Arrange
            int teamId = 2;
            int teamId2 = 3;
            string teamName = "Germany";
            string teamName2 = "France";
            Dictionary<int, string> allTeams = new (){{ 1, "Poland" }, { teamId, teamName }, { teamId2, teamName2 }};

            _teamCacheSubstitute.TryGetValue(out Arg.Any<Dictionary<int, string>?>()).Returns(x => {
                x[0] = allTeams;
                return true;
                });

            _teamService = new TeamService(_teamRepositorSubstitute, _teamCacheSubstitute);
            
            //Act
            var result = await _teamService.GetTeamsAsync([teamId, teamId2]);

            //Assert
            Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count(), Is.EqualTo(2));
            var item1 = result.Single(x => x.Id == teamId);
            Assert.That(item1.Name, Is.EqualTo(teamName));
            var item2 = result.Single(x => x.Id == teamId2);
            Assert.That(item2.Name, Is.EqualTo(teamName2));

            await _teamRepositorSubstitute.DidNotReceive().GetAllTeamsAsync();
            _teamCacheSubstitute.DidNotReceive().Set(Arg.Any<Dictionary<int, string>>());
        }
    }
}