using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Api.Sistema.Estoque.Entidades.Entidades.Usuario.Entidades
{
    public class SituacaoUsuario
    {
        public int IdSituacaoUsuario { get; set; }

        [JsonIgnore]
        public string DescrisaoSituacaoUsuario { get; set; }

        public SituacaoUsuario(int idSituacaoUsuario, string descrisaoSituacaoUsuario)
        {
            IdSituacaoUsuario = idSituacaoUsuario;
            DescrisaoSituacaoUsuario = descrisaoSituacaoUsuario;
        }

        public SituacaoUsuario(){ }
    }
}
