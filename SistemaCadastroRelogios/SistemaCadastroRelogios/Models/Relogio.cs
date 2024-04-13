using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Schema;

namespace SistemaCadastroRelogios.Models
{
    [Table("TB_RELOGIO")]
    public class Relogio
    {
        [Key]
        [DisplayName("Id")]
        [JsonPropertyName("id")]
        public int IDREL_REL { get; set; }
        [ForeignKey("IDMRC_MRC")]
        [DisplayName("IdMarca")]
        [JsonPropertyName("idMarca")]
        public int IDMRC_REL { get; set; }
        [ForeignKey("IDCOR_COR")]
        [DisplayName("IdCor")]
        [JsonPropertyName("idCor")]
        public int IDCOR_REL { get; set; }
        [DisplayName("Preço")]
        [JsonPropertyName("preço")]
        public decimal PRECO_REL { get; set; }
        [DisplayName("Garantia")]
        [JsonPropertyName("garantia")]
        public string GARAN_REL { get; set; }
        [DisplayName("Id")]
        [JsonPropertyName("referencia")]
        public string REFER_REL { get; set; }
    }
}
