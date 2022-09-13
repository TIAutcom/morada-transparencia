using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.REGRA.NEGOCIOS;

namespace TI.MORADA.SOL.ADMINISTRACAO.Views
{
    public partial class Listas : System.Web.UI.Page
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
                ListarAgenda();
            }
        }

        protected void gdvAgenda_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("SelecioneEvento"))
            {

                GridViewRow row = null;
                int index = Convert.ToInt32(e.CommandArgument);
                row = gdvAgenda.Rows[index];

                int id = Convert.ToInt32(index);


                string desc = gdvAgenda.DataKeys[index].Values["Descricao"].ToString().Trim();

                Response.Redirect("~/Cadastro/Foto.aspx?Id=" + id + "&Titulo=" + desc, true);
            }
        }


        public void ListarAgenda()
        {
            try
            {
                agendaRegraNegocios = new AgendaRegraNegocios();
                DataTable dadosTabela = new DataTable();
                try
                {

                    dadosTabela = agendaRegraNegocios.ListarAdm();
                }
                catch
                {
                    dadosTabela = null;
                }

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
    }
}