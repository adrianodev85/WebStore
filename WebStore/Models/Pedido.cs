namespace WebStore.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public int QtdaPedido { get; set; }
        public double ValorPedido { get; set; }
        public Produto Produto { get; set; }
    }
}
