using Microsoft.EntityFrameworkCore;
using SistemaCadastroRelogios.Models;

namespace SistemaCadastroRelogios.DataBase
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<ControleVenda> ControleVenda { get; set; }
        public DbSet<CorRelogio> CorRelogio { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Relogio> Relogio { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
    }
}
