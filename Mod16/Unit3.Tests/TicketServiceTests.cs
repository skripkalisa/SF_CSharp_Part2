using NUnit.Framework;

namespace Unit3.Tests
{
    [TestFixture]
    public class TicketServiceTests 
    {
        [Test]
        public void GeTicketPriceMustReturnNotNullableTicket() 
        {
            var ticketServiceTest = new TicketService();
            Assert.IsNotNull(ticketServiceTest.GetTicketPrice(1));
        }

        [Test]
        public void GeTicketPriceMustThrowException() 
        {
            var ticketServiceTest = new TicketService();
            Assert.Throws < TicketNotFoundException > (() => ticketServiceTest.GetTicketPrice(100));
        }

    }
}