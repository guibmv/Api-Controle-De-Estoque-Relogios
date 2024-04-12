using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SistemaCadastroRelogios.Models
{
    [Table("TB_CLIENTE")]
    public class Cliente
    {
        [Key]
        [DisplayName("Id")]
        [JsonPropertyName("id")]
        public int IDCLI_CLI { get; set; }
        [DisplayName("Name")]
        [JsonPropertyName("name")]
        public string NOMCL_CLI { get; set; }
        [DisplayName("Telefone")]
        [JsonPropertyName("telefone")]
        public int? TELCL_CLI { get; set; }
    }
}
