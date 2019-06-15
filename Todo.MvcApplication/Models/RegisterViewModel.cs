namespace Todo.MvcApplication.Models
{
    public class RegisterViewModel: BaseViewModel
    {
        public string EmailAddress { get; set; }
        public long? PhoneNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
