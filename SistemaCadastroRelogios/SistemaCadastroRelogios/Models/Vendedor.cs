using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SistemaCadastroRelogios.Models
{
    [Table("TB_VENDEDOR")]
    public class Vendedor
    {
        [Key]
        [DisplayName("Id")]
        [JsonPropertyName("id")]
        public int IDVDD_VDD { get; set; }
        [DisplayName("Nome")]
        [JsonPropertyName("name")]
        public string NOMVD_VDD { get; set; }
        [DisplayName("Telefone")]
        [JsonPropertyName("telefone")]
        public int TELVD_VDD { get; set; }
    }
}
