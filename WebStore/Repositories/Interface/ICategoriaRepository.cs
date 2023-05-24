using WebStore.Models;

namespace WebStore.Repositories.Interface
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
