using System;
using System.Collections.Generic;
using Todo.Domain.DomainServices.Todo.DataProviders;
using Todo.Domain.DomainServices.Todo.Models;

namespace Todo.Domain.DomainServices.Todo
{
    public class TodoService : ITodoService
    {
        private readonly ITodoDataProvider todoDataProvider;

        public TodoService(ITodoDataProvider todoDataProvider)
        {
            this.todoDataProvider = todoDataProvider;
        }

        public void CreateTodo(Todos todo)
        {
            todo.DateAdded = DateTime.Now;
            todoDataProvider.CreateTodo(todo);
        }

        public void DeleteTodo(int id)
        {
            todoDataProvider.DeleteTodo(id);
        }

        public IEnumerable<Todos> GetAllTodos(int userId)
        {
            return todoDataProvider.GetAllTodos(userId);
        }

        public Todos GetTodo(int id)
        {
            return todoDataProvider.GetTodo(id);
        }

        public void UpdateTodo(Todos todo)
        {
            todoDataProvider.UpdateTodo(todo);
        }
    }
}
