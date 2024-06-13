using Microsoft.AspNetCore.Mvc;
using SistemaCadastroRelogios.Context;
using SistemaCadastroRelogios.Models;

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
            return Ok(_context.Cliente.ToList());
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
        [HttpPost()]
        public Cliente Post([FromBody] Cliente cliente)
        {
            _context.Cliente.Add(cliente);
            _context.SaveChanges();

            return cliente;
        }
        //Antes de criar os HttpPost criar as dtos de todos os controlodores, aprofundar no que são dtos e criar, em seguida criar os HttpPosts de todos os métodos
        //[HttpPost]
        //public IActionResult Create([FromBody] CreateClienteRequest clienteDto)
        //{

        //}
    }
}
