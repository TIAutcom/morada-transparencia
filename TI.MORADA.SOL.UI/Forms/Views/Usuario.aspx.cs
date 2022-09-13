using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.REGRA.NEGOCIOS;

namespace TI.MORADA.SOL.UI.Forms.Views
{
    public partial class Usuario : System.Web.UI.Page
    {
        #region CLASSES E OBJETOS

        UsuarioRegraNegocios usuarioRegraNegocios;

        #endregion

        #region VARIAVEIS

        int idUsuario, idNivel = 0;
        public string _login = "";

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            GetDados();
            ListarUsuario();
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

        public void ListarUsuario()
        {
            try
            {
                usuarioRegraNegocios = new UsuarioRegraNegocios();
                DataTable dadosTabela = new DataTable();

                dadosTabela = usuarioRegraNegocios.ListarAll("");

                if (dadosTabela.Rows.Count > 0)
                {
                    gdvUsuario.DataSource = null;
                    gdvUsuario.DataSource = dadosTabela;
                    gdvUsuario.DataBind();
                }
                else
                {
                    gdvUsuario.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        string index = "";

        protected void gdvUsuario_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("update"))
            {
                index = e.CommandArgument.ToString();

                Response.Redirect("~/Alterar/Usuario.aspx?IdUsuario=" + index, false);
            }

            if (e.CommandName.Equals("Delete"))
            {
                string index = e.CommandArgument.ToString();

                Deletar(index);
            }
        }

        public void Deletar(string id)
        {
            try
            {
                usuarioRegraNegocios = new UsuarioRegraNegocios();

                int idRet = usuarioRegraNegocios.Deletar(Convert.ToInt32(id));

                try
                {
                    int idRetorno = Convert.ToInt32(idRet);

                    Response.Write("<script>alert('Usuário Deletado com Sucesso.'); window.location.href = window.location.href;</script>");
                }
                catch
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Erro ao Deletar Usuário.')</script>");
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        protected void gdvUsuario_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            gdvUsuario.EditIndex = -1;
        }

        protected void gdvUsuario_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            gdvUsuario.EditIndex = -1;
        }

        protected void gdvUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = gdvUsuario.SelectedRow.Cells[1].Text;
        }


        protected void gdvUsuario_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton btnExcluir = (e.Row.FindControl("lkDelete") as LinkButton);

                if (btnExcluir != null)
                {
                    btnExcluir.OnClientClick = "return confirm('Realmente Deseja Remover o registro do Usuário?')";
                }
            }
        }
    }
}