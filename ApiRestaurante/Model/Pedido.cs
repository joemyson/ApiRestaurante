using System.ComponentModel.DataAnnotations;

namespace ApiRestaurante.Model
{
    public class Pedido
    {
        [Key]
        [Required]
        public int Id{ get; set; }
        public int Valor { get; set; }
        public Produto Produto { get; set; }
    }
}