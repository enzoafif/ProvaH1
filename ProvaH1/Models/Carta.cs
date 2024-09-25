using ProvaH1.Validations;
using System.ComponentModel.DataAnnotations;

namespace ProvaH1.Models
{
    public class Carta
    {
        [Required(ErrorMessage = "O Nome é obrigatório")]
        [MinLength(3, ErrorMessage = "O Nome deve ter no mínimo 3 caracteres")]
        [MaxLength(255, ErrorMessage = "O Nome deve ter no máximo 255 caracteres")]
        public string NomeCrianca { get; set; } = string.Empty;

        [Required(ErrorMessage = "A Rua é obrigatória")]
        public string Rua { get; set; } = string.Empty;

        [Required(ErrorMessage = "O Número é obrigatório")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "O Bairro é obrigatório")]
        public string Bairro { get; set; } = string.Empty;

        [Required(ErrorMessage = "A Cidade é obrigatória")]
        public string Cidade { get; set; } = string.Empty;

        [Required(ErrorMessage = "O Estado é obrigatório")]
        public string Estado { get; set; } = string.Empty;

        [Required(ErrorMessage = "A Idade é obrigatória")]
        [IdadeValidation(ErrorMessage = "A idade não pode ser maior que 15")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "O Texto é obrigatório")]
        [MaxLength(500, ErrorMessage = "O Texto não pode ter mais de 500 caracteres")]
        public string Texto { get; set; } = string.Empty;
    }
}
