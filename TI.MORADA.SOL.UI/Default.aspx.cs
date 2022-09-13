using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TI.MORADA.SOL.UI
{
    public partial class _Default : Page
    {
        #region VARIAVEIS

        public int idUsuario;
        public int idTransp, idLai = 0;
        public string _login, _transparencia, anoCad = "";
        public string folder = "";
        public string street = "";
        public string[] arquivo;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetDados();
            }
        }

        public void GetDados()
        {
            idUsuario = Convert.ToInt32(Session["IdUsuario"]);

            if (idUsuario != 0)
            {
                lblLogin.Text = "OPERADOR(A): " + "[ " + Session["Usuario"].ToString().ToUpper() + " ]";
                lblLogin.Visible = true;
            }
            else
            {
                lblLogin.Visible = false;
            }
        }
    }
}