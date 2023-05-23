namespace WebStore.Models
{
    public class Venda
    {
        public int VendaId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataVenda { get; set; }
        public double ValorVenda { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}
