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
        public PersonModel CreatedBy { get; set; }
    }
}
