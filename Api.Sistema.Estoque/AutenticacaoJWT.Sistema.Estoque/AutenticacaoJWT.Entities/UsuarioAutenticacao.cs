namespace AutenticacaoJWT.AutenticacaoJWT.Entities
{
    public class UsuarioAutenticacao
    {
        public string Nome { get; set; }
        public string Senha { get; set; }


        public bool CheckUsuario(UsuarioAutenticacao usuario)
        {
            if (usuario.Nome.Equals("Yuri") && usuario.Senha.Equals("1234")) 
            {
                return true;
            }
            return false;
        }
    }

}
