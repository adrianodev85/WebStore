namespace WebStore.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public string DescricaoDetalhada { get; set; }
        public double ValorUnitario { get; set; }
        public Categoria Categoria { get; set; }
        public string ImgUrl { get; set; }
        public string ImgThumbnailUrl { get; set; }
        public bool Preferido { get; set; }
        public bool EmEstoque { get; set; }
    }
}
