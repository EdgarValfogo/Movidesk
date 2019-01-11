using System;
using System.Collections.Generic;
using System.Text;

namespace Movidesk.Model
{
    public class PersonModel
    {
        public Nullable<int> Id { get; set; }
        public Nullable<int> PersonType { get; set; }
        public string BusinessName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Complement { get; set; }
        public string Cep { get; set; }
        public string City { get; set; }
        public string Bairro { get; set; }
        public string Number { get; set; }
        public string Reference { get; set; }
    }
}
