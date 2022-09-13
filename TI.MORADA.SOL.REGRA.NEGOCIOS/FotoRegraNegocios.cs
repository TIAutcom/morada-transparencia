using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.MORADA.SOLACESSO.DADOS;
using TI.MORADA.SOL.OBJETO.TRANSFERENCIA;

namespace TI.MORADA.SOL.REGRA.NEGOCIOS
{
    public class FotoRegraNegocios
    {
        Conexao conexaoSqlServer = new Conexao();

        public DataTable ListarFoto(int idTipo)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@ID_TIPO", idTipo);
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarFotoId");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string Salvar(Foto foto)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@ID_TIPO", foto.IdTipo);
                conexaoSqlServer.AdicionarParametros("@URL", foto.Url);
                conexaoSqlServer.AdicionarParametros("@TITULO", foto.Titulo);
                conexaoSqlServer.AdicionarParametros("@DESCRICAO", foto.DEscricao);
                conexaoSqlServer.AdicionarParametros("@DATA", foto.Data);
                conexaoSqlServer.AdicionarParametros("@ID_USUARIO", foto.IdUsuario);

                String ret = "";
                ret = conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspFotoSalvar").ToString();
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarFotos()
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspFotoAdmListarAll");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GerarXmlFotos(string titulo, string urlFoto, bool hr)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("<a class='example-image-link' style='height: 500px; width: 500px;' href='" + urlFoto + "' data-lightbox='example-set' data-title='" + titulo + "'>");
                sb.Append("<img class='example-image' style='height: 200px; width: 375px;' src='" + urlFoto + "' alt='' />");
                sb.Append("</a>");
                sb.Append("&nbsp");

                if (hr == true)
                {
                    sb.Append("<hr/>");
                }

                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int SalvarFoto(string titulo, string navegador, int idUsuario, int idGaleria)
        {
            try
            {
                conexaoSqlServer.LimparParametros();

                conexaoSqlServer.AdicionarParametros("@Titulo", titulo);
                conexaoSqlServer.AdicionarParametros("@Url", navegador);
                conexaoSqlServer.AdicionarParametros("@IdAdm", idGaleria);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAdmFotoSalvar").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int SalvarFoto(string v, string navegador, int idUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
