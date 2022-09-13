using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.REGRA.NEGOCIOS;

namespace TI.MORADA.SOL.UI.Forms
{
    public partial class LeiAcessoInformacao : System.Web.UI.Page
    {
        #region CLASSES E OBJETOS

        LeisRegraNegocios leisRegraNegocios;

        #endregion

        #region VARIAVEIS

        int _idTranpsrencia, _idLai = 0;
        string _transparencia = "";
        string login = "";
        int idUsuario, idNivel = 0;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetDados();
                Listar();
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

        public void Listar()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                leisRegraNegocios = new LeisRegraNegocios();
                dadosTabela = leisRegraNegocios.ListarAll();

                if (dadosTabela.Rows.Count > 0)
                {
                    if (idUsuario == 0)
                    {
                        gdvTransparencia.DataSource = null;
                        gdvTransparencia.DataSource = dadosTabela;
                        gdvTransparencia.DataBind();
                    }
                    else
                    {
                        gdvLaiLog.DataSource = null;
                        gdvLaiLog.DataSource = dadosTabela;
                        gdvLaiLog.DataBind();
                    }
                }
                else
                {
                    gdvTransparencia.DataSource = null;
                    gdvLaiLog.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        protected void gdvTransparencia_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("SelecioneTranspar"))
            {
                int id = Convert.ToInt32(e.CommandArgument);

                GetIdLai(id);
                GetDescLai(id);

                Response.Redirect("~/Forms/Views/Transparencias.aspx?IdLai=" + id + "&Transparencia=" + _transparencia, true);
            }
        }

        public void GetIdLai(int id)
        {
            try
            {
                HttpCookie cookie = new HttpCookie("IdLai");
                cookie.Value = id.ToString();

                //Time para expiração (1min)
                DateTime dtNow = DateTime.Now;
                TimeSpan tsMinute = new TimeSpan(0, 1, 0, 0);

                cookie.Expires = (dtNow + tsMinute);

                //Adiciona o cookie
                Response.Cookies.Add(cookie);
            }
            catch (Exception ex)
            {
                lblResponse.Text = "Erro no Painel de Menu!.' " + ex.Message;
            }
        }

        protected void gdvLaiLog_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("SelecioneTranspar"))
            {
                int id = Convert.ToInt32(e.CommandArgument);

                GetIdLai(id);
                GetDescLai(id);

                Response.Redirect("~/Forms/Views/Transparencias.aspx?IdLai=" + id + "&Transparencia=" + _transparencia, true);
            }

            if (e.CommandName.Equals("Deletar"))
            {
                int id = Convert.ToInt32(e.CommandArgument);

                leisRegraNegocios = new LeisRegraNegocios();

                try
                {
                    string idret = leisRegraNegocios.Deletar(id);

                    if (Convert.ToInt32(idret) > 0)
                    {
                        Response.Write("<script>alert('Lei de Acesso a Informação foi Deletado com Sucesso.'); window.location.href = window.location.href;</script>");
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Erro ao Deletar Lei de Acesso de Informação')</script>");
                    }
                }
                catch
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Erro ao Deletar Lei de Acesso de Informação')</script>");
                }
            }

            if (e.CommandName.Equals("Alterar"))
            {
                int id = Convert.ToInt32(e.CommandArgument);

                leisRegraNegocios = new LeisRegraNegocios();
            }
        }

        protected void gdvLaiLog_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton btnExcluir = (e.Row.FindControl("lklDele") as LinkButton);

                if (btnExcluir != null)
                {
                    btnExcluir.OnClientClick = "return confirm('Realmente Deseja Remover o registro da Lei de Acesso a Informação?')";
                }
            }
        }

        public void GetDescLai(int id)
        {
            try
            {
                leisRegraNegocios = new LeisRegraNegocios();
                DataTable dadosTabela = new DataTable();

                dadosTabela = leisRegraNegocios.ListarLaiId(id);

                if (dadosTabela.Rows.Count > 0)
                {
                    _transparencia = dadosTabela.Rows[0]["Descricao"].ToString().Trim();
                    _idTranpsrencia = Convert.ToInt32(dadosTabela.Rows[0]["Id"].ToString().Trim());

                    HttpCookie cookie = new HttpCookie("DescricaoLai");
                    cookie.Value = _transparencia;

                    //Time para expiração (1min)
                    DateTime dtNow = DateTime.Now;
                    TimeSpan tsMinute = new TimeSpan(0, 1, 0, 0);

                    cookie.Expires = (dtNow + tsMinute);

                    //Adiciona o cookie
                    Response.Cookies.Add(cookie);
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