using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.OBJETO.TRANSFERENCIA;
using TI.MORADA.SOL.REGRA.NEGOCIOS;

namespace TI.MORADA.SOL.UI.Cadastros
{
    public partial class Agenda : System.Web.UI.Page
    {
        #region VARIAVEIS

        int idUsuario, idNivel = 0;
        public int idAgenda = 0;
        public string[] arquivo;
        public string dataInicial;
        string nomeArquivo = "";

        #endregion

        #region CLASSES E OBJETOS

        Hashtable ListaData;
        Agendas agenda;
        AgendaRegraNegocios agendaRegraNegocios;
        TipoImovelRegraNegocios tipoImovelRegraNegocios;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["IdUsuario"] == null)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Voltar", "history.back();", true);

                return;
            }
            else
            {
                GetDados();

                ListarLocalEvento();
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

        public void ListarLocalEvento()
        {
            try
            {
                idUsuario = Convert.ToInt32(Session["IdUsuario"]);

                if (idUsuario > 0)
                {
                    tipoImovelRegraNegocios = new TipoImovelRegraNegocios();
                    DataTable dadosTabela = new DataTable();

                    dadosTabela = tipoImovelRegraNegocios.PesquisarLocalEvento();

                    if (dadosTabela.Rows.Count > 0)
                    {
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

        public void Salvar()
        {
            try
            {
                if (ddlLocalEvento.SelectedIndex == 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('* Campo Local do Evento é Obrigatório.')</script>");
                    ddlLocalEvento.Focus();
                }
                else if (Dias.Text.Trim().Equals(""))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('* Data do Evento é Campo Obrigatório.')</script>");
                }
                else if (Eventos.Text.Trim().Equals(""))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('* Campo Descrição do Evento é Obrigatório.')</script>");
                    Eventos.Focus();
                }
                else if (DropDownList1.SelectedIndex == 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('* Campo Postagem do Evento é Obrigatório.')</script>");
                }
                else if (fupImagem.FileName.Trim().Equals(""))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('* Imagem Evento é Obrigatório.')</script>");
                }
                else
                {
                    nomeArquivo = Path.GetFileName(fupImagem.PostedFile.FileName);

                    agenda = new Agendas();
                    agendaRegraNegocios = new AgendaRegraNegocios();

                    agenda.Descricao = Eventos.Text.Trim();
                    agenda.IdUsuario = Convert.ToInt32(Session["IdUsuario"]);
                    agenda.IdTipoImovel = ddlLocalEvento.SelectedIndex;
                    agenda.Local = ddlLocalEvento.Text;
                    agenda.Datas = Dias.Text.Trim();
                    agenda.Postagem = DropDownList1.SelectedIndex;
                    agenda.UrlImagem = ("~/Arquivos/Imagem/Agenda/" + nomeArquivo);
                    agenda.Contato = Contato.Text.Trim();
                    agenda.SiteCliente = SiteContato.Text.Trim();

                    if ((PubEstimado.Text.Trim() == null) || (PubEstimado.Text.Trim().Equals("")))
                    {
                        agenda.PublicoEstimado = 0;
                    }
                    else
                    {
                        agenda.PublicoEstimado = Convert.ToInt32(PubEstimado.Text.Trim());
                    }

                    if ((PubPresente.Text.Trim() == null) || (PubPresente.Text.Trim().Equals("")))
                    {
                        agenda.PublicoPresente = 0;
                    }
                    else
                    {
                        agenda.PublicoPresente = Convert.ToInt32(PubPresente.Text.Trim());
                    }

                    agenda.Observacao = Observacao.Text.Trim();
                    agenda.Status = -1;

                    var palavras = Dias.Text.Split(',');
                    var palavra = palavras[0];

                    agenda.Ordem = Convert.ToDateTime(palavra).Day;

                    agenda.Imagem = new Imagem();

                    string filename = Path.GetFileName(fupImagem.PostedFile.FileName);

                    fupImagem.SaveAs(Server.MapPath("~/Arquivos/Imagem/Agenda/" + filename));

                    agenda.Imagem.ImageName = ("http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Agenda/" + filename);
                    agenda.Imagem.Image = "~/Arquivos/Imagem/Agenda/" + filename;

                    #region CADASTRO DATA INICIAL

                    //PEGAR A PRIMEIDA DATA DE CALECAO
                    agenda.DataInicio = Convert.ToDateTime(palavra);

                    #endregion

                    idAgenda = agendaRegraNegocios.Salvar(agenda);

                    if (idAgenda > 0)
                    {
                        Response.Write("<script>alert('Evento Inserido com Sucesso.'); window.location.href = window.location.href;</script>");
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Erro ao Inserir Dados do Evento.')</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Session.Clear();
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            try
            {
                if (ListaData[e.Day.Date.ToShortDateString()] != null)
                {
                    Literal literal1 = new Literal();
                    literal1.Text = "<br/>";
                    e.Cell.Controls.Add(literal1);
                    //cor de fundo da célula
                    e.Cell.BackColor = Color.Black;
                    //cor da fonte da célula
                    e.Cell.ForeColor = Color.White;

                    //Cria um label
                    Label label1 = new Label();
                    label1.Text = (string)ListaData[e.Day.Date.ToShortDateString()];
                    label1.Font.Name = "Trebuchet MS";
                    label1.Font.Size = new FontUnit(FontSize.Medium);
                    label1.ForeColor = System.Drawing.Color.Green;
                    label1.Font.Bold = true;

                    e.Cell.Controls.Add(label1);
                }
            }
            catch
            {
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DataIni.Text = Calendar1.SelectedDate.ToShortDateString();

            int dia = Convert.ToDateTime(DataIni.Text).Day;
            int mes = Convert.ToDateTime(DataIni.Text).Month;
            int ano = Convert.ToDateTime(DataIni.Text).Year;


            Dias.Text += DataIni.Text.Trim() + ", ";

            Cores();

            ListaData = SelecionaDias(ObterData());
        }

        private Hashtable SelecionaDias(List<DateTime> Lista)
        {
            Hashtable Datas = new Hashtable();

            foreach (var item in Lista)
            {
                Datas[item.ToShortDateString()] = "Reservado";
            }
            return Datas;
        }

        public List<DateTime> ObterData()
        {
            List<DateTime> lista = new List<DateTime>();

            try
            {
                string str = null;
                string dia, mes = "";
                string[] strArr = null;

                str = Dias.Text.Trim();
                char[] splitchar = { ',' };
                strArr = str.Split(splitchar);

                dia = str.Substring(0, 2);
                mes = str.Substring(2, 4).Replace("/", "").Replace(",", "");

                foreach (var item in strArr)
                {
                    if (item != "")
                    {
                        lista.Add(Convert.ToDateTime(item));
                    }
                }

                return lista;
            }
            catch
            {
                return lista;
            }
        }

        public void Cores()
        {
            try
            {
                string str = null;
                string dia, mes = "";
                string[] strArr = null;

                str = Dias.Text.Trim();
                char[] splitchar = { ',' };
                strArr = str.Split(splitchar);

                dia = str.Substring(0, 2);
                mes = str.Substring(2, 4).Replace("/", "").Replace(",", "");

                IncluirDT(Dias.Text);
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Erro no Método Cores.'" + ex.Message + "); window.location.href = window.location.href;</script>");
            }
        }

        public DataTable IncluirDT(string dias)
        {
            DataTable dadosTabela = new DataTable();

            dadosTabela.Columns.AddRange(new DataColumn[1]
            {
                new DataColumn("Data", typeof(string)),
           });

            dadosTabela.DefaultView.Sort = "Data desc";
            dadosTabela.Rows.Add(dias);

            ViewState["dt"] = dadosTabela;
            return dadosTabela;
        }
    }
}