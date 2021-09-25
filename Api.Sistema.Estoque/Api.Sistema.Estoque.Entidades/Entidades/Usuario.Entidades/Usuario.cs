using Api.Sistema.Estoque.Entidades.Entidades.Usuario.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

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
        public int IdTipo { get; set; }
        public int IdSituacaoUsuario { get; set; }

        public Usuario(int idUsuario, string nomeUsuario, string usuarioSenha, string usuarioLogin, string usuarioEmail, string usuarioTelefone)
        {
            TipoUsuario tipo = new TipoUsuario();
            SituacaoUsuario situacao = new SituacaoUsuario();

            IdUsuario = idUsuario;
            NomeUsuario = nomeUsuario;
            UsuarioSenha = usuarioSenha;
            UsuarioLogin = usuarioLogin;
            UsuarioEmail = usuarioEmail;
            UsuarioTelefone = usuarioTelefone;
            IdTipo = tipo.IdTipo;
            IdSituacaoUsuario = situacao.IdSituacaoUsuario;
        }

        public Usuario() { }
    }
}
