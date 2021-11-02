using Api.Sistema.Estoque.Entidades;
using Componentes.Sistema.Estoque.Enums;
using ConfigConecao_SQL;
using GeradorLogsTXT;
using Microsoft.AspNetCore.Mvc;
using static Componentes.Sistema.Estoque.Enums.Enums_SistemaEstoque;

namespace Api.Sistema.Estoque.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]/[action]")]
    public class SistemaEstoqueController : Controller
    {
        GravaLog log = new GravaLog();

        [HttpPost]
        public string InsereUsuario(Usuario usuario) 
        {
            log.GravaLogs(LogsSistemaEstoque.acesssandoApiInsereUsuario.GetDescription());

            usuario = null;
            if (usuario == null)
            {
                log.GravaLogs(LogsSistemaEstoque.ValorNuloUsuario.GetDescription());
            }
            else 
            {
                // Fazer codigo para inserir dados de usuario no sql
            }

            log.GravaLogs(LogsSistemaEstoque.FimExecucao.GetDescription());
            return "";
        }
    }
}
