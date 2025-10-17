using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_web.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage ="Obrigatório informar o Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Nome")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public Perfil perfil { get; set; }
    }


    public enum Perfil
    {
        Admin,
        User
    }
}
