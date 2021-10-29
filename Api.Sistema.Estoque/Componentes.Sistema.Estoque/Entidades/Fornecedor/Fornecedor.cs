using System;
using System.Collections.Generic;
using System.Text;

namespace Componentes.Sistema.Estoque.Entidades.Fornecedor
{
    public class Fornecedor
    {
        public int Id_Fornecedor { get; set; }
        public string NomeFornecedor { get; set; }
        public string CNPJFornecedor { get; set; }

        public Fornecedor(int id_Fornecedor, string nomeFornecedor, string cNPJFornecedor)
        {
            Id_Fornecedor = id_Fornecedor;
            NomeFornecedor = nomeFornecedor;
            CNPJFornecedor = cNPJFornecedor;
        }

        public Fornecedor() { }
    }
}
