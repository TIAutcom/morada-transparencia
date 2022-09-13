using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.REGRA.NEGOCIOS;

namespace TI.MORADA.SOL.UI.Forms.Views
{
    public partial class Agenda : System.Web.UI.Page
    {
        #region CLASSES E OBJETOS

        AgendaRegraNegocios agendaRegraNegocios;
        MesRegraNegocios mesRegraNegocios;

        #endregion

        #region VARIAVEIS

        int idUsuario, idNivel = 0;
        int mes, ano = 0;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetDados();
                CarregarLista();
                ListarAgenda();
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

        public void ListarAgenda()
        {
            try
            {
                agendaRegraNegocios = new AgendaRegraNegocios();
                DataTable dadosTabela = new DataTable();

                mes = Convert.ToInt32(ddlMes.SelectedValue);
                ano = Convert.ToInt32(ddlAno.SelectedValue);

                if (mes > 0 && mes <= 12)
                {
                    dadosTabela = agendaRegraNegocios.ListarAgenda(mes, ano);
                }
                else
                {
                    dadosTabela = agendaRegraNegocios.ListarAgendaAno(ano);
                }

                dadosTabela = agendaRegraNegocios.ListarAgenda(mes, ano);

                if (dadosTabela.Rows.Count > 0)
                {
                    gdvAgenda.DataSource = null;
                    gdvAgenda.DataSource = dadosTabela;
                    gdvAgenda.DataBind();
                }
                else
                {
                    gdvAgenda.DataSource = null;
                    gdvAgenda.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        protected void ddlMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarAgenda();
        }

        protected void gdvAgenda_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("SelecioneEvento"))
            {
                int id = Convert.ToInt32(e.CommandArgument);

                Response.Redirect("~/Forms/Views/DadosAgenda.aspx?IdAgenda=" + id, true);
            }
        }

        protected void ddlAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarAgenda();
        }

        public void CarregarLista()
        {
            try
            {
                mesRegraNegocios = new MesRegraNegocios();

                ddlMes.DataSource = mesRegraNegocios.ListarMes();
                ddlMes.DataValueField = "Id";
                ddlMes.DataTextField = "Mes";
                ddlMes.DataBind();
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }
    }
}