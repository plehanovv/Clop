using Clop.Application.Services;
using Clop.Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Clop.Application.DependencyInjection;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
    }
}