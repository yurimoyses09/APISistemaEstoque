using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Sistema.Estoque.Entidades
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string NumeroProduto { get; set; }
        public double PrecoProduto { get; set; }
        public string DescrisaoProduto { get; set; }
        public int Quantidade { get; set; }

        public Produto(int idProduto, string numeroProduto, double precoProduto, string descrisaoProduto, int quantidade)
        {
            IdProduto = idProduto;
            NumeroProduto = numeroProduto;
            PrecoProduto = precoProduto;
            DescrisaoProduto = descrisaoProduto;
            Quantidade = quantidade;
        }

        public Produto() { }
    }
}
