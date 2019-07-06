using System;
using System.Collections.Generic;
using System.Linq;
using Todo.Domain.DomainServices.Todo.DataProviders;
using Todo.Domain.DomainServices.Todo.Models;
using Todo.InMemoryDataProvider.Collection;

namespace Todo.InMemoryDataProvider.DataProviders.Todo
{
    public class TodoDataProvider : ITodoDataProvider
    {
        public void CreateTodo(Todos todo)
        {
            int maxId = InMemoryContext.TodoEntities.Max(x => x.Id);

            todo.Id = maxId + 1;

            InMemoryContext.TodoEntities.Add(todo);
        }

        public void DeleteTodo(int id)
        {
            var todo = InMemoryContext.TodoEntities.FirstOrDefault(x => x.Id == id);
            if (todo == null)
                throw new ArgumentException($"Todo with Id value {id} does not exist!");

            InMemoryContext.TodoEntities.Remove(todo);
        }

        public IEnumerable<Todos> GetAllTodos(int userId)
        {
            if (userId == 1)
                return InMemoryContext.TodoEntities;

            return InMemoryContext.TodoEntities.Where(x => x.UserId == userId);
        }

        public Todos GetTodo(int id)
        {
            return InMemoryContext.TodoEntities.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateTodo(Todos todo)
        {
            var oldTodo = InMemoryContext.TodoEntities.FirstOrDefault(x => x.Id == todo.Id);
            if (oldTodo == null)
                throw new Exception($"Todo Id {todo.Id} does not exist!");

            oldTodo.Title = todo.Title;
            oldTodo.Description = todo.Description;
            oldTodo.DateToCommence = todo.DateToCommence;
        }
    }
}