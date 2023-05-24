using WebStore.Models;

namespace WebStore.Repositories.Interface
{
    public interface IPedidoRepository
    {
        IEnumerable<Pedido> Pedidos { get; }
        Pedido GetPedidoById(int id);
    }
}
