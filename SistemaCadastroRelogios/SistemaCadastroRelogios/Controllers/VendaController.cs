using Microsoft.AspNetCore.Mvc;
using SistemaCadastroRelogios.Context;

namespace SistemaCadastroRelogios.Controllers
{
    [ApiController]
    [Route("SistemaCadastroRelogios/Venda")]
    public class VendaController : ControllerBase
    {
        #region Context
        private readonly AppDbContext _context;
        #endregion
        public VendaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var venda = _context.Venda.ToList();

            return Ok(venda);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var venda = _context.Venda.Find(id);

            if (venda == null)
            {
                return NotFound();
            }

            return Ok(venda);
        }
    }
}
