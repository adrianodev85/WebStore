using WebStore.Context;
using WebStore.Models;
using WebStore.Repositories.Interface;

namespace WebStore.Repositories
{
    public class VendaRepository : IVendaRepository
    {
        private readonly AppDbContext _context;
        public IEnumerable<Venda> Vendas => _context.Vendas;

        public Venda GetVenById(int id)
        {
            return _context.Vendas.FirstOrDefault(v => v.VendaId == id);
        }
    }
}
