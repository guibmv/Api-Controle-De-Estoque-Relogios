using Microsoft.AspNetCore.Mvc;
using SistemaCadastroRelogios.Context;

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
    }
}
