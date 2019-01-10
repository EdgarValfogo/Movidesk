using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Movidesk.Business.Tickets
{
    public class TicketsBusiness : MovideskBusinessBase
    {
        public int CreateTicket(TicketModel newticket, bool returnAllProperties = false)
        {
            
        }

        public async Task<TicketModel> GetTicket(int id)
        {
            TicketModel ticket;

            //throw new NotImplementedException();
            HttpClient http = new HttpClient();
            Task response = http.GetAsync(connector.TicketsApiUrl() + "&id=" + id ).ContinueWith(
                (task) =>
                {
                    var _response = task.Result;
                    var jsonString = _response.Content.ReadAsStringAsync();
                    jsonString.Wait();
                    ticket = JsonConvert.DeserializeObject<TicketModel>(jsonString.Result);
                }
            );
            response.Wait();
            return new TicketModel();
        }

        public void UpdateTicket(int id, TicketModel ticketupdate)
        {
            throw new NotImplementedException();
        }
    }
}
