using System.ComponentModel.DataAnnotations;

namespace LivrariaAPI.Models
{
    public class Livro
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        [Required]
        public string Autor { get; set; }

        [Required]
        public string Genero { get; set; }

        [Required]
        public decimal Preco { get; set; }

        [Required]
        public int QuantidadeEmEstoque { get; set; }
    }
}
