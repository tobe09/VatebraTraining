using Todo.MvcApplication.Constants;

namespace Microsoft.AspNetCore.Http
{
    public static class SessionExtensions
    {
        public static bool IsLoggedIn(this ISession session)
        {
            int? loggedInValue = session.GetInt32(TodoConstants.IsLoggedin);

            return loggedInValue == TodoConstants.LoggedInValue;
        }

        public static bool IsAdmin(this ISession session)
        {
            string username = session.GetString(TodoConstants.UsernameKey);

            return username?.ToLower() == "admin";
        }
    }
}