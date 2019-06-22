using System.Collections.Generic;
using Todo.Domain.DomainServices.Common.Models;
using Todo.Domain.DomainServices.Register.DataProviders;
using Todo.Domain.DomainServices.Register.Models;

namespace Todo.Domain.DomainServices.Register
{
    public class RegisterService : IRegisterService
    {
        private readonly IRegisterDataProvider registerDataAccess;

        public RegisterService(IRegisterDataProvider registerDataAccess)
        {
            this.registerDataAccess = registerDataAccess;
        }

        public GenericResponseModel PerformRegistration(User user)
        {
            bool emailExists = registerDataAccess.EmailAddressExists(user.EmailAddress);
            if (emailExists)
                return new GenericResponseModel { ErrorMessage = "Email Address Exists" };

            bool usernameExists = registerDataAccess.UsernameExists(user.Username);
            if (usernameExists)
                return new GenericResponseModel { ErrorMessage = "Username Already Assigned" };

            registerDataAccess.AddUser(user);

            return new GenericResponseModel { SuccessMessage = $"User {user.Username} Successfully Created" };
        }

        public IEnumerable<User> GetAllUsers()
        {
            var allUsers = registerDataAccess.GetAllUsers();
            return allUsers;
        }
    }
}