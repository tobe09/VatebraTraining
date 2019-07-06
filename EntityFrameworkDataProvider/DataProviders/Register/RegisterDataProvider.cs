using System;
using System.Collections.Generic;
using System.Linq;
using Todo.Domain.DomainServices.Register.DataProviders;
using Todo.Domain.DomainServices.Register.Models;
using Todo.EntityFrameworkDataProvider.Collection;

namespace Todo.EntityFrameworkDataProvider.DataProviders.Register
{
    public class RegisterDataProvider : IRegisterDataProvider
    {
        private readonly TodoDbContext todoDbContext;

        public RegisterDataProvider(TodoDbContext todoDbContext)
        {
            this.todoDbContext = todoDbContext;
        }

        public void AddUser(User user)
        {
            UserEntity userEntity = new UserEntity
            {
                EmailAddress = user.EmailAddress,
                Password = user.Password,
                Username = user.Username,
                PhoneNumber = user.PhoneNumber
            };

            todoDbContext.Users.Add(userEntity);
            todoDbContext.SaveChanges();
        }

        public bool EmailAddressExists(string emailAddress)
        {
            bool emailExists = todoDbContext.Users.Any(x => x.EmailAddress.Equals(emailAddress, StringComparison.OrdinalIgnoreCase));
            return emailExists;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return todoDbContext.Users.Select(x => new User
            {
                Id = x.Id,
                EmailAddress = x.EmailAddress,
                Password = x.Password,
                PhoneNumber = x.PhoneNumber,
                Username = x.Username
            });
        }

        public bool UsernameExists(string username)
        {
            bool usernameExists = todoDbContext.Users.Any(x => x.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
            return usernameExists;
        }
    }
}