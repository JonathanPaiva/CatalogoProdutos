using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CatalogoProdutosAPI.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        
        [Required]
        [MaxLength(80)]
        public string? Nome { get; set; }
        
        [MaxLength(300)]
        public string? ImagemUrl { get; set; }

        public ICollection<Produto>? Produtos { get; set; }
        
        public Categoria()
        {
            Produtos = new Collection<Produto>();
        }
    }
}
