using Todo.Domain.DomainServices.Login;
using Todo.Domain.DomainServices.Login.DataProviders;
using Todo.Domain.DomainServices.Register;
using Todo.Domain.DomainServices.Register.DataProviders;
using Todo.Domain.DomainServices.Todo;
using Todo.Domain.DomainServices.Todo.DataProviders;
using Todo.EntityFrameworkDataProvider.DataProviders.Login;
using Todo.EntityFrameworkDataProvider.DataProviders.Register;
using Todo.EntityFrameworkDataProvider.DataProviders.Todo;
//using Todo.InMemoryDataProvider.DataProviders.Login;
//using Todo.InMemoryDataProvider.DataProviders.Register;
//using Todo.InMemoryDataProvider.DataProviders.Todo;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceRegistration
    {
        public static void AddTodoServices(this IServiceCollection services)
        {
            services.AddTransient<IRegisterService, RegisterService>();
            services.AddTransient<IRegisterDataProvider, RegisterDataProvider>();

            services.AddTransient<ILoginService, LoginService>();
            services.AddTransient<ILoginDataProvider, LoginDataProvider>();

            services.AddTransient<ITodoService, TodoService>();
            services.AddTransient<ITodoDataProvider, TodoDataProvider>();
        }
    }
}