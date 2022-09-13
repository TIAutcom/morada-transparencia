using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.OBJETO.TRANSFERENCIA;
using TI.MORADA.SOL.REGRA.NEGOCIOS;

namespace TI.MORADA.SOL.UI.Forms.Views
{
    public partial class Calendar : System.Web.UI.Page
    {
        #region CLASSES E OBJETOS

        AgendaRegraNegocios agendaRegraNegocios;
        Agendas agenda;
        DataTable dadosTabela = new DataTable();

        #endregion

        #region VARIAVEIS

        int idUsuario = 0;
        int tipoLocal = 0;
        string datas = "";

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarLocalEvento();
            }

            PesquisarData();
        }

        public void ListarLocalEvento()
        {
            try
            {
                idUsuario = Convert.ToInt32(Session["IdUsuario"]);

                if (idUsuario > 0)
                {
                    string arquivo = "";

                    arquivo = Server.MapPath("~\\Arquivos\\XMLs\\LOCAL_IMOVEL.xml");

                    if (arquivo != "")
                    {
                        DataSet dsContrato = new DataSet();
                        dsContrato.ReadXml(arquivo.ToString());

                        DataTable dadosTabela = new DataTable();
                        dadosTabela = dsContrato.Tables["Table1"];

                        ddlLocalEvento.DataSource = null;
                        ddlLocalEvento.DataSource = dadosTabela;
                        ddlLocalEvento.DataTextField = "DESCRICAO";
                        ddlLocalEvento.DataValueField = "DESCRICAO";
                        ddlLocalEvento.DataBind();
                    }
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Voltar", "history.back();", true);
                    return;
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            Literal litFeriado = new Literal();
            StringBuilder sbHtml = new StringBuilder();

            if (dadosTabela.Rows.Count > 0)
            {
                for (int i = 0; i < dadosTabela.Rows.Count; i++)
                {
                    int dia = Convert.ToDateTime(dadosTabela.Rows[i]["DataIni"].ToString()).Day;
                    int mes = Convert.ToDateTime(dadosTabela.Rows[i]["DataIni"].ToString()).Month;
                    int ano = Convert.ToDateTime(dadosTabela.Rows[i]["DataIni"].ToString()).Year;

                    if (e.Day.Date == new DateTime(ano, mes, dia))
                    {
                        string desc = "";
                        string imagem = "";

                        DateTime data1;
                        DateTime data2;

                        data1 = DateTime.Parse(dadosTabela.Rows[i]["DataIni"].ToString());
                        data2 = DateTime.Parse(DateTime.Now.Date.ToString());

                        if (data1.CompareTo(data2) == 1)
                        {
                            desc = "Agendado";
                            imagem = "http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Calendario/Agendado.png";
                        }
                        else
                        {
                            desc = "Realizado";
                            imagem = "http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Calendario/Realizado.png";
                        }

                        //sbHtml.Append("<br />");
                        //sbHtml.Append("<b>" + desc + "</b>");
                        sbHtml.Append("<br />");
                        sbHtml.Append("<img src='" + imagem + "'" + "width='35' heigth='35'>");

                        litFeriado.Text = sbHtml.ToString();
                        e.Cell.Controls.Add(litFeriado);
                    }
                }
            }
        }

        public void PesquisarData()
        {
            dadosTabela = new DataTable();
            agendaRegraNegocios = new AgendaRegraNegocios();
            dadosTabela = agendaRegraNegocios.ListarAgendaAll();
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            lblData.Text = datas = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
            Calendar1.SelectedDayStyle.BackColor = System.Drawing.Color.Green;

            PesquisarDatas();
        }

        public void SalvarAgenda()
        {
            try
            {
                if (lblData.Text.Trim().Equals(""))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção, Informe Data Desejada para Agendar Evento.')</script>");
                }
                else if (Convert.ToInt32(ddlLocalEvento.SelectedIndex) < 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção, Informe Local do Evento Desejado.')</script>");
                    ddlLocalEvento.Focus();
                }
                else if (txtHora.Text.Trim().Equals(""))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção, Informe Hora do Evento Desejado.')</script>");
                    txtHora.Focus();
                }
                else if (txtDescricao.Text.Trim().Equals(""))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção, Informe Descrição do Evento.')</script>");
                    txtDescricao.Focus();
                }
                else
                {
                    if (PesquisarDataLocalEvento() == true)
                    {
                        agenda = new Agendas();
                        agendaRegraNegocios = new AgendaRegraNegocios();

                        agenda.Descricao = txtDescricao.Text.Trim();
                        agenda.IdUsuario = Convert.ToInt32(Session["IdUsuario"]);
                        agenda.IdTipoImovel = ddlLocalEvento.SelectedIndex;
                        agenda.Local = ddlLocalEvento.Text;
                        agenda.Postagem = 0;
                        agenda.Contato = txtContato.Text.Trim();
                        agenda.DataInicio = Convert.ToDateTime(lblData.Text.ToString());
                        agenda.Datas = lblData.Text.Trim();
                        agenda.UrlImagem = "";
                        agenda.Ordem = Convert.ToDateTime(lblData.Text).Day;
                        agenda.SiteCliente = "";
                        agenda.Sessao = txtHora.Text.Trim();
                        agenda.PublicoEstimado = 0;
                        agenda.PublicoPresente = 0;
                        agenda.Observacao = "";
                        agenda.Status = -1;

                        //TABELA IMAGEM
                        agenda.Imagem = new Imagem();
                        agenda.Imagem.ImageName = "";
                        agenda.Imagem.Image = "";

                        int idRet = agendaRegraNegocios.Salvar(agenda);

                        if (idRet > 0)
                        {
                            Response.Write("<script>alert('Evento Inserido com Sucesso.'); window.location.href = window.location.href;</script>");
                        }
                        else
                        {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção, Erro ao Salvar Agenda de Programação.')</script>");
                            txtDescricao.Focus();
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Já Exite Evento Cadastrado Nessa Data e Local.'); window.location.href = window.location.href;</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            SalvarAgenda();
        }

        public bool PesquisarDataLocalEvento()
        {
            try
            {
                int idTipoLocal = Convert.ToInt32(ddlLocalEvento.SelectedIndex);

                agendaRegraNegocios = new AgendaRegraNegocios();

                DataTable dadosTabela = new DataTable();

                dadosTabela = agendaRegraNegocios.PesquisaAgendaDataLocalEvento(Convert.ToDateTime(lblData.Text), idTipoLocal);

                if (dadosTabela.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
                return false;
            }
        }

        protected void lbPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarData();
        }

        public void PesquisarDatas()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                agendaRegraNegocios = new AgendaRegraNegocios();

                dadosTabela = agendaRegraNegocios.PesquisaAgendaData(Convert.ToDateTime(datas));

                if (dadosTabela.Rows.Count > 0)
                {
                    gdvEventos.DataSource = null;
                    gdvEventos.DataSource = dadosTabela;
                    gdvEventos.DataBind();
                }
                else
                {
                    gdvEventos.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }
    }
}