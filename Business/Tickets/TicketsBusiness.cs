using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Movidesk.Business.Tickets
{
    public class TicketsBusiness : MovideskBusinessBase, ITicketBusiness
    {
        public void CreateTicket(TicketModel newticket, bool returnAllProperties = false)
        {
            throw new NotImplementedException();
        }

        public async Task<TicketModel> GetTicket(int id)
        {
            //throw new NotImplementedException();
            HttpClient http = new HttpClient();
            HttpResponseMessage response = await http.GetAsync(connector.TicketsApiUrl());

            return new TicketModel();
        }

        public void UpdateTicket(int id, TicketModel ticketupdate)
        {
            throw new NotImplementedException();
        }
    }
}
