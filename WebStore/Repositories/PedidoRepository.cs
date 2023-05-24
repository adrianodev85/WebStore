using WebStore.Context;
using WebStore.Models;
using WebStore.Repositories.Interface;

namespace WebStore.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AppDbContext _context;
        public IEnumerable<Pedido> Pedidos => _context.Pedidos;

        public Pedido GetPedidoById(int id)
        {
            return _context.Pedidos.FirstOrDefault(p => p.PedidoId == id);
        }
    }
}
