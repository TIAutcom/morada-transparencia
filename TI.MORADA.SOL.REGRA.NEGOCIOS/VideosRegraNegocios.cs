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
    public class VideosRegraNegocios
    {
        Conexao conexaoSqlServer = new Conexao();

        public DataTable ListarVideos()
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarVideos");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Salvar(Videos video)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@Nome", video.Nome);
                conexaoSqlServer.AdicionarParametros("@Url", video.Url);
                conexaoSqlServer.AdicionarParametros("@IdUsuario", video.IdUsuario);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCadastroVideo").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
