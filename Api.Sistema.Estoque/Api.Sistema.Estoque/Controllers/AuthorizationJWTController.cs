using AutenticacaoJWT.AutenticacaoJWT.Entities;
using AutenticacaoJWT.AutenticacaoJWT.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace Api.Sistema.Estoque.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AuthorizationJWTController : Controller
    {
        private readonly IConfiguration _configuration;

        public AuthorizationJWTController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<ActionResult> Login ([FromBody] UsuarioAutenticacao usuario)
        {
            bool result = usuario.CheckUsuario(usuario);
            if(result)
            {
                AuthJwtService authJwt = new AuthJwtService(_configuration);
                return Ok(new
                {
                    token = await authJwt.GerarTokenAutenticacao(),
                    title = Ok(),
                    Data = DateTime.UtcNow
                }); ;
            }

            return Unauthorized();

        }
    }
}
