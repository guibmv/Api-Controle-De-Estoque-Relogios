using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Text.Json.Serialization;

namespace SistemaCadastroRelogios.Models
{
    [Table("TB_MARCA_RELOGIO")]
    public class Marca
    {
        [Key]
        [DisplayName("Id")]
        [JsonPropertyName("id")]
        public int IDMRC_MRC { get; set; }
        [DisplayName("Nome")]
        [JsonPropertyName("name")]
        public string MARCA_MRC { get; set; }
    }
}
