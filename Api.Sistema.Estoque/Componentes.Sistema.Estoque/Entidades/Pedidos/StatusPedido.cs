using System;
using System.Collections.Generic;
using System.Text;

namespace Componentes.Sistema.Estoque.Entidades.Pedidos
{
    public class StatusPedido
    {
        public int Id_StatusPedido { get; set; }
        public string DescrisaoPedido { get; set; }

        public StatusPedido(int id_StatusPedido, string descrisaoPedido)
        {
            Id_StatusPedido = id_StatusPedido;
            DescrisaoPedido = descrisaoPedido;
        }

        public StatusPedido() { }
    }
}
