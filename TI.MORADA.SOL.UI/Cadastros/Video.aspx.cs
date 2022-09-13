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
    public partial class Video : System.Web.UI.Page
    {
        #region VARIAVEIS

        public int idUsuario = 0;

        #endregion

        #region CLASSES E OBJETOS

        Videos video;
        VideosRegraNegocios videoRegraNegocios;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                idUsuario = (Session["idUsuario"] != null) ? Convert.ToInt32(Session["idUsuario"]) : 0;

                if (idUsuario == 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Voltar", "history.back();", true);
                    return;
                }
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        public void Salvar()
        {
            try
            {
                if (NomeVideo.Text.Trim().Equals(""))
                {
                    Response.Write("<script>alert('Nome do Video não pode ser Nulo ou Vázio'); window.location.href = window.location.href;</script>");
                }
                else if (Ifrmae.Text.Trim().Equals(""))
                {
                    Response.Write("<script>alert('Endereço da Url do Video não pode ser Nulo ou Vázio'); window.location.href = window.location.href;</script>");
                }
                else
                {
                    video = new Videos();
                    videoRegraNegocios = new VideosRegraNegocios();

                    video.Nome = NomeVideo.Text.Trim();
                    video.Url = Ifrmae.Text.Trim();
                    video.IdUsuario = 0;

                    int idRed = videoRegraNegocios.Salvar(video);

                    if (idRed > 0)
                    {
                        Response.Redirect("~/Cadastros/Video.aspx", false);
                    }
                    else
                    {
                        Response.Write("<script>alert('Erro ao Cadastrar Video.'); window.location.href = window.location.href;</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
                //Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Erro'" + ex.Message + ")</script>");
            }
        }
    }
}