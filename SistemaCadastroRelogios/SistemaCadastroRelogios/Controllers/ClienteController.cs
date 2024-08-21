using Microsoft.AspNetCore.Mvc;
using SistemaCadastroRelogios.Context;
using SistemaCadastroRelogios.Models;

namespace SistemaCadastroRelogios.Controllers
{
    [ApiController]
    [Route("SistemaCadastroRelogios/Cliente")]
    public class ClienteController : ControllerBase
    {
        #region Context
        private readonly AppDbContext _context;
        #endregion
        public ClienteController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Cliente.ToList());
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var cliente = _context.Cliente.Find(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }
        
        [HttpPost()]
        public Cliente Post([FromBody] Cliente cliente)
        {
            _context.Cliente.Add(cliente);
            _context.SaveChanges();

            return cliente;
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCliente(int id, [FromBody] Cliente updateCliente)
        {
            if (id != updateCliente.IDCLI_CLI)
            {
                return BadRequest("OS ID's NÃO COINCIDEM");
            }

            var existCliente = _context.Cliente.Find(id);
            if (existCliente == null)
            {
                return NotFound();
            }

            existCliente.TELCL_CLI = updateCliente.TELCL_CLI;
            existCliente.NOMCL_CLI = updateCliente.NOMCL_CLI;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCliente(int id)
        {
            var cliente = _context.Cliente.Find(id);
            if (cliente == null)
            {
                return NotFound();
            }

            _context.Cliente.Remove(cliente);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
