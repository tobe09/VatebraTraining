using Todo.Domain.DomainServices.Register;
using Todo.Domain.DomainServices.Register.DataProviders;
using Todo.InMemoryDataProvider.DataProviders.Register;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceRegistration
    {
        public static void AddTodoServices(this IServiceCollection services)
        {
            services.AddTransient<IRegisterService, RegisterService>();
            services.AddTransient<IRegisterDataProvider, RegisterDataProvider>();
        }
    }
}