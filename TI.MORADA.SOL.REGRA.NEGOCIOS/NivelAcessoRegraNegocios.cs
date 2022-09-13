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
    public class NivelAcessoRegraNegocios
    {
        Conexao conexaoSqlServer = new Conexao();

        public DataTable ListarNivelAcessoAll()
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarNivelAcessoAll");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
