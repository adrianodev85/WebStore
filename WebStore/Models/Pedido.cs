using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebStore.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public int QtdaPedido { get; set; }

        [Display(Name = "Preço Total Item")]
        [Column(TypeName = "decimal(10,2)")]
        public double ValorPedido { get; set; }
        public Produto Produto { get; set; }
    }
}
