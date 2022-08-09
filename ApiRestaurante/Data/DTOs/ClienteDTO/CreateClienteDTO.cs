using ApiRestaurante.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestaurante.Data.DTOs.ClienteDTO
{
    public class CreateClienteDTO
    {
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public Pedido Pedido { get; set; }
    }
}
