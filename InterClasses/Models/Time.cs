using System.ComponentModel.DataAnnotations;

namespace InterClasses.Models
{
    public class Time
    {
        public int TimeId { get; set; } // Chave primaria (ID)
        [Required(ErrorMessage = "O Nome do time é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O Nome do time deve ter no máximo 50 caracteres.")]
        [Display(Name = "Nome do Time")]
        public string? Nome { get; set; }

        // Relacionamento entre Models (Tabelas no Banco de Dados)
        // Chave Estrangeira
        [Display(Name = "Esporte")]
        public int EsporteId { get; set; } // Vincular o campo do ID da tabela
        public Esporte? Esporte { get; set; } // Modificar o Objeto relacionado ao ID acima

    }
}
