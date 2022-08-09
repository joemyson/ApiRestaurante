using ApiRestaurante.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestaurante.Data.DTOs.PedidoDTO
{
    public class ReadPedidoDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int Valor { get; set; }
        public Produto Produto { get; set; }
    }
}
