using TrilhaApiDesafio.Interfaces.Service;
using TrilhaApiDesafio.Services;

namespace TrilhaApiDesafio.Extensions;

public static class ServicesExtensions
{
    public static void AddCustomServices(this IServiceCollection services)
    {
        services.AddTransient<ITarefaService, TarefaService>();
    }
}