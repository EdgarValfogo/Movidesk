using System;
using System.Net.Http;

namespace Movidesk
{
    public class MovideskConnector
    {
        private string ApiAccessToken = "SEUTOKEN";
        private string ApiBaseUrl = "https://api.movidesk.com/public/v1";

        private string ApiUrl(string _type) { return ApiBaseUrl + "/" + _type; }

        public string TicketsApiUrl() { return ApiUrl("tickets") + "?token=" + ApiAccessToken; }
        public string ServicesApiUrl() { return ApiUrl("services") + "?token=" + ApiAccessToken; }
    }
}
