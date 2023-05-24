using WebStore.Models;

namespace WebStore.Repositories.Interface
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> Produtos { get; }
        IEnumerable<Produto> ProdutoPreferidos { get; }
        Produto GetProdById(int id);
    }
}
