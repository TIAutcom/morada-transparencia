using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.REGRA.NEGOCIOS;

namespace TI.MORADA.SOL.SITE.UI.Galeria
{
    public partial class Detalhes : System.Web.UI.Page
    {
        int id = 0;
        string site, evento, detalhe, local, sessao, data = "";
        string url = "";

        AgendaRegraNegocios agendaRegraNegocios;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                id = Convert.ToInt32(Request.QueryString["Id"].ToString());

                if (id == 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Voltar", "history.back();", true);
                    return;
                }
                else
                {
                    PesquisarIdAgenda();
                }
            }
        }

        public void PesquisarIdAgenda()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                agendaRegraNegocios = new AgendaRegraNegocios();
                dadosTabela = agendaRegraNegocios.PesquisarAgendaId(id);

                if (dadosTabela.Rows.Count > 0)
                {
                    site = dadosTabela.Rows[0]["sitecliente"].ToString();
                    evento = dadosTabela.Rows[0]["Descricao"].ToString();
                    local = dadosTabela.Rows[0]["Local"].ToString();
                    detalhe = dadosTabela.Rows[0]["Contato"].ToString();
                    sessao = dadosTabela.Rows[0]["Sessao"].ToString();
                    data = dadosTabela.Rows[0]["DataDescricao"].ToString();
                    url = "http://transparencia.moradaturismoeventos.com.br" + dadosTabela.Rows[0]["Image"].ToString().Replace("~", "").Trim();
                    string html = "";

                    html += agendaRegraNegocios.MontarHtmlDetalhes(site, evento, local, detalhe, sessao, data, url);

                    iframe.Controls.Add(new LiteralControl(html.ToString()));
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