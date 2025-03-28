using TheatricalPlayers.Domain.Entidades;
using Xunit;

namespace TheatricalPlayersRefactoringKata.Tests.DomainTests
{
    public class StatementPlayTests
    {
        [Fact]
        public void ValidateStatementPlayCreation()
        {
            var statementId = 1;
            var customer = "InvoiceCostumerTest";
            var playAudiente = 1000;
            var playName = "PlayNameTest";
            var playLines = 1000;
            var playType = "tragedy";

            var statementPlay = new StatementPlay(statementId, customer, playAudiente, playName, playLines, playType);

            Assert.Equal(statementPlay.StatementId, statementId);
            Assert.Equal(statementPlay.Customer, customer);
            Assert.Equal(statementPlay.PlayAudience, playAudiente);
            Assert.Equal(statementPlay.PlayName, playName);
            Assert.Equal(statementPlay.PlayLines, playLines);
            Assert.Equal(statementPlay.PlayType, playType);
        }
    }
}
