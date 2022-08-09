using ApiRestaurante.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestaurante.Data.DTOs.PedidoDTO
{
    public class CreatePedidoIdDTO
    {
        public int Valor { get; set; }
        public Produto Produto { get; set; }
    }
}
