using Microsoft.AspNetCore.Mvc;
using SistemaCadastroRelogios.Context;

namespace SistemaCadastroRelogios.Controllers
{
    [ApiController]
    [Route("SistemaCadastroRelogios/Marca")]
    public class MarcaController : ControllerBase
    {
        #region Context
        private readonly AppDbContext _context;
        #endregion
        public MarcaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            var marca = _context.Marca.ToList();

            return Ok(marca);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id) 
        {
            var marca = _context.Marca.Find(id);

            if (marca == null)
            {
                return NotFound();
            }

            return Ok(marca);
        }
    }
}
