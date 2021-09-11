using AutenticacaoJWT.AutenticacaoJWT.Entities;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace AutenticacaoJWT.AutenticacaoJWT.Services
{
    public class AuthJwtService
    {
        private const string Secret = "db3OIsj+BXE9NZDy0t8W3TcNekrF+2d/1sFnWG4HnV8TZY30iTOdtVWJG8abWvB1GlOgJuQZdcF2Luqm/hccMw==";

        public string GerarTokenAutenticacao(UsuarioAutenticacao usuario) 
        {
            var chaveSimetrica = Convert.FromBase64String(Secret);
            var tokenHandler = new JwtSecurityTokenHandler();

            var horaAtual = DateTime.UtcNow;
            var DescriptografarToken = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, usuario.Nome)
                }),

                Expires = horaAtual.AddMinutes(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(chaveSimetrica), SecurityAlgorithms.HmacSha256Signature)
            };

            var stoken = tokenHandler.CreateToken(DescriptografarToken);
            var token = tokenHandler.WriteToken(stoken);

            return token;
        }

    }
}
