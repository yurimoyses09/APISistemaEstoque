using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Api.Sistema.Estoque.Entidades.Entidades.Usuario.Entidades
{
    public class TipoUsuario
    {
        public int IdTipo { get; set; }
        
        [JsonIgnore]
        public string DescrisaoTipo { get; set; }

        public TipoUsuario(int idTipo, string descrisaoTipo)
        {
            IdTipo = idTipo;
            DescrisaoTipo = descrisaoTipo;
        }

        public TipoUsuario(){ }
    }
}
