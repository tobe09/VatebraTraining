using System;
using Todo.Domain.DomainServices.Common;

namespace Todo.Domain.DomainServices.Todo.Models
{
    public class TodoEntity: BaseEntity
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateToCommence { get; set; }
    }
}
