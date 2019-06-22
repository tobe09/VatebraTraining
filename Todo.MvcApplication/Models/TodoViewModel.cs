using System;

namespace Todo.MvcApplication.Models
{
    public class TodoViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateToCommence { get; set; }
    }
}
