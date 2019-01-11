using Movidesk.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movidesk.Business.Tickets
{
    public class TicketModel
    {
        public Nullable<int> Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public Nullable<DateTime> CreatedDate { get; set; }
        public string Justification { get; set; }
        public Nullable<int> Type { get; set; }
        public string Urgency { get; set; }
        public Nullable<int> IsVisible { get; set; }
        public Nullable<int> ParentServiceId { get; set; }
        public Nullable<int> ServiceForTicketType { get; set; }
        public Nullable<int> Origin = 9; // Origin for Web API value
        public List<string> ServiceFull { get; set; }
        public Nullable<int> ServiceFirstLevelId { get; set; }
        public string ServiceFirstLevel { get; set; }
        public string ServiceSecondLevel { get; set; }
        public string ServiceThirdLevel { get; set; }
        public string OwnerTeam { get; set; }
        public PersonModel CreatedBy { get; set; }
        public PersonModel Owner { get; set; }
        public List<string> Tags { get; set; }
        public Nullable<int> ActionCount { get; set; }
        public List<ActionModel> Actions { get; set; }
        public List<PersonModel> Clients { get; set; }
        public List<CustomFieldValuesModel> CustomFieldValues { get; set; }
    }
}
