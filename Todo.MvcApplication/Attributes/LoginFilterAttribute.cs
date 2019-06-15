using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Http;
using Todo.MvcApplication.Constants;
using System.Linq;

namespace Todo.MvcApplication.Attributes
{
    public class LoginFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            bool isLoggedIn = filterContext.HttpContext.Session.IsLoggedIn();

            string[] allowedPages = new[] { "Login", "Register" };
            string controllerName = (string)filterContext.RouteData.Values.Values.First();

            if (isLoggedIn || allowedPages.Any(x => x == controllerName))
            {
                base.OnActionExecuting(filterContext);
            }
            else
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary { { "controller", "Login" }, { "action", "Index" }
                    });
            }
        }
    }
}