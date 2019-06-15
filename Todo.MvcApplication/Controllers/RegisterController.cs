using Microsoft.AspNetCore.Mvc;
using Todo.Domain.DomainServices.Common.Models;
using Todo.Domain.DomainServices.Register;
using Todo.Domain.DomainServices.Register.Models;
using Todo.MvcApplication.Models;

namespace Todo.MvcApplication.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IRegisterService registerService;

        public RegisterController(IRegisterService registerService)
        {
            this.registerService = registerService;
        }

        public ActionResult Index(RegisterViewModel registerViewModel)
        {
            return View(registerViewModel);
        }

        [HttpPost]
        public ActionResult PerformRegistration(RegisterViewModel registerViewModel)
        {
            User user = new User
            {
                EmailAddress = registerViewModel.EmailAddress,
                PhoneNumber = registerViewModel.PhoneNumber,
                Username = registerViewModel.Username,
                Password = registerViewModel.Password
            };

            GenericResponseModel responseModel = registerService.PerformRegistration(user);

            if (responseModel.HasError())
                registerViewModel.ErrorMessage = responseModel.ErrorMessage;
            else
                registerViewModel.SuccessMessage = responseModel.SuccessMessage;

            return View("Index", registerViewModel);
        }

        public ActionResult ListUsers()
        {
            var allUsers = registerService.GetAllUsers();
            return View(allUsers);
        }
    }
}