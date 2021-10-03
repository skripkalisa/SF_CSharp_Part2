using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using CollectionAssert = NUnit.Framework.CollectionAssert;

namespace Unit6.Tests
{
    [TestFixture]
    public class TicketServiceIntegrationTests 
    {
        [Test]
        public void SaveTicketMustAddTicketInBase() 
        {
            var ticketServiceTest = new TicketService();
            var newTicket = new Ticket(300, "Test ticket", 1000);

            ticketServiceTest.SaveTicket(newTicket);

            var allTicketsAfterAddingNewTicket = ticketServiceTest.GetAllTickets();
            CollectionAssert.Contains(allTicketsAfterAddingNewTicket, newTicket);

            PrivateObject obj = new PrivateObject(ticketServiceTest);

            obj.Invoke("DeleteTicket", newTicket);

            var allTicketsAfterDeletingNewTicket = ticketServiceTest.GetAllTickets();
            CollectionAssert.DoesNotContain(allTicketsAfterDeletingNewTicket, newTicket);
        }
    }
}