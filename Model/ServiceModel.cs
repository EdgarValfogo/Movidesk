using System;
using System.Collections.Generic;
using System.Text;

namespace Movidesk.Model
{
    public class ServiceModel
    {
        public Nullable<int> Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> ParentServiceId { get; set; }
        public IEnumerable<ServiceForTicketTypeEnum> ServiceForTicketType { get; set; }
        public IEnumerable<IsVisibleEnum> IsVisible { get; set; }
        public IEnumerable<AllowSelectionEnum> AllowSelection { get; set; }
        public bool AllowFinishTicket { get; set; }
        public string AutomationMacro { get; set; }
        public string DefaultCategory { get; set; }
        public string DefaultUrgency { get; set; }
        public bool AllowAllCategories { get; set; }
        public string Categories { get; set; }
    }

    public enum ServiceForTicketTypeEnum
    {
        Public = 0,
        Intern = 1,
        Both = 2
    }

    public enum AllowSelectionEnum
    {
        Agent = 1,
        Client = 2,
        Both = 3
    }
    
    public enum IsVisibleEnum
    {
        Agent = 1,
        Client = 2,
        Both = 3
    }
}
