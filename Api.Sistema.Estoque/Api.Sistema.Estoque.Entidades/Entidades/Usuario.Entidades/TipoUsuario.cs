using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Sistema.Estoque.Entidades.Entidades.Usuario.Entidades
{
    public class TipoUsuario
    {
        public int IdTipo { get; set; }
        public string DescrisaoTipo { get; set; }

        public TipoUsuario(int idTipo, string descrisaoTipo)
        {
            IdTipo = idTipo;
            DescrisaoTipo = descrisaoTipo;
        }

        public TipoUsuario()
        {
        }
    }
}
