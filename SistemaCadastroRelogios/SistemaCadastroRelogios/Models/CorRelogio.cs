using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SistemaCadastroRelogios.Models
{
    [Table("TB_RELOGIOCOR")]
    public class CorRelogio
    {
        [Key]
        [DisplayName("Id")]
        [JsonPropertyName("id")]
        public int IDCOR_COR { get; set; }
        [DisplayName("Cor")]
        [JsonPropertyName("color")]
        public string COLOR_COR { get; set; }
    }
}
