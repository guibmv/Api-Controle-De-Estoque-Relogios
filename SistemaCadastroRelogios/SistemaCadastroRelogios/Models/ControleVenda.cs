using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SistemaCadastroRelogios.Models
{
    [Table("TB_CONTROLEVENDA")]
    public class ControleVenda
    {
        [Key]
        [DisplayName("Id")]
        [JsonPropertyName("id")]
        public int IDVEE_VEE { get; set; }
        [ForeignKey("IDREL_REL")]
        [DisplayName("IdRelogio")]
        [JsonPropertyName("idRelogio")]
        public int IDREL_VEE { get; set; }
        [ForeignKey("IDVEN_VEN")]
        [DisplayName("IdVenda")]
        [JsonPropertyName("idVenda")]
        public int IDVEN_VEE { get; set; }
    }
}
