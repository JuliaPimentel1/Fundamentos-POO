using System.ComponentModel.DataAnnotations;

namespace InterClasses.Models
{
    public class Jogador
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome do Jogador é Obrigatório.")]

        [MaxLength(50, ErrorMessage = "O Nome do Jogador pode ter no máximo 50 caracteres")]
        [Display(Name = "Nome do Jogador")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo Numero do Jogador é Obrigatório")]
        [Range(1, 999, ErrorMessage = "O número do Jogador deve estar entre 1 e 999.")]
        [Display(Name = "Número")]
        public int Numero { get; set; }

        [Display(Name = "Posição")]
        public string? Posicao { get; set; }

        //Relacionamento Jogador X Time 
        [Display(Name = "Time")]
        public int TimeId { get; set; }
        public Time? Time { get; set; }
    }
}
