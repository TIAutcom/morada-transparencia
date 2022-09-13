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
    public class TransparenciaRegraNegocios
    {
        Conexao conexaoSqlServer = new Conexao();

        public DataTable ListarAll(int idLai)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@Id", idLai);

                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTransparenciaAll");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Salvar(Transparencias transparencia)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@IdLai", transparencia.IdLai);
                conexaoSqlServer.AdicionarParametros("@Descricao", transparencia.Descricao);
                conexaoSqlServer.AdicionarParametros("@Ordem", transparencia.Ordem);
                conexaoSqlServer.AdicionarParametros("@IdUsuario", transparencia.IdUsuario);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTransparenciaSalvar").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisarTransparenciaId(int idTransp)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@Id", idTransp);

                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTransparenciaId");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
