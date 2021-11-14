using Api.Sistema.Estoque.Entidades;
using ConfigConecao_SQL.Interfaces;
using GeradorLogsTXT;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ConfigConecao_SQL.Querys
{
    public class StringsQuerySQL : IMetodosSQL
    {
        #region Configuration
        private readonly IConfiguration configuration;

        public StringsQuerySQL(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        #endregion

        public StringsQuerySQL() { }

        ConexaoSQL conexao = new ConexaoSQL();
        GravaLog log = new GravaLog();

        string retornoQueryMsg = "";

        #region Metodos de Interface
        public string InserirDadosUsuarioSQL(Usuario usuario)
        {
            SqlConnection conexaoSQL = null;
            string StringConn = GetConnectionString();

            try
            {
                if (!string.IsNullOrEmpty(StringConn))
                {
                    log.GravaLogs("Conectando com SQL");
                    conexaoSQL = conexao.ConectaComSql(StringConn);

                    if (conexaoSQL.State == System.Data.ConnectionState.Open)
                    {
                        log.GravaLogs("Inserindo dados do usuario no SQL");
                        int retornoQuery = InsertUsuario(usuario, conexaoSQL);
                        log.GravaLogs("Verificando linhas afetadas");
                        if (retornoQuery > 0)
                        {
                            log.GravaLogs($"{retornoQuery} linha afetada");
                            retornoQueryMsg = "OK";
                        }
                        else
                        {
                            log.GravaLogs($"{retornoQuery} linha afetada");
                            retornoQueryMsg = "NOK";
                        }
                    }
                    else
                    {
                        log.GravaLogs("Conexao com SQL estava fechada");
                    }
                }
            }
            catch (Exception ex)
            {
                log.GravaLogs(ex.Message);
            }
            finally
            {
                if (conexaoSQL.State == System.Data.ConnectionState.Open)
                {
                    log.GravaLogs("Fechando conexao com sql");
                    conexaoSQL.Close();
                }
            }

            return retornoQueryMsg;
        }
        #endregion

        #region Comandos dos sql
        public int InsertUsuario(Usuario usuario, SqlConnection conexao)
        {
            log.GravaLogs("Montado query INSERT USUARIO no SQL");

            string commando = $@"
                                INSERT INTO TB_SISESTOQ_TB_USUARIO
                                (
                                    ID_USUARIO,
                                    NOME_USUARIO,
                                    ID_TIPO,
                                    ID_SITUACAO,
                                    SENHA_USUARIO,
                                    USUARIO_LOGIN,
                                    USUARIO_EMAIL,
                                    USUARIO_TELEFONE
                                )
                                VALUES(
                                    @idUsuario,
                                    @nomeUsuario,
                                    @tipoUsuario,
                                    @tipoSituacaoUsuario,
                                    @senhaUsuario,
                                    @loginUsuario,
                                    @usuarioEmail,
                                    @usuarioTelefone
                                )";

            SqlCommand command = new SqlCommand(commando, conexao);

            command.Parameters.AddWithValue("@idUsuario", GeraIdUsuario());
            command.Parameters.AddWithValue("@nomeUsuario", usuario.NomeUsuario);
            command.Parameters.AddWithValue("@tipoUsuario", usuario.IdTipo);
            command.Parameters.AddWithValue("@tipoSituacaoUsuario", usuario.IdSituacaoUsuario);
            command.Parameters.AddWithValue("@senhaUsuario", usuario.UsuarioSenha);
            command.Parameters.AddWithValue("@loginUsuario", usuario.UsuarioLogin);
            command.Parameters.AddWithValue("@usuarioEmail", usuario.UsuarioEmail);
            if (String.IsNullOrEmpty(usuario.UsuarioTelefone))
                command.Parameters.AddWithValue("@usuarioTelefone", DBNull.Value);
            else
                command.Parameters.AddWithValue("@usuarioTelefone", usuario.UsuarioTelefone);

            return command.ExecuteNonQuery(); ;
        }
        #endregion

        #region Obter string de conexao com sql
        /// <summary>
        /// Metodo que retorna string de conexao com sql
        /// </summary>
        /// <returns>string</returns>
        private string GetConnectionString()
        {
            return "Data Source=DESKTOP-DH4FP6N;Initial Catalog=BD_SIST_ESTOQUE; Trusted_Connection=True;Password=1234";
        }
        #endregion


        /// <summary>
        /// Metedo que gera ids de identificação
        /// </summary>
        /// <returns></returns>
        private int GeraIdUsuario()
        {
            Random randomId = new Random();
            return randomId.Next();
        }
    }
}
