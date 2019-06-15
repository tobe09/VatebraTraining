using System.Collections.Generic;
using Todo.Domain.DomainServices.Register.Models;

namespace Todo.InMemoryDataProvider.Collection
{
    internal class InMemoryContext
    {
        private static List<User> users;

        public static List<User> Users
        {
            get
            {
                if (users == null)
                {
                    users = new List<User>
                    {
                        new User {Username = "Admin", Password = "admin", PhoneNumber = 08066002123, EmailAddress  = "Admin@yahoo.com" },
                        new User { Username = "Tayo",Password = "tayo", PhoneNumber = 08136002123, EmailAddress  = "Tayo@yahoo.com" },
                        new User { Username = "Abbey",Password = "abbey", PhoneNumber = 08136229423, EmailAddress  = "Abbey@yahoo.com" }
                    };
                }

                return users;
            }
        }
    }
}