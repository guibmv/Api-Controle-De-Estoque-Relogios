using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SistemaCadastroRelogios.Models
{
    [Table("TB_VENDA")]
    public class Venda
    {
        [Key]
        [DisplayName("Id")]
        [JsonPropertyName("id")]
        public int IDVEN_VEN { get; set; }
        [ForeignKey("IDCLI_CLI")]
        [DisplayName("Cliente")]
        [JsonPropertyName("idCliente")]
        public int IDCLI_VEN { get; set; }
        [DisplayName("Pagamento")]
        [JsonPropertyName("payment")]
        public string METPG_VEN { get; set; }
        [DisplayName("Parcela")]
        [JsonPropertyName("parcel")]
        public int PARCV_VEN { get; set; }
        [DisplayName("DataVenda")]
        [JsonPropertyName("date")]
        public DateTime DTVEN_VEN { get; set; }
    }
}
