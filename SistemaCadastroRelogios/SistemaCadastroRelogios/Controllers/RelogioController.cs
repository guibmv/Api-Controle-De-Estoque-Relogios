using Microsoft.AspNetCore.Mvc;
using SistemaCadastroRelogios.Context;
using SistemaCadastroRelogios.Models;

namespace SistemaCadastroRelogios.Controllers
{
    [ApiController]
    [Route("SistemaCadastroRelogios/Relogio")]
    public class RelogioController : ControllerBase
    {
        #region Context
        private readonly AppDbContext _context;
        #endregion
        public RelogioController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var relogio = _context.Relogio.ToList();

            return Ok(relogio);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var relogio = _context.Relogio.Find(id);

            if (relogio == null)
            {
                return NotFound();
            }

            return Ok(relogio);
        }

        [HttpPost()]
        public Relogio Post([FromBody] Relogio relogio)
        {
            _context.Relogio.Add(relogio);
            _context.SaveChanges();

            return relogio;
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRelogio(int id, [FromBody] Relogio updateRelogio)
        {
            if (id != updateRelogio.IDREL_REL)
            {
                return BadRequest("OS ID's NÃO COINCIDEM");
            }

            var existingRelogio = _context.Relogio.Find(id);
            if (existingRelogio == null) 
            {
                return NotFound();
            }

            existingRelogio.IDMRC_REL = updateRelogio.IDMRC_REL;
            existingRelogio.REFER_REL = updateRelogio.REFER_REL;
            existingRelogio.IDCOR_REL = updateRelogio.IDCOR_REL;
            existingRelogio.GARAN_REL = updateRelogio.GARAN_REL;
            existingRelogio.PRECO_REL = updateRelogio.PRECO_REL;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRelogio(int id)
        {
            var relogio = _context.Relogio.Find(id);
            if (relogio == null)
            {
                return NotFound();
            }

            _context.Relogio.Remove(relogio);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
