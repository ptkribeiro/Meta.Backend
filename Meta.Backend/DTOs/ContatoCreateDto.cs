using Meta.Backend.Validation;
using System.ComponentModel.DataAnnotations;

namespace Meta.Backend.DTOs
{
    public class ContatoCreateDto
    {
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(100, ErrorMessage = "Este campo deve conter no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(20)]
        [CreateCanalValidation]
        public string Canal { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(250, ErrorMessage = "Este campo deve conter no máximo 250 caracteres")]
        public string Valor { get; set; }

        public string Obs { get; set; }
    }
}
