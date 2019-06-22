using System;
using System.Linq;
using Todo.Domain.DomainServices.Login.DataProviders;
using Todo.InMemoryDataProvider.Collection;

namespace Todo.InMemoryDataProvider.DataProviders.Login
{
    public class LoginDataProvider : ILoginDataProvider
    {
        public int GetUserId(string username)
        {
            var user = InMemoryContext.Users.First(x => x.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            return user.Id;
        }

        public bool IsRegisteredUser(string username, string password)
        {
            bool isRegistered = InMemoryContext.Users.Any(x =>
             x.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && x.Password.Equals(password));

            return isRegistered;
        }
    }
}
