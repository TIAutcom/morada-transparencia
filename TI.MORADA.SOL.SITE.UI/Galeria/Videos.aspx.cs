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
    public partial class Videos : System.Web.UI.Page
    {
        #region VARIAVEIS

        string descricao, url = "";

        #endregion

        #region CLASSES E OBJETOS

        VideosRegraNegocios videosRegraNegocios;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            ListarVideos();
        }

        public void ListarVideos()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                videosRegraNegocios = new VideosRegraNegocios();

                dadosTabela = videosRegraNegocios.ListarVideos();

                if (dadosTabela.Rows.Count > 0)
                {
                    for (int i = 0; i < dadosTabela.Rows.Count; i++)
                    {
                        url += dadosTabela.Rows[i]["URL"].ToString().Trim().Replace("560", "300") + "\t";
                    }

                    iframeVideos.Controls.Add(new LiteralControl(url));
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