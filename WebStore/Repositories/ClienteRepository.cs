using WebStore.Context;
using WebStore.Models;
using WebStore.Repositories.Interface;

namespace WebStore.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _context;

        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Cliente> Clientes => _context.Clientes;

        public Cliente GetClientById(int id)
        {
            return _context.Clientes.FirstOrDefault(c => c.ClienteId == id);
        }
    }
}
