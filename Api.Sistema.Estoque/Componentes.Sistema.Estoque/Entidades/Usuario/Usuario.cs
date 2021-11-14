using Api.Sistema.Estoque.Entidades.Entidades.Usuario.Entidades;
using Componentes.Sistema.Estoque;
using System.Text.Json.Serialization;

namespace Api.Sistema.Estoque.Entidades
{
    public class Usuario : IMetodosUsuario
    {
        //[JsonIgnore]
        //public int IdUsuario { get; set; }

        public string NomeUsuario { get; set; }
        public string UsuarioSenha { get; set; }
        public string UsuarioLogin { get; set; }
        public string UsuarioEmail { get; set; }
        public string UsuarioTelefone { get; set; }
        public int IdTipo { get; set; }
        public int IdSituacaoUsuario { get; set; }

        public Usuario(string nomeUsuario, string usuarioSenha, string usuarioLogin, string usuarioEmail, string usuarioTelefone, int idTipo, int idSituacaoUsuario)
        {
            NomeUsuario = nomeUsuario;
            UsuarioSenha = usuarioSenha;
            UsuarioLogin = usuarioLogin;
            UsuarioEmail = usuarioEmail;
            UsuarioTelefone = usuarioTelefone;
            IdTipo = idTipo;
            IdSituacaoUsuario = idSituacaoUsuario;
        }

        public Usuario() { }

        public bool ValidaDadosUsuario(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.NomeUsuario) || string.IsNullOrEmpty(usuario.UsuarioSenha) || string.IsNullOrEmpty(UsuarioLogin)) 
            {
                return false;
            }
            return true;
        }
    }
}
