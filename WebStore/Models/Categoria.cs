using System.ComponentModel.DataAnnotations;

namespace WebStore.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        [StringLength(50, ErrorMessage ="Tamanho Maximo é 50 caracteres")]
        [Required(ErrorMessage ="Informe categoria")]
        [Display(Name ="Nome")]
        public string CategNome { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
