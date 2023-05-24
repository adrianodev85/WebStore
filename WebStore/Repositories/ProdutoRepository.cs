using Microsoft.EntityFrameworkCore;
using WebStore.Context;
using WebStore.Models;
using WebStore.Repositories.Interface;

namespace WebStore.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Produto> Produtos => _context.Produtos.Include(p => p.Categoria);

        public IEnumerable<Produto> ProdutoPreferidos => _context.Produtos.Where(p => p.Preferido == true).Include(c => c.Categoria);

        public Produto GetProdById(int id)
        {
            return _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);
        }
    }
}
