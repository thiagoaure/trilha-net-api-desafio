using System;
using TrilhaApiDesafio.Context;
using TrilhaApiDesafio.Interfaces.Repository;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Repositories;
public class TarefaRepository : ITarefaRepository
{
    private readonly OrganizadorContext _context;

    public TarefaRepository(OrganizadorContext context)
    {
        _context = context;
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
