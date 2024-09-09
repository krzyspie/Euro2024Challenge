using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Services;
using NSubstitute;

namespace Modules.Tournamnets.Core.Tests.Services
{
    public class FootballerServiceTests
    {
        private IFootballerRepository _footballerRepositorySubstitute;
        private FootballerService _footballerService;

        [SetUp]
        public void Setup()
        {
            _footballerRepositorySubstitute = Substitute.For<IFootballerRepository>();
        }

        [Test]
        public async Task GetReturnsFootballerResponse()
        {
            //Arrange
            int id = 1;
            Footballer footballer = new()
            {
                Id = 1,
                FullName = "Test Name",
                Goals = 7,
                TeamId = 99,
                Team = new()
                {
                    Name = "Poland"
                }
            };

            _footballerRepositorySubstitute.Get(id).Returns(footballer);
            
            _footballerService = new FootballerService(_footballerRepositorySubstitute);

            //Act
            var result = await _footballerService.Get(id);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(result.FullName, Is.EqualTo(footballer.FullName));
                Assert.That(result.Goals, Is.EqualTo(footballer.Goals));
                Assert.That(result.Id, Is.EqualTo(footballer.Id));
                Assert.That(result.TeamName, Is.EqualTo(footballer.Team.Name));
            });
        }
    }
}