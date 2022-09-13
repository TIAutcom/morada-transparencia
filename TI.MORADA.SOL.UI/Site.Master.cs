using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

namespace TI.MORADA.SOL.UI
{
    public partial class SiteMaster : MasterPage
    {
        int idUsuario = 0;
        int idNivel = 0;

        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;

        protected void Page_Init(object sender, EventArgs e)
        {
            // The code below helps to protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };

                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set Anti-XSRF token
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            }
            else
            {
                // Validate the Anti-XSRF token
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetDados();
            }
        }

        public void GetDados()
        {
            idUsuario = Convert.ToInt32(Session["IdUsuario"]);

            if (idUsuario != 0)
            {
                idUsuario = Convert.ToInt32(Session["IdUsuario"]);
                idNivel = Convert.ToInt32(Session["IdNivel"]);

                Session["nomeLogin"] = "OPERADOR(A): " + "[ " + Session["Usuario"].ToString().ToUpper() + " ] - N: " + idNivel.ToString().PadLeft(2, '0');

                if (idNivel == 1)
                {
                    Panel1.Visible = true;
                    Panel2.Visible = false;
                    Panel3.Visible = false;
                    Panel4.Visible = false;
                }
                else if (idNivel == 2)
                {
                    Panel1.Visible = false;
                    Panel2.Visible = true;
                    Panel3.Visible = false;
                    Panel4.Visible = false;
                }
                else if (idNivel == 3)
                {
                    Panel1.Visible = false;
                    Panel2.Visible = false;
                    Panel3.Visible = true;
                    Panel4.Visible = false;
                }

                pnlRodape.Visible = true;
            }
            else
            {
                idUsuario = Convert.ToInt32(Session["IdUsuario"]);

                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = false;
                Panel4.Visible = true;

                pnlRodape.Visible = false;
            }
        }


        protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }
    }
}