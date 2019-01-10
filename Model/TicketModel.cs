﻿using Movidesk.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movidesk.Business.Tickets
{
    public class TicketModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public int Type { get; set; }
        public string Urgency { get; set; }
        public int IsVisible { get; set; }
        public int ParentServiceId { get; set; }
        public int ServiceForTicketType { get; set; }
        public int Origin = 9; // Origin for Web API value
        public List<string> ServiceFull = new List<string>();
        public int ServiceFirstLevelId { get; set; }
        public string ServiceFirstLevel { get; set; }
        public string ServiceSecondLevel { get; set; }
        public string ServiceThirdLevel { get; set; }
        public string OwnerTeam { get; set; }
        public PersonModel CreatedBy = new PersonModel();
        public List<string> Tags = new List<string>();
        public int ActionCount { get; set; }
        public List<ActionModel> Actions = new List<ActionModel>();
        public List<PersonModel> Clients = new List<PersonModel>();
    }
}
