using TheatricalPlayers.Domain.Entidades;
using Xunit;

namespace TheatricalPlayersRefactoringKata.Tests.DomainTests
{
    public class StatementTests
    {
        [Fact]
        public void ValidateStatementCreation()
        {
            var content = "ContentTest";

            var statement = new Statement(content);

            Assert.Equal(statement.Content, content);
        }
    }
}
