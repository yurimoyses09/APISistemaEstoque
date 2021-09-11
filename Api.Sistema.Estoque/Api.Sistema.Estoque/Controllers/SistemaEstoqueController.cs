using AutenticacaoJWT.AutenticacaoJWT.Entities;
using AutenticacaoJWT.AutenticacaoJWT.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace Api.Sistema.Estoque.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SistemaEstoqueController : Controller
    {
        [Route("[controller]/[action]/")]
        [HttpPost]
        public async Task<string> GetToken(UsuarioAutenticacao usuario)
        {
            AuthJwtService authJwt = new AuthJwtService();

            if (usuario.CheckUsuario(usuario)) 
            {
                return authJwt.GerarTokenAutenticacao(usuario);
            }
            throw new System.Web.Http.HttpResponseException(HttpStatusCode.Unauthorized);
        }
    }
}
