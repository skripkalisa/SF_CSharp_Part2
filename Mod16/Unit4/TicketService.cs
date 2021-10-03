using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit4
{
    public class TicketNotFoundException: Exception 
    {   
    }
    public class TicketService: ITicketService 
    {  
        public Ticket GetTicket(int ticketId) {
            var ticket = FakeBaseData.FirstOrDefault(t => t.Id == ticketId);
            return (ticket is null) ?
                throw new TicketNotFoundException(): ticket;
        }
        public int GetTicketPrice(int ticketId) 
        {
            var ticket = FakeBaseData.FirstOrDefault(t => t.Id == ticketId);
            return (ticket is null) ?
                throw new TicketNotFoundException(): ticket.Id;
        }
        private IEnumerable < Ticket > FakeBaseData 
        {
            get {
                return new List < Ticket > 
                {
                    new Ticket(1, "Москва - Санкт-Петербург", 3500),
                    new Ticket(2, "Челябинск - Магадан", 3500),
                    new Ticket(3, "Норильск - Уфа", 3500)
                };
            }
        }

    }

}