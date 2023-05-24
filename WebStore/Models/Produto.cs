using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        [StringLength(50, ErrorMessage = "Tamanho Maximo é 50 caracteres")]
        [Required(ErrorMessage = "Informe produto")]
        [Display(Name = "Produto")]
        public string Descricao { get; set; }

        [StringLength(200, ErrorMessage = "Tamanho Maximo é 200 caracteres")]
        [Display(Name = "Descrição")]
        public string DescricaoDetalhada { get; set; }

        [Display(Name ="Preço Unitario")]
        [Column(TypeName ="decimal(10,2)")]
        public double ValorUnitario { get; set; }               
        public int CategoriaId { get; set; }

        [ForeignKey(nameof(CategoriaId))]
        public virtual Categoria Categoria { get; set; }

        [StringLength(100, ErrorMessage = "Tamanho Maximo é 100 caracteres")]
        public string ImgUrl { get; set; }

        [StringLength(100, ErrorMessage = "Tamanho Maximo é 100 caracteres")]
        public string ImgThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool Preferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }
    }
}
