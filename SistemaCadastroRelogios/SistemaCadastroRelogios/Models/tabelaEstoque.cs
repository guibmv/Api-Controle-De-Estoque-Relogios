namespace SistemaCadastroRelogios.Models
{
    public class tabelaEstoque
    {
        public int Id { get; set; }
        public int IdRelogio { get; set; }
        public int Quantidade { get; set; }
        public DateTime Atualizacao { get; set; }
    }
}
