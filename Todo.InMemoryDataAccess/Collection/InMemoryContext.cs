using System;
using System.Collections.Generic;
using Todo.Domain.DomainServices.Register.Models;
using Todo.Domain.DomainServices.Todo.Models;

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
                        new User { Id = 1, Username = "Admin", Password = "admin", PhoneNumber = 08066002123,
                            EmailAddress  = "Admin@yahoo.com" },
                        new User { Id = 2, Username = "Tayo",Password = "tayo", PhoneNumber = 08136002123,
                            EmailAddress  = "Tayo@yahoo.com" },
                        new User { Id = 3, Username = "Abbey",Password = "abbey", PhoneNumber = 08136229423,
                            EmailAddress  = "Abbey@yahoo.com" }
                    };
                }

                return users;
            }
        }

        private static List<Todos> todoEntities;

        public static List<Todos> TodoEntities
        {
            get
            {
                if (todoEntities == null)
                {
                    todoEntities = new List<Todos>
                    {
                        new Todos{ Id = 1, UserId=2 ,Title="Buy Watch", Description="I want to buy a watch",
                            DateAdded =DateTime.Now,DateToCommence=new DateTime(2019, 7,12)},
                        new Todos{ Id = 2, UserId=2 ,Title="Buy Gas", Description="I want to buy a gas",
                            DateAdded =DateTime.Now,DateToCommence=new DateTime(2019, 7,12)},
                        new Todos{ Id = 3, UserId=2 ,Title="Buy Shoe", Description="I want to buy a shoe",
                            DateAdded =DateTime.Now,DateToCommence=new DateTime(2019, 7,12)},
                        new Todos{ Id = 4, UserId=3 ,Title="Buy Gas", Description="I want to buy a gas",
                            DateAdded =DateTime.Now,DateToCommence=new DateTime(2019, 7,12)},
                        new Todos{ Id = 5, UserId=3 ,Title="Buy Shoe", Description="I want to buy a shoe",
                            DateAdded =DateTime.Now,DateToCommence=new DateTime(2019, 7,12)}
                    };
                }

                return todoEntities;
            }
        }
    }
}