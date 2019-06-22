using Todo.Domain.DomainServices.Common.Models;

namespace Todo.Domain.DomainServices.Login.Models
{
    public class LoginResponseModel : GenericResponseModel
    {
        public bool LoginSuccessful { get; set; }
        public int UserId { get; set; }
    }
}