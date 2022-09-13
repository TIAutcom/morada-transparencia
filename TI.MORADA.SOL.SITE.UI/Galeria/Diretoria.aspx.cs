using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.OBJETO.TRANSFERENCIA;
using TI.MORADA.SOL.REGRA.NEGOCIOS;

namespace TI.MORADA.SOL.SITE.UI.Galeria
{
    public partial class Diretoria : System.Web.UI.Page
    {
        #region CLASSES E OBJETOS

        Diretorias diretoria;
        DiretoriaRegraNegocios diretoriaRegraNegocios;
        HtmlRegraNegocios htmlRegraNegocios;

        #endregion

        #region VARIAVEIS

        int id = 0;
        string htmlDiretoria;
        string nome, cargo, imagem, descricao, curriculo = "";

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GerarHtmlAgenda();
            }
        }

        public void GerarHtmlAgenda()
        {
            try
            {
                htmlRegraNegocios = new HtmlRegraNegocios();
                DataTable dadosTabela = new DataTable();
                diretoriaRegraNegocios = new DiretoriaRegraNegocios();

                LimparVariaveis();

                dadosTabela = diretoriaRegraNegocios.ListarDiretoria();

                if (dadosTabela.Rows.Count > 0)
                {
                    for (int i = 0; i < dadosTabela.Rows.Count; i++)
                    {
                        id = Convert.ToInt32(dadosTabela.Rows[i]["Id"].ToString());
                        imagem = dadosTabela.Rows[i]["Ulr"].ToString().Trim();
                        descricao = dadosTabela.Rows[i]["Descricao"].ToString().Trim();
                        cargo = dadosTabela.Rows[i]["Cargo"].ToString().Trim();
                        nome = dadosTabela.Rows[i]["Nome"].ToString().Trim();
                        curriculo = dadosTabela.Rows[i]["UrlCurriculo"].ToString();

                        htmlDiretoria += htmlRegraNegocios.GerarHtmlDiretoria("http://transparencia.moradaturismoeventos.com.br/" + imagem.Replace("~", ""), nome, cargo, descricao, id, curriculo);
                    }

                    iframe.Controls.Add(new LiteralControl(htmlDiretoria));
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
            nome = "";
            descricao = "";
            cargo = "";
            imagem = "";
        }
    }
}