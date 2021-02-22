using Meta.Backend.DTOs;
using System.ComponentModel.DataAnnotations;

namespace Meta.Backend.Validation
{
    public class CanalValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext)
        {
            var contatoCreateDto = (ContatoCreateDto)validationContext.ObjectInstance;

            if (contatoCreateDto.Canal == "Email" || contatoCreateDto.Canal == "Celular" || contatoCreateDto.Canal == "Fixo")
                return ValidationResult.Success;

            return new ValidationResult("O valor do canal deve ser: Email, Celular ou Fixo");

        }
    }
}
