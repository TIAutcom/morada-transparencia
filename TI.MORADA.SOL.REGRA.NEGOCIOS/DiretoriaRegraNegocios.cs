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
    public class DiretoriaRegraNegocios
    {
        Conexao conexaoSqlServer = new Conexao();

        public int idDiretor = 0;

        public DataTable ListarDiretoria()
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarDiretoriaCargoAll");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisarDiretorId(int idDiretor)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@ID", idDiretor);
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarDiretorId");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int SalvarDiretoria(Diretorias diretoria)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@Nome", diretoria.Nome);
                conexaoSqlServer.AdicionarParametros("@Cargo", diretoria.Cargo);
                conexaoSqlServer.AdicionarParametros("@Ulr", diretoria.Url);
                conexaoSqlServer.AdicionarParametros("@Descricao", diretoria.Descricao);
                conexaoSqlServer.AdicionarParametros("@IdUsuario", diretoria.IdUsuario);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspDiretoriaSalvar").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int SalvarDiretoriaCargo(Diretorias diretorias, int tag)
        {
            try
            {
                idDiretor = SalvarDiretor(diretorias);

                if (idDiretor > 0)
                {
                    SalvarCargoDiretoria(diretorias, tag);
                }

                return idDiretor;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int SalvarDiretor(Diretorias diretorias)
        {
            try
            {
                int ret = 0;

                conexaoSqlServer.LimparParametros();

                conexaoSqlServer.AdicionarParametros("@Nome", diretorias.Nome);
               // conexaoSqlServer.AdicionarParametros("@Cargo", diretorias.Cargos.Nome);
                conexaoSqlServer.AdicionarParametros("@Salario", diretorias.Salario);
                conexaoSqlServer.AdicionarParametros("@IdUsuario", diretorias.IdUsuario);
                conexaoSqlServer.AdicionarParametros("@Cpf", diretorias.Cpf);
                conexaoSqlServer.AdicionarParametros("@PisPasep", diretorias.PisPasep);
                conexaoSqlServer.AdicionarParametros("@Genero", diretorias.Genero);
                conexaoSqlServer.AdicionarParametros("@Escolaridade", diretorias.Cargos.Escolaridade);
                conexaoSqlServer.AdicionarParametros("@DataNascimento", diretorias.DtNascimento);
                conexaoSqlServer.AdicionarParametros("@Nascionalidade", diretorias.Nascionalidade);
                conexaoSqlServer.AdicionarParametros("@Especialidade", diretorias.Especialidade);
                conexaoSqlServer.AdicionarParametros("@Status", diretorias.Status);

                if (diretorias.Id > 0)
                {
                    conexaoSqlServer.AdicionarParametros("@Id", diretorias.Id);

                    ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspDiretoriaAlterar").ToString());
                }
                else
                {
                    conexaoSqlServer.AdicionarParametros("@Ulr", diretorias.Url);
                    conexaoSqlServer.AdicionarParametros("@Descricao", diretorias.Descricao);
                    conexaoSqlServer.AdicionarParametros("@Data", DateTime.Now.Date);
                    conexaoSqlServer.AdicionarParametros("@UrlCurriculo", diretorias.Url);

                    ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspDiretoriaCargoSalvar").ToString());
                }

                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int SalvarCargoDiretoria(Diretorias diretorias, int tag)
        {
            try
            {
                int ret = 0;

                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@IdDiretor", idDiretor);
                conexaoSqlServer.AdicionarParametros("@CodCargo", diretorias.Cargos.CodCargo);
                conexaoSqlServer.AdicionarParametros("@TipoCargo", diretorias.Cargos.TipoCargo);
                conexaoSqlServer.AdicionarParametros("@NomeCargo", diretorias.Cargos.Nome);
                conexaoSqlServer.AdicionarParametros("@RegimeJuridico", diretorias.Cargos.RegimeJuridico);
                conexaoSqlServer.AdicionarParametros("@Escolaridade", diretorias.Cargos.Escolaridade);
                conexaoSqlServer.AdicionarParametros("@ExercicioAtividade", diretorias.Cargos.ExercicioAtividade);
                conexaoSqlServer.AdicionarParametros("@FormaProvimento", diretorias.Cargos.FormaProvidencia);
                conexaoSqlServer.AdicionarParametros("@HrMensalTrab", diretorias.Cargos.HrMensalTrabalho);
                conexaoSqlServer.AdicionarParametros("@CargoPolitico", diretorias.Cargos.CargoPolitico);
                conexaoSqlServer.AdicionarParametros("@RespEntidade", diretorias.Cargos.RespEntidade);

                if (idDiretor == 0)
                {
                    ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspDiretoriaSalvarCargo").ToString());
                }
                else
                {
                    if (tag > 0)
                    {
                        ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspDiretoriaAlterarCargo").ToString());
                    }
                    else
                    {
                        ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspDiretoriaSalvarCargo").ToString());
                    }
                }

                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AlterCargoDiretoria(Diretorias diretorias)
        {
            try
            {
                //tabela cargo
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@IdDiretor", idDiretor);
                conexaoSqlServer.AdicionarParametros("@CodCargo", diretorias.Cargos.CodCargo);
                conexaoSqlServer.AdicionarParametros("@RegimeJuridico", diretorias.Cargos.RegimeJuridico);
                conexaoSqlServer.AdicionarParametros("@Escolaridade", diretorias.Cargos.Escolaridade);
                conexaoSqlServer.AdicionarParametros("@ExercicioAtividade", diretorias.Cargos.ExercicioAtividade);
                conexaoSqlServer.AdicionarParametros("@FormaProvimento", diretorias.Cargos.FormaProvidencia);
                conexaoSqlServer.AdicionarParametros("@HrMensalTrab", diretorias.Cargos.HrMensalTrabalho);
                conexaoSqlServer.AdicionarParametros("@CargoPolitico", diretorias.Cargos.CargoPolitico);
                conexaoSqlServer.AdicionarParametros("@RespEntidade", diretorias.Cargos.RespEntidade);

                int ret = 0;

                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspDiretoriaAlterCargo").ToString());

                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
