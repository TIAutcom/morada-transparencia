using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using TI.MORADA.SOL.UI.Models;
using TI.MORADA.SOL.OBJETO.TRANSFERENCIA;
using TI.MORADA.SOL.REGRA.NEGOCIOS;
using System.Data;

namespace TI.MORADA.SOL.UI.Account
{
    public partial class Login : Page
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
                GetDados();
            }
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

                    if (idNivel < 4)
                    {
                        Session["IdUsuario"] = idUsuario;
                        Session["Usuario"] = login.Trim();
                        Session["IdNivel"] = idNivel;

                        Response.Redirect("~/Forms/LeiAcessoInformacao.aspx", false);
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Tipo de Usuário não Permitido para Acessar Pagina Lei de Acesso a Informação.')</script>");
                        Email.Focus();
                    }
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('E-Mail ou Senha Inválida.')</script>");
                    Email.Focus();
                }
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção, Erro ao Logar. Detalhes: " + ex.Message + "')</script>");
            }
        }

        protected void LogIn(object sender, EventArgs e)
        {
            LogIn();
        }
    }
}