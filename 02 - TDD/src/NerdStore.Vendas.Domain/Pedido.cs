using System.Collections.Generic;
using System.Linq;

namespace NerdStore.Vendas.Domain
{
    public class Pedido
    {
        public Pedido()
        {
            _pedidoItems = new List<PedidoItem>();
        }

        public decimal ValorTotal { get; private set; }

        // sempre que for trabalhar com a coleção, vai trabalhar com a lista privada, e a ReadOnlyCollection retorna a minha lista privada
        //  somente leitura, então não tem como alguém manipular essa lista por fora a não ser chamando algum método que realmente muda o estado dessa lista;
        private readonly List<PedidoItem> _pedidoItems;
        public IReadOnlyCollection<PedidoItem> PedidoItems => _pedidoItems;

        public void AdicionarItem(PedidoItem pedidoItem)
        {
            _pedidoItems.Add(pedidoItem);
            ValorTotal = PedidoItems.Sum(i => i.Quantidade * i.ValorUnitario);
        }
    }
}
