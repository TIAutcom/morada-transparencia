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
    public partial class AgendaCalendario : System.Web.UI.Page
    {
        DataTable dadosTabela = new DataTable();
        AgendaRegraNegocios agendaRegraNegocios;
        TipoImovelRegraNegocios tipoImovelRegraNegocios;
        Agendas agenda;

        int idUsuario, idTipoLocal = 0;
        string data = "";
        string arquivo = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Session["IdUsuario"]) > 0)
            {
                if (!IsPostBack)
                {
                    LoadTela();
                }
                else
                {
                    PesquisarData();
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Voltar", "history.back();", true);
                return;
            }
        }

        public void LoadTela()
        {
            LimparVariaveis();
            idUsuario = Convert.ToInt32(Session["IdUsuario"]);
            PesquisarData();
            PesquisarLocalEvento();
        }

        public void ListarLocalEvento()
        {
            try
            {
                arquivo = Server.MapPath("~\\Arquivos\\XMLs\\LOCAL_IMOVEL.xml");

                if (arquivo != "")
                {
                    DataSet dsContrato = new DataSet();
                    dsContrato.ReadXml(arquivo.ToString());

                    DataTable dadosTabela = new DataTable();
                    dadosTabela = dsContrato.Tables["Table1"];

                    ddlLocalEventos.DataSource = null;
                    ddlLocalEventos.DataSource = dadosTabela;
                    ddlLocalEventos.DataTextField = "DESCRICAO";
                    ddlLocalEventos.DataValueField = "ID";
                    ddlLocalEventos.DataBind();
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        public void PesquisarLocalEvento()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                tipoImovelRegraNegocios = new TipoImovelRegraNegocios();

                dadosTabela = tipoImovelRegraNegocios.PesquisarLocalEvento();

                if (dadosTabela.Rows.Count > 0)
                {
                    ddlLocalEventos.DataSource = null;
                    ddlLocalEventos.DataSource = dadosTabela;
                    ddlLocalEventos.DataTextField = "DESCRICAO";
                    ddlLocalEventos.DataValueField = "ID";
                    ddlLocalEventos.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        public void PesquisarData()
        {
            dadosTabela = new DataTable();
            agendaRegraNegocios = new AgendaRegraNegocios();
            dadosTabela = agendaRegraNegocios.ListarAgendaAll();
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            try
            {
                if (dadosTabela.Rows.Count > 0)
                {
                    for (int i = 0; i < dadosTabela.Rows.Count; i++)
                    {
                        int dia = Convert.ToDateTime(dadosTabela.Rows[i]["DataIni"].ToString()).Day;
                        int mes = Convert.ToDateTime(dadosTabela.Rows[i]["DataIni"].ToString()).Month;
                        int ano = Convert.ToDateTime(dadosTabela.Rows[i]["DataIni"].ToString()).Year;

                        if (e.Day.Date == new DateTime(ano, mes, dia))
                        {
                            DateTime data1;
                            DateTime data2;

                            data1 = DateTime.Parse(dadosTabela.Rows[i]["DataIni"].ToString());
                            data2 = DateTime.Parse(DateTime.Now.Date.ToString());

                            int comp = data1.CompareTo(data2);

                            if (comp == 1)
                            {
                                e.Cell.BackColor = System.Drawing.Color.Green;
                            }
                            else if (comp == 0)
                            {
                                e.Cell.BackColor = System.Drawing.Color.Yellow;
                            }
                            else
                            {
                                e.Cell.BackColor = System.Drawing.Color.Red;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            LimparVariaveis();
            lblData.Text = data = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
            Calendar1.SelectedDayStyle.BackColor = System.Drawing.Color.Blue;
            PesquisarDatas();
        }

        public void LimparVariaveis()
        {
            data = "";
        }

        public void SalvarAgenda()
        {
            try
            {
                if (lblData.Text.Trim().Equals(""))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção, Informe Data Desejada para Agendar Evento.')</script>");
                }
                else if (Convert.ToInt32(ddlLocalEventos.SelectedIndex) < 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção, Informe Local do Evento Desejado.')</script>");
                    ddlLocalEventos.Focus();
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
                        agenda.IdTipoImovel = Convert.ToInt32(ddlLocalEventos.SelectedValue);
                        agenda.Local = ddlLocalEventos.SelectedItem.Text;
                        agenda.Postagem = 0;
                        agenda.Contato = txtContato.Text.Trim();
                        agenda.DataInicio = Convert.ToDateTime(lblData.Text.ToString());
                        agenda.Datas = lblData.Text.Trim();
                        agenda.DataInicio = Convert.ToDateTime(lblData.Text);
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
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Já Exite Evento Cadastrado Nessa Data e Local..')</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        public bool PesquisarDataLocalEvento()
        {
            try
            {
                idTipoLocal = Convert.ToInt32(ddlLocalEventos.SelectedValue);
                agendaRegraNegocios = new AgendaRegraNegocios();
                DataTable dadosTabela = new DataTable();

                dadosTabela = agendaRegraNegocios.PesquisaAgendaDataLocalEvento(Convert.ToDateTime(lblData.Text), Convert.ToInt32(ddlLocalEventos.SelectedValue));

                if (dadosTabela.Rows.Count == 0)
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

        public void PesquisarDatas()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                agendaRegraNegocios = new AgendaRegraNegocios();

                dadosTabela = agendaRegraNegocios.PesquisaAgendaData(Convert.ToDateTime(data));

                if (dadosTabela.Rows.Count > 0)
                {
                    gdvEventos.DataSource = null;
                    gdvEventos.DataSource = dadosTabela;
                    gdvEventos.DataBind();
                }
                else
                {
                    gdvEventos.DataSource = null;
                    gdvEventos.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            SalvarAgenda();
        }
    }
}