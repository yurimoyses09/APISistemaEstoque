using Api.Sistema.Estoque.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigConecao_SQL.Interfaces
{
    public interface IMetodosSQL
    {
        public string InserirDadosUsuarioSQL(Usuario usuario);
    }
}
