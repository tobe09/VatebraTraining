using System.Collections.Generic;
using System.Linq;
using Todo.Domain.DomainServices.Register.DataProviders;
using Todo.Domain.DomainServices.Register.Models;
using Todo.InMemoryDataProvider.Collection;

namespace Todo.InMemoryDataProvider.DataProviders.Register
{
    public class RegisterDataProvider : IRegisterDataProvider
    {
        public void AddUser(User user)
        {
            int maxId = InMemoryContext.Users.Max(x => x.Id);

            user.Id = maxId + 1;

            InMemoryContext.Users.Add(user);
        }

        public bool EmailAddressExists(string emailAddress)
        {
            return InMemoryContext.Users.Any(x => x.EmailAddress.Equals(emailAddress, System.StringComparison.OrdinalIgnoreCase));
        }

        public bool UsernameExists(string username)
        {
            return InMemoryContext.Users.Any(x => x.Username.Equals(username, System.StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<User> GetAllUsers()
        {
            return InMemoryContext.Users;
        }
    }
}