using Microsoft.EntityFrameworkCore;
using SistemaCadastroRelogios.Models;

namespace SistemaCadastroRelogios.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<cliente> TB_CLIENTE { get; set; }
        public DbSet<controleVenda> TB_CONTROLEVENDA { get; set; }
        public DbSet<CorRelogio> TB_RELOGIOCOR { get; set; }
        public DbSet<Estoque> TB_ESTOQUE { get; set; }
        public DbSet<Marca> TB_MARCA { get; set; }
        public DbSet<Relogio> TB_RELOGIO { get; set; }
        public DbSet<Venda> TB_VENDA { get; set; }
        public DbSet<Vendedor> TB_VENDEDOR { get; set; }
    }
}
