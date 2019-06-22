using Todo.Domain.DomainServices.Common;

namespace Todo.Domain.DomainServices.Register.Models
{
    public class User:  BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public long? PhoneNumber { get; set; }
    }
}