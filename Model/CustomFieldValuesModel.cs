using System;
using System.Collections.Generic;
using System.Text;

namespace Movidesk.Model
{
    public class CustomFieldValuesModel
    {
        public int CustomFieldId { get; set; }
        public int CustomFieldRuleId { get; set; }
        public int Line { get; set; }
        public string Value { get; set; }
        public List<CustomFieldItemModel> Items = new List<CustomFieldItemModel>();
    }
}
