using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.REGRA.NEGOCIOS;

namespace TI.MORADA.SOL.SITE.UI.Galeria
{
    public partial class DiretorDetalhes : System.Web.UI.Page
    {
        int idDiretor = 0;
        string nome, cargo, curriculo, imagem, descr = "";
        string html = "";

        DiretoriaRegraNegocios diretoriaRegraNegocios;
        HtmlRegraNegocios htmlRegraNegocios;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                idDiretor = Convert.ToInt32(Page.Request["Id"]);
                PesquisarDiretor();
            }
        }

        public void PesquisarDiretor()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                htmlRegraNegocios = new HtmlRegraNegocios();
                diretoriaRegraNegocios = new DiretoriaRegraNegocios();

                dadosTabela = diretoriaRegraNegocios.PesquisarDiretorId(idDiretor);

                if (dadosTabela.Rows.Count > 0)
                {
                    nome = dadosTabela.Rows[0]["Nome"].ToString().Trim();
                    cargo = dadosTabela.Rows[0]["Cargo"].ToString().Trim();
                    curriculo = dadosTabela.Rows[0]["UrlCurriculo"].ToString().Trim();
                    descr = dadosTabela.Rows[0]["Descricao"].ToString().Trim();
                    imagem = "http://transparencia.moradaturismoeventos.com.br" + dadosTabela.Rows[0]["Ulr"].ToString();

                    html += htmlRegraNegocios.GerarHtmlDetalhesDiretor(nome, cargo, curriculo, imagem.Replace("~", "").Trim(), descr);
                }

                iframe.Controls.Add(new LiteralControl(html));
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }
    }
}