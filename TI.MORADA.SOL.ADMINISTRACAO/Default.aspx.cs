using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.REGRA.NEGOCIOS;
using TI.MORADA.SOL.OBJETO.TRANSFERENCIA;

namespace TI.MORADA.SOL.ADMINISTRACAO
{
    public partial class _Default : Page
    {

        #region CLASSES E OBJETOS

        Usuarios usuario;
        UsuarioRegraNegocios usuarioRegraNegocios;

        #endregion

        #region VARIAVEIS

        public int idUsuario, idNivel = 0;
        public string login = "";

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Convert.ToInt32(Session["IdUsuario"]) > 0)
                {
                    Response.Redirect("~/Views/Listas.aspx", false);
                }
                else
                {
                    Response.Redirect("~/Index.aspx", false);
                }
            }
        }


        protected void gdvAgenda_RowCommand(object sender, GridViewCommandEventArgs e)
        {
        }

        protected void LogIn(object sender, EventArgs e)
        {
            LogIn();
        }

        protected void LogIn()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                usuarioRegraNegocios = new UsuarioRegraNegocios();
                usuario = new Usuarios();

                usuario.Email = Email.Text.Trim();
                usuario.Senha = Password.Text.Trim();

                dadosTabela = usuarioRegraNegocios.Logar(usuario);

                if (dadosTabela.Rows.Count > 0)
                {
                    idUsuario = Convert.ToInt32(dadosTabela.Rows[0]["Id"].ToString());
                    idNivel = Convert.ToInt32(dadosTabela.Rows[0]["CodNivel"].ToString());
                    login = dadosTabela.Rows[0]["Nome"].ToString().Trim();

                    Session["IdUsuario"] = idUsuario;
                    Session["Usuario"] = login.Trim();
                    Session["IdNivel"] = idNivel;

                    Response.Redirect("~/Views/Listas.aspx", false);
                }
                else
                {
                    Response.Redirect("~/Login.aspx", false);
                }
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção, Erro ao Logar. Detalhes: " + ex.Message + "')</script>");
            }
        }
    }
}