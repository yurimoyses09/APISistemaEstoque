using Api.Sistema.Estoque.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesSistemaEstoque.MetodosValidaDados
{
    public interface IValidaDadosUsuario
    {
        public bool ValidaDadosUsuario(Usuario usuario);
    }
}
