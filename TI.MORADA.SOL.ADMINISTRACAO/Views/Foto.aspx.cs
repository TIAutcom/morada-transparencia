using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.REGRA.NEGOCIOS;

namespace TI.MORADA.SOL.ADMINISTRACAO.Views
{
    public partial class Foto : System.Web.UI.Page
    {
        #region CLASSES E OBJETOS

        FotoRegraNegocios fotoRegraNegocios;
        DataTable dadosTabela = new DataTable();

        #endregion

        public string xmlFoto = "";
        public string titulo, urlFoto = "";
        public int cont, id = 0;
        public bool hr;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarFotoTipo();
            }
        }

        public void ListarFotoTipo()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                fotoRegraNegocios = new FotoRegraNegocios();

                dadosTabela = fotoRegraNegocios.ListarFotos();

                if (dadosTabela.Rows.Count > 0)
                {
                    xmlFoto = "";

                    for (int i = 0; i < dadosTabela.Rows.Count; i++)
                    {
                        id = Convert.ToInt32(dadosTabela.Rows[0]["IdAdm"].ToString());
                        titulo = dadosTabela.Rows[i]["Titulo"].ToString().Trim();
                        urlFoto = dadosTabela.Rows[i]["Url"].ToString().Trim();

                        if (cont == 2)
                        {
                            cont = 0;
                            hr = true;
                        }
                        else
                        {
                            hr = false;
                            cont++;
                        }

                        //string urlFotos = Server.MapPath(urlFoto);

                        xmlFoto += fotoRegraNegocios.GerarXmlFotos(titulo, urlFoto, hr);
                    }

                    iframeObras.Controls.Add(new LiteralControl(xmlFoto));
                }
                else
                {
                    xmlFoto = "";
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
