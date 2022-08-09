using ApiRestaurante.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestaurante.Data
{
    public class AplicationContext : DbContext
    {
        private DbContextOptions _context;

        public AplicationContext( DbContextOptions context )
        {
            _context = context;
        }

      public DbSet<Cliente> clientes { get; set; }
      public DbSet<Endereco> Enderecos { get; set; }
      public DbSet<Funcionario> Funcionarios { get; set; }
      public DbSet<Pedido> Pedidos { get; set; }
      public DbSet<Produto> Produtos { get; set; }
    }
}
