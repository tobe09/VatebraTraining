using System.Collections.Generic;
using Todo.Domain.DomainServices.Common.Models;
using Todo.Domain.DomainServices.Register.Models;

namespace Todo.Domain.DomainServices.Register
{
    public interface IRegisterService
    {
        GenericResponseModel PerformRegistration(User user);
        IEnumerable<User> GetAllUsers();
    }
}