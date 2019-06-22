using System.Collections.Generic;
using Todo.Domain.DomainServices.Todo.Models;

namespace Todo.Domain.DomainServices.Todo.DataProviders
{
    public interface ITodoDataProvider
    {
        IEnumerable<TodoEntity> GetAllTodos(int userId);
        TodoEntity GetTodo(int id);
        void CreateTodo(TodoEntity todo);
        void UpdateTodo(TodoEntity todo);
        void DeleteTodo(int id);
    }
}
