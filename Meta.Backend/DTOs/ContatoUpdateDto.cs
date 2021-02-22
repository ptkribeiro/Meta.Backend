using Meta.Backend.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Meta.Backend.DTOs
{
    public class ContatoUpdateDto
    {
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(100, ErrorMessage = "Este campo deve conter no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [UpdateCanalValidation]
        public string Canal { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(250, ErrorMessage = "Este campo deve conter no máximo 250 caracteres")]
        public string Valor { get; set; }

        public string Obs { get; set; }
    }
}
