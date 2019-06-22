using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todo.Domain.DomainServices.Login;
using Todo.MvcApplication.Constants;
using Todo.MvcApplication.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Todo.MvcApplication.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginService loginService;

        public LoginController(ILoginService loginService)
        {
            this.loginService = loginService;
        }

        public IActionResult Index(LoginViewModel loginViewModel)
        {
            return View(loginViewModel);
        }

        [HttpPost]
        public IActionResult DoLogin(LoginViewModel loginViewModel)
        {
            var loginResponseModel = loginService.ValidateUser(loginViewModel.Username, loginViewModel.Password);
            
            if (loginResponseModel.HasError())
            {
                loginViewModel.ErrorMessage = loginResponseModel.ErrorMessage;
                return View("Index", loginViewModel);
            }

            HttpContext.Session.SetInt32(TodoConstants.UserIdKey, loginResponseModel.UserId);
            HttpContext.Session.SetString(TodoConstants.UsernameKey, loginViewModel.Username);
            HttpContext.Session.SetString(TodoConstants.PasswordKey, loginViewModel.Password);
            HttpContext.Session.SetInt32(TodoConstants.IsLoggedin, TodoConstants.LoggedInValue);

            return RedirectToAction("Index", "Todo");
        }

        public IActionResult DoLogOut()
        {
            HttpContext.Session.Remove(TodoConstants.UsernameKey);
            HttpContext.Session.Remove(TodoConstants.PasswordKey);
            HttpContext.Session.SetInt32(TodoConstants.IsLoggedin, TodoConstants.LoggedOutValue);

            return RedirectToAction("Index");
        }
    }
}
