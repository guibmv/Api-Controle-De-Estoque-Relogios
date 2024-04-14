using Microsoft.AspNetCore.Mvc;
using SistemaCadastroRelogios.Context;

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
            var cliente = _context.Cliente.ToList();

            return Ok(cliente);
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
    }
}
