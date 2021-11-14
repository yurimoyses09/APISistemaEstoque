using GeradorLogsTXT;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;
using System.IO;

namespace ConfigConecao_SQL
{
    public class ConexaoSQL
    {
        #region Configuration
        private readonly IConfiguration configuration;

        public ConexaoSQL(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        #endregion

        readonly ConexaoSQL SQL;
        readonly GravaLog log = new GravaLog();

        public SqlConnection RetornoConexao { get; set; }

        public ConexaoSQL() { }

        /// <summary>
        /// Metodo resposavel por conectar com sql
        /// </summary>
        /// <param name="stringConnection"></param>
        /// <returns>bool</returns>
        public SqlConnection ConectaComSql(string stringConnection)
        {
            SqlConnection connection = new SqlConnection(stringConnection);

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    log.GravaLogs("Abrindo conexao com SQL");
                    connection.Open();
                }

            }
            catch (Exception ex)
            {
                log.GravaLogs($"Falha ao conetar com sql - {ex.Message}");
                throw ex;
            }

            return connection;

        }
    }
}
