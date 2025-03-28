using System.Collections.Generic;
using System.Linq;
using TheatricalPlayers.Domain.Entidades;
using Xunit;

namespace TheatricalPlayersRefactoringKata.Tests.DomainTests
{
    public class InvoiceTests
    {
        [Fact]
        public void ValidateInvoiceCreation()
        {
            var customer = "InvoiceCostumerTest";
            var performances = new List<Performance>() { new Performance("test", 4000) };

            var invoice = new Invoice(customer, performances);

            Assert.Equal(invoice.Customer, customer);
            Assert.Equal(invoice.Performances.First().PlayId, performances.First().PlayId);
            Assert.Equal(invoice.Performances.First().Audience, performances.First().Audience);
        }
    }
}
