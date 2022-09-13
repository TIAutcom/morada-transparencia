using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.MORADA.SOLACESSO.DADOS
{
    public class Conexao
    {
        #region STRING CONEXAO SQL SERVER

        private static string conexao = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

        public static string StringConexao
        {
            get { return conexao; }
        }

        private SqlConnection CriarConexao()
        {
            return new SqlConnection(conexao);
        }

        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }


        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(nomeParametro, valorParametro);
        }

        public object ExecutarManipulacao(CommandType commandType, string nomeStoreProcedureOuTextoSql)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexao();

                sqlConnection.Open();

                SqlCommand sqlComando = sqlConnection.CreateCommand();

                sqlComando.CommandType = commandType;
                sqlComando.CommandText = nomeStoreProcedureOuTextoSql;
                sqlComando.CommandTimeout = 7200;

                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlComando.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                return sqlComando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoreProcedureOuTextoSql)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexao();

                sqlConnection.Open();

                SqlCommand sqlComando = sqlConnection.CreateCommand();

                sqlComando.CommandType = commandType;

                sqlComando.CommandText = nomeStoreProcedureOuTextoSql;
                sqlComando.CommandTimeout = 7200;

                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlComando.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlComando);

                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}
