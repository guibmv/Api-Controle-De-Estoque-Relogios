namespace SistemaCadastroRelogios.Models
{
    public class tabelaVenda
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string MetodoPagamento { get; set; }
        public int QttParcelas { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
