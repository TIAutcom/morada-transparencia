using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.OBJETO.TRANSFERENCIA;
using TI.MORADA.SOL.REGRA.NEGOCIOS;

namespace TI.MORADA.SOL.SITE.UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        Usuarios usurio;
        UsuarioRegraNegocios usuarioRegraNegocios;

        string login = "";
        string senha = "";

        protected void Log_Click(object sender, EventArgs e)
        {
            login = Request["username"];
            senha = Request["password"];

            if (login.Trim().Equals(""))
            {
                Response.Write("<script>alert('* Campo Login não Pode ser Nulo ou vázio.'); window.location.href = window.location.href;</script>");
            }
            else if (senha.Trim().Equals(""))
            {
                Response.Write("<script>alert('* Campo Senha não Pode ser Nulo ou vázio.'); window.location.href = window.location.href;</script>");
            }
            else
            {
                usurio = new Usuarios();

                usurio.Email = login;
                usurio.Senha = senha;

                Response.Redirect("http://transparencia.moradaturismoeventos.com.br/");
            }
        }
    }
}