using System;
using System.Collections.Generic;
using Todo.Domain.DomainServices.Todo.DataProviders;
using Todo.Domain.DomainServices.Todo.Models;
using Todo.EntityFrameworkDataProvider.Collection;
using System.Linq;

namespace Todo.EntityFrameworkDataProvider.DataProviders.Todo
{
    public class TodoDataProvider : ITodoDataProvider
    {
        private readonly TodoDbContext todoDbContext;

        public TodoDataProvider(TodoDbContext todoDbContext)
        {
            this.todoDbContext = todoDbContext;
        }

        public void CreateTodo(Todos todo)
        {
            TodoEntity todoEntity = new TodoEntity
            {
                DateAdded = todo.DateAdded,
                DateToCommence = todo.DateToCommence,
                Description = todo.Description,
                Title = todo.Title,
                UserId = todo.UserId
            };

            todoDbContext.TodoEntities.Add(todoEntity);
            todoDbContext.SaveChanges();
        }

        public void DeleteTodo(int id)
        {
            TodoEntity todoEntity = todoDbContext.TodoEntities.First(x => x.Id == id);
            todoDbContext.TodoEntities.Remove(todoEntity);
            todoDbContext.SaveChanges();
        }

        public IEnumerable<Todos> GetAllTodos(int userId)
        {
            return todoDbContext.TodoEntities.Select(x => new Todos
            {
                Id = x.Id,
                DateAdded = x.DateAdded,
                DateToCommence = x.DateToCommence,
                Description = x.Description,
                Title = x.Title,
                UserId = x.UserId
            });
        }

        public Todos GetTodo(int id)
        {
            TodoEntity todoEntity = todoDbContext.TodoEntities.First(x => x.Id == id);

            return new Todos
            {
                Id = todoEntity.Id,
                DateAdded = todoEntity.DateAdded,
                DateToCommence = todoEntity.DateToCommence,
                Description = todoEntity.Description,
                Title = todoEntity.Title,
                UserId = todoEntity.UserId
            };
        }

        public void UpdateTodo(Todos todo)
        {
            TodoEntity todoEntity = todoDbContext.TodoEntities.First(x => x.Id == todo.Id);
            todoEntity.Title = todo.Title;
            todoEntity.Description = todo.Description;
            todoEntity.DateToCommence = todo.DateToCommence;

            todoDbContext.TodoEntities.Update(todoEntity);
            todoDbContext.SaveChanges();
        }
    }
}
