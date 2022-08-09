using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestaurante.Model
{
    public class Cliente
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public Pedido Pedido { get; set; }
    }
}
