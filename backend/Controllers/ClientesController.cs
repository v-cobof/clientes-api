using backend.Data.Repositories;
using backend.Models;
using backend.Models.InputModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        // para fazer a injeção de dependência
        private IClientesRepository _clientesRepository;

        public ClientesController(IClientesRepository clientesRepository)
        {
            _clientesRepository = clientesRepository;
        }

        
        [HttpGet]
        public IActionResult Get()
        {
            var clientes = _clientesRepository.Buscar();
            return Ok(clientes);
        }

        
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var cliente = _clientesRepository.Buscar(id);
            if (cliente == null) return NotFound();
            return Ok(cliente);
        }

        
        [HttpPost]
        public IActionResult Post([FromBody] ClienteInputModel novoCliente)
        {
            Cliente cliente = new Cliente(novoCliente);

            _clientesRepository.Adicionar(cliente);

            return Created("", cliente);
        }

        
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] ClienteInputModel clienteAtualizado)
        {

            var cliente = _clientesRepository.Buscar(id);
            if (cliente == null) return NotFound();

            cliente.AtualizarCliente(clienteAtualizado.Nome, clienteAtualizado.Telefone, clienteAtualizado.Endereco);

            _clientesRepository.Atualizar(id, cliente);

            return Ok(clienteAtualizado);
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var cliente = _clientesRepository.Buscar(id);
            if (cliente == null) return NotFound();

            _clientesRepository.Remover(id);

            return NoContent();
        }
    }
}
