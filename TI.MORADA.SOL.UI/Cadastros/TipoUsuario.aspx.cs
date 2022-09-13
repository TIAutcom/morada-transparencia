using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.OBJETO.TRANSFERENCIA;
using TI.MORADA.SOL.REGRA.NEGOCIOS;

namespace TI.MORADA.SOL.UI.Cadastros
{
    public partial class TipoUsuario : System.Web.UI.Page
    {
        #region CLASSES E OBJETOS

        TipoUsuarios tipoUsuario;
        TipoUsuarioRegraNegocios tipoUsuarioRegraNegocios;

        #endregion

        #region VARIAVEIS

        int idUsuario, idNivel = 0;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["IdUsuario"] == null)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Voltar", "history.back();", true);
                return;
            }
            else
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

        public void Salvar()
        {
            try
            {
                tipoUsuario = new TipoUsuarios();
                tipoUsuarioRegraNegocios = new TipoUsuarioRegraNegocios();

                tipoUsuario.Descricao = TipoUser.Text.Trim();

                int id = tipoUsuarioRegraNegocios.Salvar(tipoUsuario);

                if (id > 0)
                {
                    Response.Redirect("~/Forms/Views/TipoUsuario.aspx", true);
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção Erro ao Cadastrar Novo Tipo de Usuário.')</script>");
                }
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção Erro Detalhes: " + ex.Message + "')</script>");
            }
        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}