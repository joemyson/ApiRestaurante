using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestaurante.Data.DTOs.FuncionarioDTO
{
    public class ReadFuncionarioDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
