using Microsoft.VisualStudio.TestTools.UnitTesting;
using Api.Sistema.Estoque;
using AutenticacaoJWT;
using Api.Sistema.Estoque.Controllers;
using Microsoft.Extensions.Configuration;
using AutenticacaoJWT.AutenticacaoJWT.Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api.Sistema.EstoqueTest
{
    [TestClass]
    public class AutorizacaoJWTtest
    {
        private readonly IConfiguration _configuration;
        readonly UsuarioAutenticacao usuario = new UsuarioAutenticacao();

        public AutorizacaoJWTtest(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public AutorizacaoJWTtest(IConfiguration configuration, UsuarioAutenticacao usuario) : this(configuration)
        {
            usuario.Nome = "Yuri";
            usuario.Senha = "1234";
        }

        [TestMethod]
        public async Task TesteRetornoTokenJWT()
        {
            AuthorizationJWTController auth = new AuthorizationJWTController(_configuration);

            var teste = new AutorizacaoJWTtest(_configuration);

            var retorno = auth.Login(usuario);

            await retorno;
        }
    }
}
