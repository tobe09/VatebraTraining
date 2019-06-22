using System;
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
            bool isRegisteredUser = loginDataProvider.IsRegisteredUser(username, password);

            if (!isRegisteredUser)
                return new LoginResponseModel { ErrorMessage = "Invalid Username/password Combination!" };

            int userId = loginDataProvider.GetUserId(username);

            return new LoginResponseModel { UserId = userId, SuccessMessage = "Successful" };
        }
    }
}