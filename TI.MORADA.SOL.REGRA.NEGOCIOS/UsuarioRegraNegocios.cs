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
    public class UsuarioRegraNegocios
    {
        Conexao conexaoSqlServer = new Conexao();

        public DataTable ListarAll(string pesquidar)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@Nome", pesquidar);
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarUsuarioAll");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Salvar(Usuarios usuario)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@Nome", usuario.Nome);
                conexaoSqlServer.AdicionarParametros("@Email", usuario.Email);
                conexaoSqlServer.AdicionarParametros("@Senha", usuario.Senha);
                conexaoSqlServer.AdicionarParametros("@idTipoUsuario", usuario.TipoUsuario);
                conexaoSqlServer.AdicionarParametros("@Ativo", usuario.Ativo);
                conexaoSqlServer.AdicionarParametros("@IdNivel", usuario.IdNivel);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCadastroUsuario").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Logar(Usuarios usuario)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@Email", usuario.Email);
                conexaoSqlServer.AdicionarParametros("@Senha", usuario.Senha);

                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspLogarUsuario");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarId(int idUsuario)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@ID", idUsuario);
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarUsuarioId");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Alterar(Usuarios usuario)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@Id", usuario.Id);
                conexaoSqlServer.AdicionarParametros("@Nome", usuario.Nome);
                conexaoSqlServer.AdicionarParametros("@Email", usuario.Email);
                conexaoSqlServer.AdicionarParametros("@Senha", usuario.Senha);
                conexaoSqlServer.AdicionarParametros("@idTipoUsuario", usuario.TipoUsuario);
                conexaoSqlServer.AdicionarParametros("@Ativo", usuario.Ativo);
                conexaoSqlServer.AdicionarParametros("@IdNivel", usuario.IdNivel);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlterarUsuario").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Deletar(int id)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@Id", id);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspDeletarUsuario").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
