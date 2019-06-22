using System;
using System.Linq;
using Todo.Domain.DomainServices.Login.DataProviders;
using Todo.EntityFrameworkDataProvider.Collection;

namespace Todo.EntityFrameworkDataProvider.DataProviders.Login
{
    public class LoginDataProvider : ILoginDataProvider
    {
        private readonly TodoDbContext todoDbContext;

        public LoginDataProvider(TodoDbContext todoDbContext)
        {
            this.todoDbContext = todoDbContext;
        }

        public int GetUserId(string username)
        {
            var user = todoDbContext.Users.First(x => x.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            return user.Id;
        }

        public bool IsRegisteredUser(string username, string password)
        {
            bool isRegisteredUser = todoDbContext.Users.Any(x => x.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && x.Password.Equals(password));

            return isRegisteredUser;
        }
    }
}