using Api.Sistema.Estoque.Entidades.Entidades.Usuario.Entidades;

namespace Api.Sistema.Estoque.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string UsuarioSenha { get; set; }
        public string UsuarioLogin { get; set; }
        public string UsuarioEmail { get; set; }
        public string UsuarioTelefone { get; set; }
        public TipoUsuario IdTipo { get; set; }
        public SituacaoUsuario IdSituacaoUsuario { get; set; }

        public Usuario(int idUsuario, string nomeUsuario, string usuarioSenha, string usuarioLogin, string usuarioEmail, string usuarioTelefone, TipoUsuario idTipo, SituacaoUsuario idSituacaoUsuario)
        {
            IdUsuario = idUsuario;
            NomeUsuario = nomeUsuario;
            UsuarioSenha = usuarioSenha;
            UsuarioLogin = usuarioLogin;
            UsuarioEmail = usuarioEmail;
            UsuarioTelefone = usuarioTelefone;
            IdTipo = idTipo;
            IdSituacaoUsuario = idSituacaoUsuario;
        }

        public Usuario() {}
    }
}
