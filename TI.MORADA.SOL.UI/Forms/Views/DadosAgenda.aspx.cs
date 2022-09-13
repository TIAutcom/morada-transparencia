using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.OBJETO.TRANSFERENCIA;
using TI.MORADA.SOL.REGRA.NEGOCIOS;

namespace TI.MORADA.SOL.UI.Forms.Views
{
    public partial class DadosAgendaaspx : System.Web.UI.Page
    {
        #region CLASSES E EOBJETOS

        Agendas agenda;
        AgendaRegraNegocios agendaRegraNegocios;

        #endregion

        #region VARIAVEIS

        public int idUsuario, idNivel = 0;
        int idAgenda = 0;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            idAgenda = Convert.ToInt32(Page.Request.QueryString["IdAgenda"]);

            GetDados();

            if (!IsPostBack)
            {
                PesquisarAgendaId();
            }
        }

        public void GetDados()
        {
            idUsuario = Convert.ToInt32(Session["IdUsuario"]);
            idNivel = Convert.ToInt32(Session["IdNivel"]);

            if (idUsuario != 0)
            {
                lblLogin.Text = "OPERADOR(A): " + "[ " + Session["Usuario"].ToString().ToUpper() + " ] - N: " + idNivel.ToString().PadLeft(2, '0');
                lblLogin.Visible = true;
            }
            else
            {
                lblLogin.Visible = false;
            }
        }

        public void PesquisarAgendaId()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                agendaRegraNegocios = new AgendaRegraNegocios();

                dadosTabela = agendaRegraNegocios.PesquisarAgendaId(idAgenda);

                if (dadosTabela.Rows.Count > 0)
                {
                    try
                    {
                        lblEvento.Text = dadosTabela.Rows[0]["Descricao"].ToString().Trim();
                        Local.Text = dadosTabela.Rows[0]["Local"].ToString().Trim();
                        Data.Text = dadosTabela.Rows[0]["DataDescricao"].ToString().Trim();
                        PublicoPresente.Text = dadosTabela.Rows[0]["PublicoPresente"].ToString().Trim();
                        PublicoEstimado.Text = dadosTabela.Rows[0]["PublicoEstimado"].ToString().Trim();
                        Descricao.Text = dadosTabela.Rows[0]["Descricao"].ToString().Trim();
                        Evento.Text = dadosTabela.Rows[0]["Contato"].ToString().Trim().ToUpper();
                        Sessao.Text = dadosTabela.Rows[0]["Sessao"].ToString().Trim().ToUpper();
                        Observacao.Text = dadosTabela.Rows[0]["Observacao"].ToString().ToUpper();

                        Site.Text = dadosTabela.Rows[0]["SiteCliente"].ToString().ToLower();
                    }
                    catch (Exception)
                    {
                        Site.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        public void AlterarDadosAgenda()
        {
            try
            {
                if (idAgenda <= 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção, Código da Agenda não pode Ser Nulou ou Zero')</script>");
                    PublicoEstimado.Focus();
                }
                else if (Convert.ToInt32(PublicoEstimado.Text) < 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção, Campo Público Presente não pode ser Zero')</script>");
                    PublicoEstimado.Focus();
                }
                else if (Convert.ToInt32(PublicoPresente.Text) < 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção, Campo Público Estimado da Agenda não pode ser Zero')</script>");
                    PublicoEstimado.Focus();
                }
                else if (Data.Text.Trim().Equals(""))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção, Campo Data do Evento não Pode ser Nulou ou Vázio.')</script>");
                    Data.Focus();
                }
                else if (Descricao.Text.Trim().Equals(""))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção, Campo Descrição do Evento não Pode ser Nulou ou Vázio.')</script>");
                    Data.Focus();
                }
                else
                {
                    agenda = new Agendas();
                    agendaRegraNegocios = new AgendaRegraNegocios();

                    agenda.Id = idAgenda;
                    agenda.IdUsuario = idUsuario;
                    agenda.PublicoPresente = Convert.ToInt32(PublicoPresente.Text);
                    agenda.PublicoEstimado = Convert.ToInt32(PublicoEstimado.Text);
                    agenda.Datas = Data.Text.Trim();
                    agenda.Contato = Evento.Text.Trim();
                    agenda.Descricao = Descricao.Text.Trim();
                    agenda.Observacao = Observacao.Text.Trim();
                    agenda.Sessao = Sessao.Text.Trim();
                    agenda.SiteCliente = Site.Text.Trim();

                    int idRet = agendaRegraNegocios.AlterarDadosAgenda(agenda);

                    if (idRet > 0)
                    {
                        Response.Write("<script>alert('Evento Inserido com Sucesso.'); window.location.href = window.location.href;</script>");
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Erro ao Alterar Dados da Agenda.')</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        public void DeletarAgenda()
        {
            try
            {
                agenda = new Agendas();
                agendaRegraNegocios = new AgendaRegraNegocios();

                agenda.Id = idAgenda;

                int idREt = agendaRegraNegocios.DeletarAgenda(agenda);

                if (idREt > 0)
                {
                    Response.Write("<script>alert('Evento Deletado com Sucesso.'); window.location.href = window.location.href;</script>");
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Erro ao Deletar Dados da Agenda.')</script>");
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }

            Response.Redirect("~/Forms/Views/Agenda.aspx");
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            AlterarDadosAgenda();
        }

        protected void Unnamed11_Click(object sender, EventArgs e)
        {
            DeletarAgenda();
        }

        protected void Unnamed10_Click(object sender, EventArgs e)
        {

        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            DeletarAgenda();
        }
    }
}