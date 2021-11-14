using Api.Sistema.Estoque.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Componentes.Sistema.Estoque
{
    public interface IMetodosUsuario
    {
        public bool ValidaDadosUsuario(Usuario usuario);
    }
}
