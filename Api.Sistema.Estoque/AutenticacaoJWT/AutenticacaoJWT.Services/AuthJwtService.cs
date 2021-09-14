using AutenticacaoJWT.AutenticacaoJWT.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AutenticacaoJWT.AutenticacaoJWT.Services
{
    public class AuthJwtService
    {
        private readonly IConfiguration _configuration;

        public AuthJwtService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<string> GerarTokenAutenticacao()
        {
            var issuer = _configuration["Jwt:Issuer"];
            var audience = _configuration["Jwt:Audience"];
            var expiry = DateTime.Now.AddMinutes(60);

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken
            (
                issuer: issuer,
                audience: audience,
                expires: expiry,
                signingCredentials: credentials
            );

            var tokenHandler = new JwtSecurityTokenHandler();
            var stringToken = tokenHandler.WriteToken(token);

            return stringToken;

        }

    }
}
