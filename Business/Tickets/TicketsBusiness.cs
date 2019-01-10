using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Movidesk.Business.Tickets
{
    public class TicketsBusiness : MovideskBusinessBase
    {
        public async Task<int> CreateTicket(TicketModel newticket, bool returnAllProperties = true)
        {
            int Result = 0;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );

            string jsonTicket = JsonConvert.SerializeObject(newticket);
            var content = new StringContent( jsonTicket, Encoding.UTF8, "application/json");
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage result = await client.PostAsync( connector.TicketsApiUrl() + "&returnAllProperties=" + returnAllProperties, content);
            string contents = await result.Content.ReadAsStringAsync();

            if ( !result.IsSuccessStatusCode )
            {
                throw new Exception(contents);
            }

            //Result = Convert.ToInt32( JObject.Parse(contents)["id"] );
            TicketModel tempResult = JsonConvert.DeserializeObject<TicketModel>(contents);

            return Result;
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
