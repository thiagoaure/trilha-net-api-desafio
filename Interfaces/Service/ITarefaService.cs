using System;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Interfaces.Service;

public interface ITarefaService
{
    Tarefa ObterTarefaPorId(int id);
    IEnumerable<Tarefa> ObterTodasTarefas();
    Tarefa ObterTarefaPorTitulo(string titulo);
    IEnumerable<Tarefa> ObterTarefasPorData(DateTime data);
    IEnumerable<Tarefa> ObterTarefasPorStatus(EnumStatusTarefa status);
    Tarefa CriarTarefa(Tarefa tarefa);
    Tarefa AtualizarTarefa(int id, Tarefa tarefa);
    Tarefa DeletarTarefa(int id);
}
