using Microsoft.AspNetCore.Mvc;
using TrilhaApiDesafio.Interfaces.Service;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaService _tarefaService;

        public TarefaController(ITarefaService tarefaService)
        {
            _tarefaService = tarefaService;
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var tarefa = _tarefaService.ObterTarefaPorId(id);
            if (tarefa == null) return NotFound();

            return Ok(tarefa);
        }

        [HttpGet("ObterTodos")]
        public IActionResult ObterTodos()
        {
            var tarefas = _tarefaService.ObterTodasTarefas();
            return Ok(tarefas);
        }

        [HttpGet("ObterPorTitulo")]
        public IActionResult ObterPorTitulo(string titulo)
        {
            var tarefa = _tarefaService.ObterTarefaPorTitulo(titulo);
            if (tarefa == null) return NotFound();

            return Ok(tarefa);
        }

        [HttpGet("ObterPorData")]
        public IActionResult ObterPorData(DateTime data)
        {
            var tarefas = _tarefaService.ObterTarefasPorData(data);
            return Ok(tarefas);
        }

        [HttpGet("ObterPorStatus")]
        public IActionResult ObterPorStatus(EnumStatusTarefa status)
        {
            var tarefas = _tarefaService.ObterTarefasPorStatus(status);
            return Ok(tarefas);
        }

        [HttpPost]
        public IActionResult Criar(Tarefa tarefa)
        {
            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });
            var newTarefa = _tarefaService.CriarTarefa(tarefa);

            return CreatedAtAction(nameof(ObterPorId), new { id = tarefa.Id }, tarefa);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Tarefa tarefa)
        {
            var tarefaFound = _tarefaService.ObterTarefaPorId(id);

            if (tarefaFound == null)
                return NotFound();

            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });

            var newTarefa = _tarefaService.AtualizarTarefa(id, tarefa);
            
            return Ok(newTarefa);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var tarefa = _tarefaService.DeletarTarefa(id);

            if (tarefa == null)
                return NotFound();

            return NoContent();
        }
    }
}
