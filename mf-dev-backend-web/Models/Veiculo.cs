using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_web.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Obrigatório informar o Nome.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatório informar a placa.")]
        public string Placa { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o modelo do veículo.")]
        public int AnoFabricacao { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o ano do veículo.")]
        public int AnoModelo { get; set; }
    }
}
