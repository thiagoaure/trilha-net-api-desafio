using TrilhaApiDesafio.Interfaces.Repository;
using TrilhaApiDesafio.Repositories;

namespace TrilhaApiDesafio.Extensions;
public static class RepositoriesExtensions
{
    public static void AddCustomRepositories(this IServiceCollection services)
    {
        services.AddTransient<ITarefaRepository, TarefaRepository>();
    }
}