using Microsoft.AspNetCore.Mvc;
using SistemaCadastroRelogios.Context;

namespace SistemaCadastroRelogios.Controllers
{
    [ApiController]
    [Route("SistemaCadastroRelogios/Estoque")]
    public class EstoqueController : ControllerBase
    {
        #region Context
        private readonly AppDbContext _context;
        #endregion
        public EstoqueController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult GetAll() 
        {
            var estoque = _context.Estoque.ToList();

            return Ok(estoque);
        }
        [HttpGet("{id}")]
        public ActionResult GetById([FromRoute] int id)
        {
            var estoque = _context.Estoque.Find(id);

            if (estoque == null)
            {
                return NotFound();
            }

            return Ok(estoque);
        }
    }
}
