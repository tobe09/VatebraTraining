using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public bool EmailAddressExists(string emailAddress)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public bool UsernameExists(string username)
        {
            throw new NotImplementedException();
        }
    }
}