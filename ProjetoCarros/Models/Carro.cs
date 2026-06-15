using System.ComponentModel.DataAnnotations;

namespace ProjetoCarros.Models
{
    public class Carro
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Nome { get; set; }
        public string? Marca { get; set; }
        public int Ano { get; set; }
        public string? Descricao { get; set; }
        public string? Imagem { get; set; }

    }
}
