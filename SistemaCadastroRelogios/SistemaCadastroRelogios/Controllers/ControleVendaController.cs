using Microsoft.AspNetCore.Mvc;
using SistemaCadastroRelogios.Context;
using SistemaCadastroRelogios.Models;

namespace SistemaCadastroRelogios.Controllers
{
    [ApiController]
    [Route("SistemaCadastroRelogios/ControleVenda")]
    public class ControleVendaController : ControllerBase
    {
        #region Context
        private readonly AppDbContext _context;
        #endregion
        public ControleVendaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var controleVenda = _context.ControleVenda.ToList();

            return Ok(controleVenda);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            var controleVenda = _context.ControleVenda.Find(id);

            if (controleVenda == null)
            {
                return NotFound();
            }

            return Ok(controleVenda);
        }

        [HttpPost()]
        public ControleVenda Post([FromBody] ControleVenda controleVenda)
        {
            _context.ControleVenda.Add(controleVenda);
            _context.SaveChanges();

            return controleVenda;
        }

        [HttpPut("{id}")]
        public IActionResult UpdateControleVenda(int id, [FromBody] ControleVenda updateControleVenda)
        {
            if (id != updateControleVenda.IDVEE_VEE)
            {
                return BadRequest("OS ID's NÃO COINCIDEM");
            }

            var existControleVenda = _context.ControleVenda.Find(id);
            if (existControleVenda == null)
            {
                return NotFound();
            }

            existControleVenda.IDREL_VEE = updateControleVenda.IDREL_VEE;
            existControleVenda.IDVEN_VEE = updateControleVenda.IDVEN_VEE;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteControleVenda(int id)
        {
            var controleVenda = _context.ControleVenda.Find(id);
            if (controleVenda == null)
            {
                return NotFound();
            }

            _context.ControleVenda.Remove(controleVenda);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
