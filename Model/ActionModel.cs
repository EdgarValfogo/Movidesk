using System;
using System.Collections.Generic;
using System.Text;

namespace Movidesk.Model
{
    public class ActionModel
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public int Origin { get; set; }
        public string Description { get; set; }
        public string HtmlDescription { get; set; }
        public PersonModel CreatedBy = new PersonModel();
    }
}
