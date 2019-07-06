using System.Collections.Generic;
using Todo.Domain.DomainServices.Todo.Models;

namespace Todo.Domain.DomainServices.Todo.DataProviders
{
    public interface ITodoDataProvider
    {
        IEnumerable<Todos> GetAllTodos(int userId);
        Todos GetTodo(int id);
        void CreateTodo(Todos todo);
        void UpdateTodo(Todos todo);
        void DeleteTodo(int id);
    }
}
