using Microsoft.AspNetCore.Mvc;
using SistemaCadastroRelogios.Context;

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
    }
}
