using Componentes.Sistema.Estoque.Entidades.Pedidos;
using System;
using System.Collections.Generic;

namespace Api.Sistema.Estoque.Entidades.Pedidos
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public double ValorTotal { get; set; }
        public DateTime DataEntrega { get; set; }
        public int IdFornecedor { get; set; }
        public Usuario IdUsuario { get; set; }
        public StatusPedido IdStatus { get; set; }
        public List<Produto> Produtos { get; set; }

        public Pedido(int idPedido, double valorTotal, DateTime dataEntrega, int idFornecedor, Usuario idUsuario, StatusPedido idStatus, List<Produto> produtos)
        {
            IdPedido = idPedido;
            ValorTotal = valorTotal;
            DataEntrega = dataEntrega;
            IdFornecedor = idFornecedor;
            IdUsuario = idUsuario;
            IdStatus = idStatus;
            Produtos = produtos;
        }

        public Pedido() { }
    }
}
