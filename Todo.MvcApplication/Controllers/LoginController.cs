using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todo.MvcApplication.Constants;
using Todo.MvcApplication.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Todo.MvcApplication.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index(LoginViewModel loginViewModel)
        {
            return View(loginViewModel);
        }

        [HttpPost]
        public IActionResult DoLogin(LoginViewModel loginViewModel)
        {
            bool isLoggedIn = false;
            loginViewModel.ErrorMessage = "Invalid Username/Password Combination";

            if (isLoggedIn)
                return RedirectToAction("Index", "Todo");
            else
                return View("Index", loginViewModel);
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
