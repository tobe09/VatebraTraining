namespace Todo.Domain.DomainServices.Common.Models
{
    public class GenericResponseModel
    {
        public string ErrorMessage { get; set; }
        public string SuccessMessage { get; set; }

        public bool HasError()
        {
            return !string.IsNullOrEmpty(ErrorMessage);
        }
    }
}