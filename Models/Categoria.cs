using System.ComponentModel.DataAnnotations;

namespace controlefinanceiro.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
    }
}
