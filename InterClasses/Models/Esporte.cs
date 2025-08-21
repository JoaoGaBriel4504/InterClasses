using System.ComponentModel.DataAnnotations;

namespace InterClasses.Models
{
    public class Esporte
    {
        public int EsporteId { get; set; }
        [Required(ErrorMessage = "O Nome do esporte é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O Nome do esporte deve ter no máximo 50 caracteres.")]
        [Display(Name = "Nome do Esporte")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Informe a quantidade maxima de Jogadores por time.")]
        [Range(1, 25, ErrorMessage = "O Numero de jogadores deve ser entre 1 e 25.")]

        [Display(Name = "Quantidade de Jogadores")]
        public int QtdJogadores { get; set; }
    }
}
