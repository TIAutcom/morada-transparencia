using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.REGRA.NEGOCIOS;
using TI.MORADA.SOL.OBJETO.TRANSFERENCIA;

namespace TI.MORADA.SOL.UI.Cadastros
{
    public partial class Lei : System.Web.UI.Page
    {
        #region VARIAVEIS

        public int idUsuario, idNivel = 0;
        public int idLai = 0;
        public string _login, _laiDesc = "";

        #endregion

        #region CLASSES E OBJETOS

        Leis lei;
        LeisRegraNegocios leisRegraNegocios;

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

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        public void Salvar()
        {
            try
            {
                leisRegraNegocios = new LeisRegraNegocios();
                lei = new Leis();

                lei.Id = 0;
                lei.Descricao = Descricao.Text.Trim();
                lei.IdUsuario = idUsuario;
                lei.Data = DateTime.Now.Date;

                try
                {
                    string idRet = leisRegraNegocios.Salvar(lei);

                    Response.Write("<script>alert('Lei de Acesso de Informação foi Reealizado com Sucesso.'); window.location.href = window.location.href;</script>");
                }
                catch
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Erro ao Cadastrar Lei de Acesso.')</script>");
                    Descricao.Focus();
                }
            }
            catch (Exception ex)
            {
                lblResponse.Text = "Erro no Metodo Salvar Nova Lei.' " + ex.Message + "";
                Descricao.Focus();
            }
        }
    }
}