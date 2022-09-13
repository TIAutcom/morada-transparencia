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
    public partial class TipoUsuario : System.Web.UI.Page
    {
        #region CLASSES E OBJETOS

        TipoUsuarios tipoUsuario;
        TipoUsuarioRegraNegocios tipoUsuarioRegraNegocios;

        #endregion

        #region VARIAVEIS

        int idUsuario, idNivel = 0;
        string _login = "";

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            GetDados();
            ListarAll();
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

        public void ListarAll()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                tipoUsuarioRegraNegocios = new TipoUsuarioRegraNegocios();

                dadosTabela = tipoUsuarioRegraNegocios.ListarAll();

                if (dadosTabela.Rows.Count > 0)
                {
                    gdvTipos.DataSource = null;
                    gdvTipos.DataSource = dadosTabela;
                    gdvTipos.DataBind();
                }
                else
                {
                    gdvTipos.DataSource = null;
                    gdvTipos.DataBind();
                }
            }
            catch (Exception ex)
            {
                lblResponse.Text = "Erro Técnico: " + ex.Message;
            }
        }
    }
}