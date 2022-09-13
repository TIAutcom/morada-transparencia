using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.OBJETO.TRANSFERENCIA;
using TI.MORADA.SOL.REGRA.NEGOCIOS;

namespace TI.MORADA.SOL.SITE.UI
{
    public partial class Default : System.Web.UI.Page
    {
        #region CLASSES E OBJETOS

        Emails email;
        EnviarEmail enviarEmail;

        ControleAcessoRegraNegocios controleAcessoRegraNegocios;

        #endregion

        #region VARIAVEIS

        int cont = 0;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Enviar()
        {
            try
            {
                email = new Emails();

                email.Nome = Request["name"];
                email.Destinatario = Request["email"];
                email.Remetente = "contato@cearararaquara.com.br";
                email.Assunto = Request["assunto"];
                email.Mensagem = "De: " + email.Nome + " - " + email.Destinatario + "<br/>" + email.Assunto.Trim() + "<br/>" + Request["message"];
                email.Pagina = "Contato - Morada do Sol Turismo Eventos e Participações S/A";

                enviarEmail = new EnviarEmail();

                string retornoEmail = enviarEmail.EnviarMesagemEmail(email);

                if (retornoEmail != null)
                {
                    enviarEmail = new EnviarEmail();

                    enviarEmail.EnviarMesagemEmailresposta(email);

                    Response.Write("<script>alert('E-Mail Enviado com Sucesso.'); window.location.href = window.location.href;</script>");
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('erro ao enviar e-mail')</script>");
                }
            }
            catch (Exception ex)
            {
                Session.Clear();
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Enviar();
        }
    }
}