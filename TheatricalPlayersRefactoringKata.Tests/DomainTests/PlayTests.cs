using TheatricalPlayers.Domain.Entidades;
using TheatricalPlayers.Domain.Enums;
using TheatricalPlayers.Domain.Utils;
using Xunit;

namespace TheatricalPlayersRefactoringKata.Tests.DomainTests
{
    
    public class PlayTests
    {
        
        [Fact]
        public void ValidatePlayCreation()
        {
            var playName = "PlayNameTest";
            var playLines = 3000;
            var playType = PlayTypeEnum.history;

            var play = new Play(playName, playLines, playType);

            Assert.Equal(play.Name, playName);
            Assert.Equal(play.Lines, playLines);
            Assert.Equal(play.Type, playType);
        }

        [Fact]
        public void ValidateLinesUnderTheLimit()
        {
            var lines = EnvironmentValues.MINIMUM_LINES_VALUE - 1;
            var play = new Play("PlayNameTest", lines, PlayTypeEnum.history);

            Assert.False(play.IsValid());
        }

        [Fact]
        public void ValidateLinesAboveTheLimit()
        {
            var lines = EnvironmentValues.MAXIMUM_LINES_VALUE + 1;
            var play = new Play("PlayNameTest", lines, PlayTypeEnum.history);

            Assert.False(play.IsValid());
        }

        [Fact]
        public void ValidateLinesBetweenTheLimit()
        {
            var lines = EnvironmentValues.MINIMUM_LINES_VALUE;
            var play = new Play("PlayNameTest", lines, PlayTypeEnum.history);

            Assert.True(play.IsValid());
        }
    }
}
