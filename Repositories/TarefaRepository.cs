using Microsoft.EntityFrameworkCore;
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
        var oldTarefa = ObterTarefaPorId(id);
        if (oldTarefa != null)
        {
            oldTarefa.Id = id;
            oldTarefa.Titulo = tarefa.Titulo;
            oldTarefa.Descricao = tarefa.Descricao;
            oldTarefa.Status = tarefa.Status;
            oldTarefa.Data = tarefa.Data;
            _context.Entry(oldTarefa).State = EntityState.Modified;
            _context.SaveChanges();
        }
        return oldTarefa;
    }

    public Tarefa CriarTarefa(Tarefa tarefa)
    {
        _context.Tarefas.Add(tarefa);
        _context.SaveChanges();
        return tarefa;
    }

    public Tarefa DeletarTarefa(int id)
    {
        var tarefa = _context.Tarefas.Find(id);
        _context.Tarefas.Remove(tarefa);
        _context.SaveChanges();
        return tarefa;
    }

    public Tarefa ObterTarefaPorId(int id)
    {
        var tarefa = _context.Tarefas.FirstOrDefault(x => x.Id == id);
        return tarefa;
    }

    public Tarefa ObterTarefaPorTitulo(string titulo)
    {
        var tarefa = _context.Tarefas.FirstOrDefault(x => x.Titulo == titulo);
        return tarefa;
    }

    public IEnumerable<Tarefa> ObterTarefasPorData(DateTime data)
    {
        var tarefas = _context.Tarefas.Where(x => x.Data.Date == data.Date);
        return tarefas.ToList();
    }

    public IEnumerable<Tarefa> ObterTarefasPorStatus(EnumStatusTarefa status)
    {
        var tarefas = _context.Tarefas.Where(x => x.Status == status);
        return tarefas.ToList();
    }

    public IEnumerable<Tarefa> ObterTodasTarefas()
    {
        return _context.Tarefas.ToList();
    }
}
