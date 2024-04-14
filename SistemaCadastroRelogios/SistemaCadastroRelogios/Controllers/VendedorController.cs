using Microsoft.AspNetCore.Mvc;
using SistemaCadastroRelogios.Context;

namespace SistemaCadastroRelogios.Controllers
{
    [ApiController]
    [Route("SistemaCadastroRelogios/Vendedor")]
    public class VendedorController : ControllerBase
    {
        #region Context
        private readonly AppDbContext _context;
        #endregion
        public VendedorController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var vendedor = _context.Vendedor.ToList();

            return Ok(vendedor);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var vendedor = _context.Vendedor.Find(id);

            if (vendedor == null)
            {
                return NotFound();
            }

            return Ok(vendedor);
        }
    }
}
