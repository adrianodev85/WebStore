using Microsoft.AspNetCore.Mvc;
using WebStore.Models;
using WebStore.Repositories.Interface;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {            
            _produtoRepository = produtoRepository;
        }

        public IActionResult List()
        {
            /*var produto = _produtoRepository.Produtos;
            return View(produto);*/

            var produtoListViewModel = new ProdutoListViewModel();
            produtoListViewModel.Produtos = _produtoRepository.Produtos;
            produtoListViewModel.CategoriaAtual = "Categoria Atual";

            return View(produtoListViewModel);
        }
    }
}
