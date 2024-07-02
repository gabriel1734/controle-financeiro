using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace controlefinanceiro.Models
{
    public class Saldo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

        [Required]
        public int TransacaoId { get; set; }

        [ForeignKey("TransacaoId")]
        public Transacao Transacao { get; set; }

        [Required]
        public decimal ValorSaldo { get; set; }
    }
}
