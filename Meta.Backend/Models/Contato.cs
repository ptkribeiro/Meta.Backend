using System.ComponentModel.DataAnnotations;

namespace Meta.Backend.Models
{
    public class Contato
    {
        [Key]

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(20)]
        public string Canal { get; set; }

        [Required]
        [MaxLength(250)]
        public string Valor { get; set; }

        public string Obs { get; set; }

    }
}
