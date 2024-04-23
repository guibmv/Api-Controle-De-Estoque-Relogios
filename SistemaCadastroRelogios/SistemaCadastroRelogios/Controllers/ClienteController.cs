using Microsoft.AspNetCore.Mvc;
using SistemaCadastroRelogios.Context;

namespace SistemaCadastroRelogios.Controllers
{
    [ApiController]
    [Route("SistemaCadastroRelogios/Cliente")]
    public class ClienteController : ControllerBase
    {
        #region Context
        private readonly AppDbContext _context;
        #endregion
        public ClienteController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var cliente = _context.Cliente.ToList();

            return Ok(cliente);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var cliente = _context.Cliente.Find(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }
        //Antes de criar os HttpPost criar as dtos de todos os controlodores, aprofundar no que são dtos e criar, em seguida criar os HttpPosts de todos os métodos
        //[HttpPost]
        //public IActionResult Create([FromBody] CreateClienteRequest clienteDto)
        //{

        //}
    }
}
