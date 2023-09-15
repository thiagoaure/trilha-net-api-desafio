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
        return _tarefaRepository.AtualizarTarefa(id, tarefa);
    }

    public Tarefa CriarTarefa(Tarefa tarefa)
    {
        return _tarefaRepository.CriarTarefa(tarefa);
    }

    public Tarefa DeletarTarefa(int id)
    {
        return _tarefaRepository.DeletarTarefa(id);
    }

    public Tarefa ObterTarefaPorId(int id)
    {
        return _tarefaRepository.ObterTarefaPorId(id);
    }

    public Tarefa ObterTarefaPorTitulo(string titulo)
    {
        return _tarefaRepository.ObterTarefaPorTitulo(titulo);
    }

    public IEnumerable<Tarefa> ObterTarefasPorData(DateTime data)
    {
        return _tarefaRepository.ObterTarefasPorData(data);
    }

    public IEnumerable<Tarefa> ObterTarefasPorStatus(EnumStatusTarefa status)
    {
        return _tarefaRepository.ObterTarefasPorStatus(status);
    }

    public IEnumerable<Tarefa> ObterTodasTarefas()
    {
        return _tarefaRepository.ObterTodasTarefas();
    }
}