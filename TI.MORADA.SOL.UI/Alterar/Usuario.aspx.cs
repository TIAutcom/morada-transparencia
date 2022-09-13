using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.OBJETO.TRANSFERENCIA;
using TI.MORADA.SOL.REGRA.NEGOCIOS;

namespace TI.MORADA.SOL.UI.Alterar
{
    public partial class Usuario : System.Web.UI.Page
    {
        #region CLASSES E OBJETOS

        TipoUsuarioRegraNegocios tipoUsuarioRegraNegocios;
        NivelAcessoRegraNegocios nivelAcessoRegraNegocios;
        Usuarios usuario;
        UsuarioRegraNegocios usuarioRegraNegocios;

        #endregion

        #region VARIAVEIS

        int idUsuario, idUser, idNivel = 0;
        public string _login = "";

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                idUser = Convert.ToInt32(Page.Request.QueryString["idUsuario"]);

                GetDados();
                ListarUsuarioId();
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

        public void ListarUsuarioId()
        {
            try
            {
                usuarioRegraNegocios = new UsuarioRegraNegocios();
                DataTable dadosTabela = new DataTable();

                dadosTabela = usuarioRegraNegocios.ListarId(idUser);

                if (dadosTabela.Rows.Count > 0)
                {
                    idUsuario = Convert.ToInt32(Session["IdUsuario"]);

                    int c = string.Compare(idUsuario.ToString(), idUser.ToString());

                    if (c == 0)
                    {
                        TpUsuario.Text = dadosTabela.Rows[0]["Descricao"].ToString().Trim();
                        NivelAcesso.Text = dadosTabela.Rows[0]["DescNivel"].ToString().Trim();
                        Nome.Text = dadosTabela.Rows[0]["Nome"].ToString().Trim();
                        Email.Text = dadosTabela.Rows[0]["Email"].ToString().Trim();
                        Senha.Text = dadosTabela.Rows[0]["Senha"].ToString().Trim();
                    }
                    else
                    {
                        if (idNivel > 1)
                        {
                            pnlUser.Enabled = false;

                            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção Sem Permissão para Visualizar Dados do Usuário.')</script>");
                        }
                        else
                        {
                            TpUsuario.Text = dadosTabela.Rows[0]["Descricao"].ToString().Trim();
                            NivelAcesso.Text = dadosTabela.Rows[0]["DescNivel"].ToString().Trim();
                            Nome.Text = dadosTabela.Rows[0]["Nome"].ToString().Trim();
                            Email.Text = dadosTabela.Rows[0]["Email"].ToString().Trim();
                            Senha.Text = dadosTabela.Rows[0]["Senha"].ToString().Trim();
                        }
                    }

                    ListarTipoUsuario();
                    ListarNivelAcesso();
                }
            }
            catch (Exception ex)
            {
                Session["Erro"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        protected void btnSalvar_Click1(object sender, EventArgs e)
        {
            Salvar();
        }

        protected void Unnamed14_Click(object sender, EventArgs e)
        {
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Forms/Views/Usuario.aspx?IdUsuario=" + idUsuario, false);
        }

        public void Salvar()
        {
            try
            {
                if (Senha.Text.Trim().Equals(""))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('* Campo Senha não Pode ser Nulo ou Vázio')</script>");
                    Senha.Focus();
                }
                else
                {
                    usuario = new Usuarios();
                    usuarioRegraNegocios = new UsuarioRegraNegocios();

                    idUser = Convert.ToInt32(Page.Request.QueryString["idUsuario"]);

                    usuario.TipoUsuario = Convert.ToInt32(ddlTipoUsuario.SelectedValue);
                    usuario.Id = idUser;
                    usuario.Nome = Nome.Text.Trim();
                    usuario.Email = Email.Text.Trim();
                    usuario.Senha = Senha.Text.Trim();
                    usuario.Ativo = Convert.ToBoolean(ddtAtivo.SelectedValue);
                    usuario.Aut = true;
                    usuario.IdNivel = Convert.ToInt32(ddlNivelAcesso.SelectedValue);

                    int idret = usuarioRegraNegocios.Alterar(usuario);

                    if (idret > 0)
                    {
                        Response.Redirect("~/Forms/Views/Usuario.aspx?idUsuario=" + idUser, false);
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Erro ao Salvar Novo Usuário.')</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção, Erro Técnico :" + ex.Message + "')</script>");
                lblResponse.Text = "Erro Técnico :" + ex.Message;
            }
        }
    }
}