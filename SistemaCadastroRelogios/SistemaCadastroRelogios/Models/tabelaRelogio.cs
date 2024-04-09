using System.Xml.Schema;

namespace SistemaCadastroRelogios.Models
{
    public class tabelaRelogio
    {
        public int Id { get; set; }
        public int IdMarca { get; set; }
        public int IdRelogio { get; set; }
        public decimal Preco { get; set; }
        public string Garantia { get; set; }
        public string Referencia { get; set; }
    }
}
