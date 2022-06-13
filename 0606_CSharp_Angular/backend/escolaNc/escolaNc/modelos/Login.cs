using System.ComponentModel.DataAnnotations;

namespace escolaNc.Modelos
{
    public class Login
    {
        public string nome { get; set; }        
        [Key]
        public string cpf { get; set; }
        public string senha { get; set; }
    }
}
