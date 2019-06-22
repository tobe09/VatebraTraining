using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todo.Domain.DomainServices.Todo;
using Todo.Domain.DomainServices.Todo.Models;
using Todo.MvcApplication.Constants;
using Todo.MvcApplication.Models;

namespace Todo.MvcApplication.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoService todoService;

        public TodoController(ITodoService todoService)
        {
            this.todoService = todoService;
        }

        public IActionResult Index()
        {
            int? userId = HttpContext.Session.GetInt32(TodoConstants.UserIdKey);

            var todos = todoService.GetAllTodos(userId.Value);

            IEnumerable<TodoViewModel> todoViewModels = todos.Select(x => new TodoViewModel
            {
                Id = x.Id,
                UserId = x.UserId,
                Title = x.Title,
                Description = x.Description,
                DateAdded = x.DateAdded,
                DateToCommence = x.DateToCommence
            });

            return View(todoViewModels);
        }

        public IActionResult Create()
        {
            return View(new TodoViewModel());
        }

        [HttpPost]
        public IActionResult Create(TodoViewModel todoViewModel)
        {
            int? userId = HttpContext.Session.GetInt32(TodoConstants.UserIdKey);

            var todo = new TodoEntity
            {
                UserId = userId.Value,
                Title = todoViewModel.Title,
                Description = todoViewModel.Description,
                DateAdded = todoViewModel.DateAdded,
                DateToCommence = todoViewModel.DateToCommence
            };

            todoService.CreateTodo(todo);

            todoViewModel.SuccessMessage = "Todo Created Successfully";

            return View(todoViewModel);
        }

        public IActionResult Edit(int id)
        {
            var todo = todoService.GetTodo(id);

            var todoViewModel = new TodoViewModel
            {
                Id = todo.Id,
                UserId = todo.UserId,
                Title = todo.Title,
                Description = todo.Description,
                DateAdded = todo.DateAdded,
                DateToCommence = todo.DateToCommence
            };

            return View(todoViewModel);
        }

        [HttpPost]
        public IActionResult Edit(TodoViewModel todoViewModel)
        {
            var todoEntity = new TodoEntity
            {
                Id = todoViewModel.Id,
                UserId = todoViewModel.UserId,
                Title = todoViewModel.Title,
                Description = todoViewModel.Description,
                DateAdded = todoViewModel.DateAdded,
                DateToCommence = todoViewModel.DateToCommence
            };

            todoService.UpdateTodo(todoEntity);

            todoViewModel.SuccessMessage = "Successfully Updated Todo. Title: " + todoViewModel.Title;

            return View(todoViewModel);
        }

        public IActionResult Details(int id)
        {
            var todo = todoService.GetTodo(id);

            var todoViewModel = new TodoViewModel
            {
                Id = todo.Id,
                UserId = todo.UserId,
                Title = todo.Title,
                Description = todo.Description,
                DateAdded = todo.DateAdded,
                DateToCommence = todo.DateToCommence
            };

            return View(todoViewModel);
        }

        public IActionResult Delete(int id)
        {
            todoService.DeleteTodo(id);

            return RedirectToAction("Index");
        }
    }
}