using Todo.Domain.DomainServices.Login.Models;

namespace Todo.Domain.DomainServices.Login
{
    public interface ILoginService
    {
        LoginResponseModel ValidateUser(string username, string password);
    }
}