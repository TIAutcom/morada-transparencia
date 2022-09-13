using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.REGRA.NEGOCIOS;
using TI.MORADA.SOL.OBJETO.TRANSFERENCIA;
using System.Web.Services;
using System.IO;

namespace TI.MORADA.SOL.UI.Cadastros
{
    public partial class Transparencia : System.Web.UI.Page
    {
        #region VARIAVEIS

        public int idUsuario, idNivel = 0;
        public int _idTransp, idLai = 0;
        public string[] arquivo;
        public string _login, _transparencia, _ano = "";
        public string extensao, ano = "";

        #endregion

        #region CLASSES E OBJETOS

        Transparencias transparencia;
        TransparenciaRegraNegocios transparenciaRegraNegocios;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            idLai = Convert.ToInt32(Page.Request.QueryString["IdLai"]);
            _transparencia = Page.Request.QueryString["Transparencia"];

            if (!IsPostBack)
            {
                if ((Session["IdUsuario"] == null) || (idLai == null) || (_transparencia == null))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Voltar", "history.back();", true);
                    return;
                }
                else
                {
                    GetDados();
                    GetDadosTransparencia();
                }
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

        public void GetDadosTransparencia()
        {
            lblDescricaLai.Text = _transparencia;
        }

        public void Salvar()
        {
            try
            {
                transparenciaRegraNegocios = new TransparenciaRegraNegocios();
                transparencia = new Transparencias();

                transparencia.IdLai = idLai;
                transparencia.Descricao = Descricao.Text.Trim();
                transparencia.IdUsuario = idUsuario;

                int idet = transparenciaRegraNegocios.Salvar(transparencia);

                if (idet > 0)
                {
                    ano = ddlAno.Text.Trim();

                    if (ano != "")
                    {
                        GerarDiretorio(idLai, idet, ano);
                    }
                    else
                    {
                        GerarDiretorio(idLai, idet, ano);
                    }

                    Response.Redirect("~/Forms/Views/Transparencias.aspx?idLai=" + idLai + "&IdTransp=" + idet + "&IdTransparencia=" + idet + "&Transparencia=" + _transparencia, false);
                }
                else
                {
                    lblResponse.Text = "Erro ao Salvar Nova Transparência.";
                }
            }
            catch (Exception ex)
            {
                lblResponse.Text = "Erro no Painel de Menu!.' " + ex.Message;
            }
        }

        [WebMethod]
        public void GerarDiretorio(int idLai, int idTransp, string ano)
        {
            try
            {
                if (ano != "")
                {
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Transparencias\\"));
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Transparencias\\" + "\\" + idLai));
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Transparencias\\" + "\\" + idLai + "\\" + idTransp));
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Transparencias\\" + "\\" + idLai + "\\" + idTransp + "\\" + ano));
                }
                else
                {
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Transparencias\\"));
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Transparencias\\" + "\\" + idLai));
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Transparencias\\" + "\\" + idLai + "\\" + idTransp));
                }
            }
            catch (Exception ex)
            {
                lblResponse.Text = "Erro no Painel de Menu!.' " + ex.Message;
            }
        }

        protected void Unnamed5_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}