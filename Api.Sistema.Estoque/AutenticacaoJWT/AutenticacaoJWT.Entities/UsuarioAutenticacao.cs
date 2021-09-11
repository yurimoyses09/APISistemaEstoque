using System;
using System.Collections.Generic;
using System.Text;

namespace AutenticacaoJWT.AutenticacaoJWT.Entities
{
    public class UsuarioAutenticacao
    {
        public string Nome { get; set; }
        public string Email { get; set; }


        public bool CheckUsuario(UsuarioAutenticacao usuario)
        {
            if (usuario.Nome.Equals("Yuri") && usuario.Email.Equals("yuri@gmail.com")) 
            {
                return true;
            }
            return false;
        }
    }

}
