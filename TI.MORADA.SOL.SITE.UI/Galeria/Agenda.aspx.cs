using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.REGRA.NEGOCIOS;
using TI.MORADA.SOL.OBJETO.TRANSFERENCIA;
using System.Data;
using System.Text;
using System.Web.Services;

namespace TI.MORADA.SOL.SITE.UI.Galeria
{
    public partial class Agenda : System.Web.UI.Page
    {
        #region CLASSES E OBJETOS

        MesRegraNegocios mesRegraNegocios;
        HtmlRegraNegocios htmlRegraNegocios;
        AgendaRegraNegocios agendaRegraNegocios;

        #endregion

        #region VARIAVEIS
        int mes, ano = 0;
        int id = 0;
        string local, data, imagem, titulo, Descricao, siteCliente = "";
        string htmlGaleria = "";

        int idEvento = 0;
        string site, evento, detalhe, sessao = "";
        string url = "";

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadTela();
            }
        }

        protected void ddlMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            GerarHtmlAgenda();
        }

        protected void ddlAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            GerarHtmlAgenda();
        }

        public void LoadTela()
        {
            CarregarLista();
            GerarHtmlAgenda();
        }

        public void CarregarLista()
        {
            try
            {
                mesRegraNegocios = new MesRegraNegocios();

                ddlMes.DataSource = mesRegraNegocios.ListarMes();
                ddlMes.DataValueField = "Id";
                ddlMes.DataTextField = "Mes";
                ddlMes.DataBind();
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        public void GerarHtmlAgenda()
        {
            try
            {
                htmlRegraNegocios = new HtmlRegraNegocios();
                DataTable dadosTabela = new DataTable();
                agendaRegraNegocios = new AgendaRegraNegocios();

                LimparVariaveis();

                mes = Convert.ToInt32(ddlMes.SelectedValue);
                ano = Convert.ToInt32(ddlAno.SelectedValue);

                if (mes > 0 && mes <= 12)
                {
                    dadosTabela = agendaRegraNegocios.ListarAgenda(mes, ano);
                }
                else
                {
                    dadosTabela = agendaRegraNegocios.ListarAgendaAno(ano);
                }

                if (dadosTabela.Rows.Count > 0)
                {
                    for (int i = 0; i < dadosTabela.Rows.Count; i++)
                    {
                        id = Convert.ToInt32(dadosTabela.Rows[i]["Id"].ToString());
                        local = dadosTabela.Rows[i]["Local"].ToString().Trim();
                        data = dadosTabela.Rows[i]["DataDescricao"].ToString().Trim();
                        imagem = dadosTabela.Rows[i]["ImageName"].ToString().Trim();
                        titulo = dadosTabela.Rows[i]["Descricao"].ToString().Trim();
                        Descricao = dadosTabela.Rows[i]["Contato"].ToString().Trim();
                        siteCliente = dadosTabela.Rows[i]["SiteCliente"].ToString().Trim();
                        sessao = dadosTabela.Rows[i]["Sessao"].ToString().Trim();

                        htmlGaleria += htmlRegraNegocios.GerarHtmlAgenda(imagem.Replace("~", ""), titulo, Descricao, siteCliente, local, data, id, sessao);
                    }

                    iframeAgenda.Controls.Add(new LiteralControl(htmlGaleria));

                    lblQtdeRegistro.Text = "Qtde de Registros: " + dadosTabela.Rows.Count.ToString().PadLeft(5, '0');
                }
                else
                {
                    lblQtdeRegistro.Text = "Qtde de Registros: 00000";
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        public void LimparVariaveis()
        {
            htmlGaleria = "";
            siteCliente = "";
            mes = 0;
            ano = 0;
        }
    }
}