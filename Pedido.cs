namespace Exercício_de_FixaçãoPOO
{
    public class Pedido
    {
        public string Itens { get; set; }

        public string Cliente { get; set; }

        public string Restaurante { get; set; }

        public string FormaPGTO { get; set; }

        public string Pagamento { get; set; }

        public bool PedidoPago(){
            if(Pagamento != null){
                return true;
            }
                return false;   
        }

        public string EntregarPedido(){
            return $"Seu pedido foi entregue por {Restaurante}, para o cliente {Cliente}";
        }
    }
}