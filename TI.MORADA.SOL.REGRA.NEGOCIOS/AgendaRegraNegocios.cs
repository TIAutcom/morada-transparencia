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
    public class AgendaRegraNegocios
    {
        Conexao conexaoSqlServer = new Conexao();

        public DataTable ListarAgenda(int mes, int ano)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@MES", mes);
                conexaoSqlServer.AdicionarParametros("@ANO", ano);
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListaraAgendaData");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarAgendamento()
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarAgendamento");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarAdm()
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarAdm");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarAgendaAll()
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListaraAgendaAll");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Salvar(Agendas agenda)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@Descricao", agenda.Contato);
                conexaoSqlServer.AdicionarParametros("@Local", agenda.Local);
                conexaoSqlServer.AdicionarParametros("@IdUsuario", agenda.IdUsuario);
                conexaoSqlServer.AdicionarParametros("@IdTipoImovel", agenda.IdTipoImovel);
                conexaoSqlServer.AdicionarParametros("@DataDescricao", agenda.Datas);
                conexaoSqlServer.AdicionarParametros("@Postagem", agenda.Postagem);
                conexaoSqlServer.AdicionarParametros("@Contato", agenda.Descricao);
                conexaoSqlServer.AdicionarParametros("@SiteCliente", agenda.SiteCliente);
                conexaoSqlServer.AdicionarParametros("@DataIni", agenda.DataInicio);
                conexaoSqlServer.AdicionarParametros("@PublicoEstimado", agenda.PublicoEstimado);
                conexaoSqlServer.AdicionarParametros("@PublicoPresente", agenda.PublicoPresente);
                conexaoSqlServer.AdicionarParametros("@Observacao", agenda.Observacao);
                conexaoSqlServer.AdicionarParametros("@Ordem", agenda.Ordem);
                conexaoSqlServer.AdicionarParametros("@Status", agenda.Status);

                //CADASTRO TABELA IMAGEM
                conexaoSqlServer.AdicionarParametros("@ImageName", agenda.Imagem.ImageName);
                conexaoSqlServer.AdicionarParametros("@Image", agenda.Imagem.Image);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCadastroEvento").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarAgendaAno(int ano)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@ANO", ano);
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListaraAgendaDataAno");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string MontarHtmlDetalhes(string site, string evento, string local, string detalhe, string sessao, string data, string url)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                //sb.Append("<div class='col-12 col-md-6 mb-4'>");
                sb.Append("<div class='col-12'>");
                sb.Append("<div class='card h-100'>");

                if (site.Trim().Equals(""))
                {
                    sb.Append("<a href='#' data-toggle='tooltip' data-placement='right' title='Link para Site do Contato'><img class='card-img-top' src='" + url + "'style='height:300px;' alt='Traffic' data-toggle='tooltip' data-placement='right' title='Link para Site do Contato'></a>");
                }
                else
                {
                    sb.Append("<a href='" + site + " 'target='_blank' data-toggle='tooltip' data-placement='right' title='Link para Site do Contato'><img class='card-img-top' src='" + url + "'style='height:300px;' alt='Traffic'></a>");
                }

                sb.Append("<br/>");
                sb.Append("<div class='card-body'>");
                sb.Append("<h4 class='card-title'>");

                if (site.Trim().Equals(""))
                {
                    sb.Append("<a href='#' data-toggle='tooltip' data-placement='right' title='Link para Site do Contato'>" + evento + "</a>");
                }
                else
                {
                    sb.Append("<a href='" + site + " 'target='_blank' data-toggle='tooltip' data-placement='right' title='Link para Site do Contato'>" + evento + "</a>");
                }

                sb.Append("</h4>");
                sb.Append("<h5>Horario: " + sessao + "</h5>");
                sb.Append("<h5>Data: " + data + "</h5>");
                sb.Append("<p class='card-text'>LOCAL: CEAR - Centro de Convenção/" + local + "</p>");
                sb.Append("Eventos: " + detalhe);
                sb.Append("</div>");
                sb.Append("<div class='card-footer'>");
                sb.Append("<small class='text-muted'>&#9733; &#9733; &#9733; &#9733; &#9734;</small>");
                sb.Append("</div>");

                sb.Append("</div>");
                sb.Append("</div>");

                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string MontarHtmlModal(string site, string evento, string local, string detalhe, string sessao, string data, string url)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<div class='container'>");

            sb.Append("<!-- The Modal -->");
            sb.Append("<div class='modal' id='1'>");
            sb.Append("<div class='modal-dialog'>");
            sb.Append("<div class='modal-content'>");

            sb.Append("<!-- Modal Header -->");
            sb.Append("<div class='modal-header'>");
            sb.Append("<h4 class='modal-title'>Modal Heading");
            sb.Append("</h4>");
            sb.Append("<button type='button' class='close' data-dismiss='modal'>&times;</button>");
            sb.Append("</div>");

            sb.Append("< !-- Modal body -->");
            sb.Append("< div class='modal-body'>");

            sb.Append("<div class='card' style='width: 400px'>");
            sb.Append("<a href='http://www.google.com.br'>");
            sb.Append("<img class='card-img-top' src='http://moradaturismoeventos.com.br/Arquivos/Imagem/Agenda/4amigos.jpg' alt='Card image' style='width: 100%'>");
            sb.Append("</a>");
            sb.Append("<div class='card-body'>");
            sb.Append("<h4 class='card-title'>" + evento + "</h4>");
            sb.Append("<p class='card-text'>Some example text some example text.John Doe is an architect and engineer..........</p>");
            sb.Append("<a href='#' class='btn btn-primary'>See Profile</a>");
            sb.Append("</div>");
            sb.Append("</div>");
            sb.Append("</div>");
            sb.Append("</div>");
            sb.Append("</div>");
            sb.Append("</div>");
            sb.Append("</div>");

            return sb.ToString();
        }

        public int Salvar(Administracao agenda)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@IdLocal", agenda.IdLocal);
                conexaoSqlServer.AdicionarParametros("@IdUsuario", agenda.IdUsuario);
                conexaoSqlServer.AdicionarParametros("@DataCad", agenda.DataCad);
                conexaoSqlServer.AdicionarParametros("@DataEvento", agenda.DataEvento);
                conexaoSqlServer.AdicionarParametros("@Descricao", agenda.Descricao);
                conexaoSqlServer.AdicionarParametros("@IdTipoEvento", agenda.IdTipoEvento);
                conexaoSqlServer.AdicionarParametros("@HoraEvento", agenda.HoraEvento);
                conexaoSqlServer.AdicionarParametros("@PublicoEstimado", agenda.PubEstimado);
                conexaoSqlServer.AdicionarParametros("@PublicoPresente", agenda.PubPresente);
                conexaoSqlServer.AdicionarParametros("@PercPubFamilia", agenda.PercPubFamilia);
                conexaoSqlServer.AdicionarParametros("@PercPubJovem", agenda.PercPublicoJovem);
                conexaoSqlServer.AdicionarParametros("@PercPubCasal", agenda.PercPublicoCasal);
                conexaoSqlServer.AdicionarParametros("@Regiao", agenda.Regiao);
                conexaoSqlServer.AdicionarParametros("@Cidade", agenda.Cidade);
                conexaoSqlServer.AdicionarParametros("@Obs", agenda.Obs);
                conexaoSqlServer.AdicionarParametros("@UrlImagem", agenda.UrlImagem);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAdmSalvar").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int DeletarAgenda(Agendas agenda)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@IdAgenda", agenda.Id);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspDeletarEvento").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AlterarDadosAgenda(Agendas agenda)
        {
            try
            {
                conexaoSqlServer.LimparParametros();

                //conexaoSqlServer.AdicionarParametros("@IdUsuario", agenda.IdUsuario);
                conexaoSqlServer.AdicionarParametros("@PublicoEstimado", agenda.PublicoEstimado);
                conexaoSqlServer.AdicionarParametros("@PublicoPresente", agenda.PublicoPresente);
                conexaoSqlServer.AdicionarParametros("@DataDescricao", agenda.Datas);
                conexaoSqlServer.AdicionarParametros("@Descricao", agenda.Descricao);
                conexaoSqlServer.AdicionarParametros("@Observacao", agenda.Observacao);
                conexaoSqlServer.AdicionarParametros("@Contato", agenda.Contato);
                conexaoSqlServer.AdicionarParametros("@SiteCliente", agenda.SiteCliente);
                conexaoSqlServer.AdicionarParametros("@Sessao", agenda.Sessao);
                conexaoSqlServer.AdicionarParametros("@Id", agenda.Id);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlterarEvento").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisaAgendaDataLocalEvento(DateTime datas, int idTipoLocal)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@DataIni", datas);
                conexaoSqlServer.AdicionarParametros("@IdTipoImovel", idTipoLocal);

                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspAgendaDataLocalEvento");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisarAgendaId(int idAgenda)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@Id", idAgenda);

                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspAgendaListarDetalhesId");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisaAgendaData(DateTime datas)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@Data", datas);

                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspAgendaPesquisarData");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
