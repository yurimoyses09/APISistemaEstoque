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

        ConexaoSQL SQL;
        public bool RetornoConexao { get; set; }

        public ConexaoSQL() { }

        /// <summary>
        /// Metodo que retorna string de conexao com sql
        /// </summary>
        /// <returns>string</returns>
        public string GetConnectionString()
        {
            return configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
        }

        /// <summary>
        /// Metodo resposavel por conectar com sql
        /// </summary>
        /// <param name="stringConnection"></param>
        /// <returns>bool</returns>
        public bool ConectaComSql(string stringConnection)
        {
            RetornoConexao = false;

            using SqlConnection connection = new SqlConnection(stringConnection);
            if (connection.State == System.Data.ConnectionState.Open)
                RetornoConexao = true;

            return RetornoConexao;
        }
    }
}
