using System.Collections.Generic;
using Todo.Domain.DomainServices.Register.Models;

namespace Todo.Domain.DomainServices.Register.DataProviders
{
    public interface IRegisterDataProvider
    {
        bool EmailAddressExists(string emailAddress);
        bool UsernameExists(string username);
        void AddUser(User user);
        IEnumerable<User> GetAllUsers();
    }
}