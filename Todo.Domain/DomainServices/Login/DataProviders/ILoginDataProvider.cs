namespace Todo.Domain.DomainServices.Login.DataProviders
{
    public interface ILoginDataProvider
    {
        bool IsRegisteredUser(string username, string password);
        int GetUserId(string username);
    }
}