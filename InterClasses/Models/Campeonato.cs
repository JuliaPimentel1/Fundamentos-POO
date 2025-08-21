using System.ComponentModel.DataAnnotations;

namespace InterClasses.Models
{
    public class Campeonato
    {
        public int CampeoId { get; set; }

        [Required(ErrorMessage = "O Campo do Cmpeonato é Obrigatório")]
        [MaxLength(50, ErrorMessage = "O Nome do Campeonatop pode ter, no máximo 50 caracteres.")]
        [Display(Name = "Nome do Campeonato")]
        public string? Nome { get; set; }

        [Display(Name = "Esporte")]
        public int EsporteId { get; set; }
        public Esporte? Esporte { get; set; }

    }
}
