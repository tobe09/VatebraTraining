using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Domain.DomainServices.Register.Models
{
    public class User
    {
        public string EmailAddress { get; set; }
        public long? PhoneNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}