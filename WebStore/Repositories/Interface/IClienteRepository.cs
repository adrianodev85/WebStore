using WebStore.Models;

namespace WebStore.Repositories.Interface
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> Clientes { get; }
        Cliente GetClientById(int id);
    }
}
