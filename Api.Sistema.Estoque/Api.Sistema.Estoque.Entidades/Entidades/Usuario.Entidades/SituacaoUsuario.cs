using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Sistema.Estoque.Entidades.Entidades.Usuario.Entidades
{
    public class SituacaoUsuario
    {
        public int IdSituacaoUsuario { get; set; }
        public string DescrisaoSituacaoUsuario { get; set; }

        public SituacaoUsuario(int idSituacaoUsuario, string descrisaoSituacaoUsuario)
        {
            IdSituacaoUsuario = idSituacaoUsuario;
            DescrisaoSituacaoUsuario = descrisaoSituacaoUsuario;
        }

        public SituacaoUsuario(){ }
    }
}
