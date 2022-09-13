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
    public partial class Portifolio : System.Web.UI.Page
    {
        #region VARIAVEIS

        int idTipo = 0;
        string cabecalho = "";
        string imagens = "";
        string titulo, descricao, url = "";

        #endregion

        #region CLASSES E OBJETOS

        FotoRegraNegocios fotoRegraNegocios;
        HtmlRegraNegocios htmlRegraNegocios;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                idTipo = Convert.ToInt32(Page.Request["IdTipo"]);
                cabecalho = Page.Request["Galeria"].ToString().Trim();
                lblGaleria.Text = "Galeria de Fotos/" + cabecalho.ToString().Trim();

                ListarFotos();
            }
            catch
            {
            }
        }

        public void ListarFotos()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                fotoRegraNegocios = new FotoRegraNegocios();
                htmlRegraNegocios = new HtmlRegraNegocios();

                dadosTabela = fotoRegraNegocios.ListarFoto(idTipo);

                if (dadosTabela.Rows.Count > 0)
                {
                    imagens = "";

                    for (int i = 0; i < dadosTabela.Rows.Count; i++)
                    {
                        url = dadosTabela.Rows[i]["URL"].ToString().Trim();
                        titulo = dadosTabela.Rows[i]["TITULO"].ToString().Trim();
                        descricao = dadosTabela.Rows[i]["DESCRICAO"].ToString();

                        imagens += htmlRegraNegocios.GerarHtmlObras(url, titulo, descricao);
                    }

                    iframeObras.Controls.Add(new LiteralControl(imagens));

                    lblQtdeRegistro.Text = "Qtde de Registros: " + dadosTabela.Rows.Count.ToString().PadLeft(5, '0');
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