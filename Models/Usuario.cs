using System.ComponentModel.DataAnnotations;

namespace controlefinanceiro.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        [Required]
        public string Senha { get; set; }
    }
}
