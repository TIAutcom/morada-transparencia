using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.OBJETO.TRANSFERENCIA;
using TI.MORADA.SOL.REGRA.NEGOCIOS;

namespace TI.MORADA.SOL.UI.Cadastros
{
    public partial class Login : System.Web.UI.Page
    {
        #region CLASSES E OBJETOS

        TipoUsuarioRegraNegocios tipoUsuarioRegraNegocios;
        UsuarioRegraNegocios usuarioRegraNegocios;
        NivelAcessoRegraNegocios nivelAcessoRegraNegocios;
        Usuarios usuario;

        #endregion

        #region VARIAVEIS

        int idUsuario, idNivel = 0;
        string _login = "";

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
                LoadTela();
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

        public void LoadTela()
        {
            ListarTipoUsuario();
            ListarNivelAcesso();
        }

        public void ListarTipoUsuario()
        {
            try
            {
                tipoUsuarioRegraNegocios = new TipoUsuarioRegraNegocios();
                DataTable dadosTabela = new DataTable();

                dadosTabela = tipoUsuarioRegraNegocios.ListarAll();

                if (dadosTabela.Rows.Count > 0)
                {
                    ddlTipoUsuario.DataSource = dadosTabela;

                    ddlTipoUsuario.DataValueField = "Id";
                    ddlTipoUsuario.DataTextField = "Descricao";
                    ddlTipoUsuario.DataBind();
                }
            }
            catch (Exception ex)
            {
                lblResponse.Text = "Erro Técnico :" + ex.Message;
            }
        }

        public void ListarNivelAcesso()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                nivelAcessoRegraNegocios = new NivelAcessoRegraNegocios();

                dadosTabela = nivelAcessoRegraNegocios.ListarNivelAcessoAll();

                if (dadosTabela.Rows.Count > 0)
                {
                    ddlNivelAcesso.DataSource = dadosTabela;

                    ddlNivelAcesso.DataValueField = "Id";
                    ddlNivelAcesso.DataTextField = "Descricao";
                    ddlNivelAcesso.DataBind();
                }
            }
            catch (Exception ex)
            {
                lblResponse.Text = "Erro Técnico :" + ex.Message;
            }
        }

        public void Salvar()
        {
            try
            {
                usuario = new Usuarios();
                usuarioRegraNegocios = new UsuarioRegraNegocios();

                usuario.TipoUsuario = Convert.ToInt32(ddlTipoUsuario.SelectedValue);
                usuario.Nome = Nome.Text.Trim();
                usuario.Email = Email.Text.Trim();
                usuario.Senha = Senha.Text.Trim();
                usuario.Ativo = Convert.ToBoolean(ddtAtivo.SelectedValue);
                usuario.Aut = true;
                usuario.IdNivel = Convert.ToInt32(ddlTipoUsuario.SelectedValue);

                int idret = usuarioRegraNegocios.Salvar(usuario);

                if (idret > 0)
                {
                    Response.Redirect("~/Forms/Views/Usuario.aspx", true);
                }
                else
                {
                    lblResponse.Text = "Erro ao Salvar Novo Usuário.";
                }
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção, Erro ao Cadastrar Novo Usuário. Detalhes: " + ex.Message + "')</script>");
            }
        }

        protected void Unnamed9_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}