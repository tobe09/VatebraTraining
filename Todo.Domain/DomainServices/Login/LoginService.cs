using System;
using System.Collections.Generic;
using System.Text;
using Todo.Domain.DomainServices.Login.DataProviders;
using Todo.Domain.DomainServices.Login.Models;

namespace Todo.Domain.DomainServices.Login
{
    public class LoginService : ILoginService
    {
        private readonly ILoginDataProvider loginDataProvider;

        public LoginService(ILoginDataProvider loginDataProvider)
        {
            this.loginDataProvider = loginDataProvider;
        }

        public LoginResponseModel ValidateUser(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}