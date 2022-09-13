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
    public partial class Transparencias : System.Web.UI.Page
    {
        #region VARIAVEIS

        public int idUsuario, idNivel = 0;
        public int idTransp, idLai = 0;
        public string[] arquivo;
        public string _login, _transparencia, _ano = "";
        public string extensao = "";

        // static variable
        static string prevPage = String.Empty;

        List<DFileUploadProjeto> Larquivos;

        #endregion

        #region CLASSES E OBJETOS

        TransparenciaRegraNegocios transparenciaRegraNegocios;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            GetDados();

            if (!IsPostBack)
            {
                PainelMenu();

                ListarTransparencia();

                prevPage = Request.UrlReferrer.ToString();
            }
            else
            {
                idLai = Convert.ToInt32(Page.Request.QueryString["idLai"]);
                idTransp = Convert.ToInt32(Page.Request.QueryString["idTransp"]);
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
                btnNovo.Visible = true;
            }
            else
            {
                lblLogin.Visible = false;
                btnNovo.Visible = false;
            }
        }

        protected void gdvTranparencia_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Trim().Equals("Views"))
            {
                int index = Convert.ToInt32(e.CommandArgument);

                if ((index == 26) || (index == 30))
                {
                    Response.Redirect("~/Error.aspx", false);
                }
                else
                {
                    idTransp = index;

                    PesquisarTransparenciaId();

                    if (_ano != "")
                    {
                        Response.Redirect("~/Forms/Arquivos/Transparencias.aspx?IdLai=" + idLai + "&IdTransp=" + index + "&Transparencia=" + _transparencia + "&Ano=" + _ano, true);
                    }
                    else
                    {
                        Response.Redirect("~/Forms/Arquivos/Transparencias.aspx?IdLai=" + idLai + "&IdTransp=" + index + "&Transparencia=" + _transparencia, true);
                    }
                }
            }

            if (e.CommandName.Equals("UpLoad"))
            {
                int index = Convert.ToInt32(e.CommandArgument);

                idTransp = index;

                PesquisarTransparenciaId();

                Response.Redirect("~/UpLoads/Transparencia.aspx?IdLai=" + idLai + "&IdTransp=" + idTransp + "&Transparencia=" + _transparencia, true);
            }

            if (e.CommandName.Trim().Equals("UploadPDF"))
            {
                int index = Convert.ToInt32(e.CommandArgument);

                if (index <= 2)
                {
                    idTransp = index;

                    PesquisarTransparenciaId();

                    Response.Redirect("~/UpLoads/TransparenciaPDF.aspx?IdLai=" + idLai + "&IdTransp=" + idTransp + "&Transparencia=" + _transparencia, true);
                }
                else
                {
                    Response.Write("<script>alert('Acesso Permitido Somente para UpLoad Receitas e Despesas.'); window.location.href = window.location.href;</script>");
                }
            }
        }

        public void PainelMenu()
        {
            #region GET DADOS REQUEST NAVEGADOR

            idLai = Convert.ToInt32(Page.Request.QueryString["idLai"]);
            idTransp = Convert.ToInt32(Page.Request.QueryString["IdTranspar"]);
            _transparencia = Page.Request.QueryString["Transparencia"];

            #endregion

            #region POST DADOS REQUEST NAVEGADOR

            lblTitulo.Text = _transparencia;
            idUsuario = Convert.ToInt32(Session["IdUsuario"]);

            //HttpCookie login = Request.Cookies["Login"];
            //_login = login.Value.ToString().Trim();

            //HttpCookie transp = Request.Cookies["TransparenciaDesc"];
            //_transparencia = transp.Value;

            //HttpCookie Idtransp = Request.Cookies["IdTransparencia"];
            //_idTransp = Convert.ToInt32(Idtransp.Value);

            //lblDescricaLai.Text = _transparencia;
            //lblLogin.Text = _login;

            #endregion
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect(prevPage);
        }

        protected void gdvNotLog_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);

            if (index == 0)
            {
                Response.Redirect("~/PaginaError.aspx", false);
            }
            else if (index == 30)
            {
                //Response.Redirect("http://cearararaquara.com.br/Galeria/Agenda.aspx ,'_blank'", false);
                Response.Write("<script>window.open('http://cearararaquara.com.br/Galeria/Agenda.aspx','_blank')</script>");
            }
            else
            {
                idTransp = index;

                PesquisarTransparenciaId();

                if (_ano != "")
                {
                    Response.Redirect("~/Forms/Arquivos/Transparencias.aspx?IdLai=" + idLai + "&IdTransp=" + index + "&Transparencia=" + _transparencia + "&Ano=" + _ano, true);
                }
                else
                {
                    Response.Redirect("~/Forms/Arquivos/Transparencias.aspx?IdLai=" + idLai + "&IdTransp=" + index + "&Transparencia=" + _transparencia, true);
                }
            }
        }

        public void ListarTransparencia()
        {
            try
            {
                transparenciaRegraNegocios = new TransparenciaRegraNegocios();
                DataTable dadosTabela = new DataTable();

                dadosTabela = transparenciaRegraNegocios.ListarAll(idLai);

                if (dadosTabela.Rows.Count > 0)
                {
                    if (idUsuario == 0)
                    {
                        gdvNotLog.DataSource = null;
                        gdvNotLog.DataSource = dadosTabela;
                        gdvNotLog.DataBind();
                    }
                    else
                    {
                        gdvTranparencia.DataSource = null;
                        gdvTranparencia.DataSource = dadosTabela;
                        gdvTranparencia.DataBind();
                    }
                }
                else
                {
                    gdvTranparencia.DataSource = null;
                }

                lblTitulo.Text = _transparencia; ;
            }
            catch (Exception ex)
            {
                lblResponse.Text = "Erro Técnico Método Painel de Menu: " + ex.Message;
            }
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            PainelMenu();
            Response.Redirect("~/Cadastros/Transparencia.aspx?IdLai=" + idLai + "&idTransp=" + idTransp + "&Transparencia=" + _transparencia, true);
        }

        public void PesquisarTransparenciaId()
        {
            try
            {
                transparenciaRegraNegocios = new TransparenciaRegraNegocios();
                DataTable dadosTabela = new DataTable();

                dadosTabela = transparenciaRegraNegocios.PesquisarTransparenciaId(idTransp);

                if (dadosTabela.Rows.Count > 0)
                {
                    _transparencia = dadosTabela.Rows[0]["Descricao"].ToString().Trim();

                    HttpCookie cookie = new HttpCookie("TransparenciaDesc");
                    cookie.Value = dadosTabela.Rows[0]["Descricao"].ToString().Trim();

                    DateTime dtNow = DateTime.Now;
                    TimeSpan tsMinute = new TimeSpan(0, 1, 0, 0);

                    cookie.Expires = (dtNow + tsMinute);

                    Response.Cookies.Add(cookie);

                    //----------------------------------------------------------------------------------------------

                    HttpCookie transp = new HttpCookie("IdTransp");
                    transp.Value = dadosTabela.Rows[0]["Id"].ToString().Trim();

                    dtNow = DateTime.Now;
                    tsMinute = new TimeSpan(0, 1, 0, 0);

                    transp.Expires = (dtNow + tsMinute);

                    Response.Cookies.Add(transp);
                }
            }
            catch (Exception ex)
            {
                lblResponse.Text = "Erro Técnico Método Painel de Menu: " + ex.Message;
            }
        }
    }
}