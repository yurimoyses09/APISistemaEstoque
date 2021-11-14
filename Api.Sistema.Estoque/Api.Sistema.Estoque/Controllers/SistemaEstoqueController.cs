using Api.Sistema.Estoque.Entidades;
using Componentes.Sistema.Estoque.Enums;
using ConfigConecao_SQL.Querys;
using GeradorLogsTXT;
using Microsoft.AspNetCore.Mvc;
using System;
using static Componentes.Sistema.Estoque.Enums.Enums_SistemaEstoque;

namespace Api.Sistema.Estoque.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]/[action]")]
    public class SistemaEstoqueController : Controller
    {
        readonly GravaLog log = new GravaLog();
        readonly StringsQuerySQL SQL = new StringsQuerySQL();

        [HttpPost]
        public string InsereUsuario(Usuario usuario)
        {
            log.GravaLogs("=============================================");
            log.GravaLogs("Executando API InsereUsuario");

            if (usuario == null)
            {
                log.GravaLogs("Valor nulo para dados de Usuario");
            }
            else
            {
                try
                {
                    log.GravaLogs("Validando dados do usuario");

                    bool validaDados = usuario.ValidaDadosUsuario(usuario);
                    if (validaDados)
                    {
                        log.GravaLogs("Dados validados com sucesso");

                        log.GravaLogs("Inserindo dados do usuario no bando de dados");
                        string retornoQuery = SQL.InserirDadosUsuarioSQL(usuario);
                        if (retornoQuery.Equals("OK"))
                        {
                            log.GravaLogs("Usuario inserido com sucesso");
                        }
                        else
                        {
                            log.GravaLogs("Falha ao inserir usuario no banco");
                        }
                    }
                    else
                    {
                        log.GravaLogs("Campos obrigatorios estao vazios");
                    }
                } catch (Exception ex) 
                {
                    log.GravaLogs(ex.Message);
                }
                
            }

            log.GravaLogs(LogsSistemaEstoque.FimExecucao.GetDescription());
            log.GravaLogs("=============================================");
            return "";
        }
    }
}
