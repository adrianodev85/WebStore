using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebStore.Models
{
    public class Venda
    {
        public int VendaId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataVenda { get; set; }

        [Display(Name = "Preço Total da Venda")]
        [Column(TypeName = "decimal(10,2)")]
        public double ValorVenda { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}
