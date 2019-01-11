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
        private bool CheckTicketRequirements( TicketModel ticket )
        {
            List<string> errors = new List<string>();
            if( ticket.Type == 0 )
            {
                errors.Add("Type must be set");
            }

            if( ticket.CreatedBy == null )
            {
                errors.Add("Created by must be set");
            }

            if( ticket.Clients == null )
            {
                errors.Add("Clients must be set");
            }

            if( ticket.Actions == null )
            {
                errors.Add("Actions must be set");
            }
            
            if( errors.Count > 0 )
            {
                throw new Exception( "Errors on ticket:\n\n" + string.Join("\n", errors));
            }
            return true;
        }

        public async Task<TicketModel> CreateTicket(TicketModel newticket )
        {
            try
            {
                CheckTicketRequirements(newticket);

                bool returnAllProperties = true;
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                    );

                string jsonTicket = JsonConvert.SerializeObject(
                    newticket,
                    new Newtonsoft.Json.JsonSerializerSettings{
                         NullValueHandling = NullValueHandling.Ignore
                    }
                    );
                var content = new StringContent(jsonTicket, Encoding.UTF8, "application/json");
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                HttpResponseMessage result = await client.PostAsync(connector.TicketsApiUrl() + "&returnAllProperties=" + returnAllProperties, content);
                string contents = await result.Content.ReadAsStringAsync();

                if (!result.IsSuccessStatusCode)
                {
                    throw new Exception(contents + ":||:" + jsonTicket);
                }

                //Result = Convert.ToInt32( JObject.Parse(contents)["id"] );
                TicketModel tempResult = JsonConvert.DeserializeObject<TicketModel>(contents);

                return tempResult;
            } catch( Exception e )
            {
                throw e;
            }
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
