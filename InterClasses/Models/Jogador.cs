using System.ComponentModel.DataAnnotations;

namespace InterClasses.Models
{
    public class Jogador
    {
        public int JogadorId { get; set; } // Chave primaria (ID)

        [Required(ErrorMessage = "O Nome do jogador é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O Nome do jogador deve ter no máximo 10 caracteres.")]
        [Display(Name = "Nome do Jogador")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O Campo Numero do Jogador é Obrigatorio.")]
        [Range(1, 999, ErrorMessage = "O Numero do Jogador deve estar entre 1 e 999.")]
        [Display(Name = "Numero")]
        public int Numero { get; set; }

        public string? Posicao { get; set; }

        // Relacionamento Jogador X Time
        [Display(Name = "Time")]
        public int TimeId { get; set; }
        public Time? Time { get; set; }
    }
}
