using Microsoft.AspNetCore.Mvc;
using SistemaCadastroRelogios.Context;

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
    }
}
