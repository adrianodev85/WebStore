using WebStore.Models;

namespace WebStore.Repositories.Interface
{
    public interface IVendaRepository
    {
        IEnumerable<Venda> Vendas { get; }
        Venda GetVenById(int id);
    }
}
