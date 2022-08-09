using ApiRestaurante.Data;
using ApiRestaurante.Data.DTOs.ClienteDTO;
using ApiRestaurante.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestaurante.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private AplicationContext _context;
        private IMapper _mapper;

        public ClienteController(AplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        [HttpPost]
        public IActionResult AdicionarCliente([FromBody] CreateClienteDTO clienteDTO)
        {
            Cliente cliente = _mapper.Map<Cliente>(clienteDTO);
            _context.clientes.Add(cliente);
            _context.SaveChanges();

            return CreatedAtAction(nameof(RecuperaClienteId), new { Id = cliente.Id }, cliente);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaClienteId(int id)
        {
            Cliente cliente = _context.clientes.FirstOrDefault(cliente => cliente.Id == id);
            if (cliente != null)
            {
                ReadClienteDTO clienteDTO = _mapper.Map<ReadClienteDTO>(cliente);
                return Ok(cliente);
            }

            return NotFound();

        }
    }
}
