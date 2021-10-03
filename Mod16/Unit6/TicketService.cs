using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit6
{    public class TicketNotFoundException: Exception 
    {   
    }
    public class TicketService: ITicketService 
    {
        public int GetTicketPrice(int ticketId) {
            var ticket = FakeBaseData.FirstOrDefault(t => t.Id == ticketId);
            return ticket?.Id ?? throw new TicketNotFoundException();
        }

        public Ticket GetTicket(int ticketId) 
        {
            var ticket = FakeBaseData.FirstOrDefault(t => t.Id == ticketId);
            return ticket ?? throw new TicketNotFoundException();
        }

        public void SaveTicket(Ticket ticket) 
        {
            FakeBaseData.Add(ticket);
        }

        private void DeleteTicket(Ticket ticket) 
        {
            FakeBaseData.Remove(ticket);
        }

        public IEnumerable < Ticket > GetAllTickets() 
        {
            return FakeBaseData;
        }

        private List < Ticket > FakeBaseData = new List < Ticket > 
        {
            new Ticket(1, "Москва - Санкт-Петербург", 3500),
            new Ticket(2, "Челябинск - Магадан", 3500),
            new Ticket(3, "Норильск - Уфа", 3500)
        };
    }
}