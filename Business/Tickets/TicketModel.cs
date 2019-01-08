using System;
using System.Collections.Generic;
using System.Text;

namespace Movidesk.Business.Tickets
{
    public class TicketModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ParentServiceId { get; set; }
        public int ServiceForTicketType { get; set; }
    }
}
