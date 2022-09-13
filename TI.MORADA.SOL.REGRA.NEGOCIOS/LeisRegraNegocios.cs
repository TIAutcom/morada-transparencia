using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.MORADA.SOL.OBJETO.TRANSFERENCIA;
using TI.MORADA.SOLACESSO.DADOS;

namespace TI.MORADA.SOL.REGRA.NEGOCIOS
{
    public class LeisRegraNegocios
    {
        Conexao conexaoSqlServer = new Conexao();

        public DataTable ListarAll()
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@Descricao", "");
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarLaiAll");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarLaiId(int id)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@Id", id);
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarLaiId");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string Salvar(Leis lei)
        {
            try
            {
                conexaoSqlServer.LimparParametros();

                conexaoSqlServer.AdicionarParametros("@Descricao", lei.Descricao);
                conexaoSqlServer.AdicionarParametros("@IdUsuario", lei.IdUsuario);

                String ret = "";
                ret = conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCadastroLai").ToString();
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string Deletar(int id)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@Id", id);

                String ret = "";
                ret = conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspLaiDeletar").ToString();
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
