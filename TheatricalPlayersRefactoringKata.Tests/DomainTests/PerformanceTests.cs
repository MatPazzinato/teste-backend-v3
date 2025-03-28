using TheatricalPlayers.Domain.Entidades;
using Xunit;

namespace TheatricalPlayersRefactoringKata.Tests.DomainTests
{
    public class PerformanceTests
    {
        [Fact]
        public void ValidatePerformanceCreation()
        {
            var playId = "playIdtest";
            var performanceAudience = 1000;

            var performance = new Performance(playId, performanceAudience);

            Assert.Equal(performance.PlayId, playId);
            Assert.Equal(performance.Audience, performanceAudience);
        }
    }
}
