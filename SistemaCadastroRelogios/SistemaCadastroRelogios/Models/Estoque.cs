using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SistemaCadastroRelogios.Models
{
    [Table("TB_ESTOQUE")]
    public class Estoque
    {
        [Key]
        [DisplayName("Id")]
        [JsonPropertyName("id")]
        public int IDEST_EST { get; set; }
        [ForeignKey("IDREL_REL")]
        [DisplayName("IdRelogio")]
        [JsonPropertyName("idRelogio")]
        public int IDREL_EST { get; set; }
        [DisplayName("Quantidade")]
        [JsonPropertyName("quantity")]
        public int QTTRE_EST { get; set; }
        [DisplayName("Atualização")]
        [JsonPropertyName("atualização")]
        public DateTime ATTET_EST { get; set; }
    }
}
