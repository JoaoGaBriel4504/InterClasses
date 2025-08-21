using System.ComponentModel.DataAnnotations;

namespace InterClasses.Models
{
    public class Campeonato
    {
        public int CampeonatoId { get; set; } // Chave primaria (ID)

        [Required(ErrorMessage = "O Nome do Campeonato é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O Nome do Campeonato deve ter no máximo 10 caracteres.")]
        [Display(Name = "Nome do Campeonato")]
        public string? Nome { get; set; }


        // Relacionamento Campeonato X Esporte
        [Display(Name = "Esporte")]
        public int EsporteId { get; set; }
        public Esporte? Esporte { get; set; }
    }
}
