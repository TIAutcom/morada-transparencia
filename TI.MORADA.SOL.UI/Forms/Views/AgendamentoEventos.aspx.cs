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
    public partial class AgendamentoEventos : System.Web.UI.Page
    {
        AgendaRegraNegocios agendaRegraNegocios;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarAgenda();
            }
        }

        public void ListarAgenda()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                agendaRegraNegocios = new AgendaRegraNegocios();

                dadosTabela = agendaRegraNegocios.ListarAgendamento();

                if (dadosTabela.Rows.Count > 0)
                {
                    gdvNotLog.DataSource = null;
                    gdvNotLog.DataSource = dadosTabela;
                    gdvNotLog.DataBind();
                }
                else
                {
                    gdvNotLog.DataSource = null;
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