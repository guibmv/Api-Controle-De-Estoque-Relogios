using Microsoft.AspNetCore.Mvc;
using SistemaCadastroRelogios.Context;
using SistemaCadastroRelogios.Models;

namespace SistemaCadastroRelogios.Controllers
{
    [ApiController]
    [Route("SistemaCadastroRelogios/CorRelogio")]
    public class CorRelogioController : ControllerBase
    {
        #region Context
        private readonly AppDbContext _context;
        #endregion
        public CorRelogioController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            var corRelogio = _context.CorRelogio.ToList();

            return Ok(corRelogio);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id) 
        {
            var corRelogio = _context.CorRelogio.Find(id);

            if(corRelogio == null)
            {
                return NotFound();
            }

            return Ok(corRelogio);
        }

        [HttpPost()]
        public CorRelogio Post([FromBody] CorRelogio corRelogio)
        {
            _context.CorRelogio.Add(corRelogio);
            _context.SaveChanges();

            return corRelogio;
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCorRelogio(int id, [FromBody] CorRelogio updateCorRelogio)
        {
            if (id != updateCorRelogio.IDCOR_COR)
            {
                return BadRequest("OS ID's NÃO COINCIDEM");
            }

            var existCorRelogio = _context.CorRelogio.Find(id);
            if (existCorRelogio == null)
            {
                return NotFound();
            }

            existCorRelogio.COLOR_COR = updateCorRelogio.COLOR_COR;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCorRelogio(int id)
        {
            var corRelogio = _context.CorRelogio.Find(id);
            if (corRelogio == null)
            {
                return NotFound();
            }

            _context.CorRelogio.Remove(corRelogio);
            _context.SaveChanges(); 

            return NoContent();
        }
    }
}
