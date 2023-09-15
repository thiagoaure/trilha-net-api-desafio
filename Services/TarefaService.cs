using TrilhaApiDesafio.Interfaces.Repository;
using TrilhaApiDesafio.Interfaces.Service;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Services;

public class TarefaService : ITarefaService
{
    private readonly ITarefaRepository _tarefaRepository;

    public TarefaService(ITarefaRepository tarefaRepository)
    {
        _tarefaRepository = tarefaRepository;
    }

    public Tarefa AtualizarTarefa(int id, Tarefa tarefa)
    {
        throw new NotImplementedException();
    }

    public Tarefa CriarTarefa(Tarefa tarefa)
    {
        throw new NotImplementedException();
    }

    public Tarefa DeletarTarefa(int id)
    {
        throw new NotImplementedException();
    }

    public Tarefa ObterTarefaPorId(int id)
    {
        throw new NotImplementedException();
    }

    public Tarefa ObterTarefaPorTitulo(string titulo)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Tarefa> ObterTarefasPorData(DateTime data)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Tarefa> ObterTarefasPorStatus(EnumStatusTarefa status)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Tarefa> ObterTodasTarefas()
    {
        throw new NotImplementedException();
    }
}