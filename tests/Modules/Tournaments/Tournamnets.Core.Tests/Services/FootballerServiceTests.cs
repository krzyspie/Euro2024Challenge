using Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;
using NSubstitute;

namespace Modules.Tournamnets.Core.Tests.Services
{
    public class FootballerServiceTests
    {
        private IFootballerRepository _footballerRepositorySubstitute;

        [SetUp]
        public void Setup()
        {
            _footballerRepositorySubstitute = Substitute.For<IFootballerRepository>();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}