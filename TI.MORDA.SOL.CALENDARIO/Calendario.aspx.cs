using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using TI.MORADA.SOL.OBJETO.TRANSFERENCIA;
using TI.MORADA.SOL.REGRA.NEGOCIOS;

namespace TI.MORDA.SOL.CALENDARIO
{
    public partial class Calendario : System.Web.UI.Page
    {
        DataTable dadosTabela;

        AgendaRegraNegocios agendaRegraNegocios;

        string data = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            dadosTabela = new DataTable();
            agendaRegraNegocios = new AgendaRegraNegocios();
            dadosTabela = agendaRegraNegocios.ListarAgendaAll();
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            try
            {
                if (dadosTabela.Rows.Count > 0)
                {
                    for (int i = 0; i < dadosTabela.Rows.Count; i++)
                    {
                        int dia = Convert.ToDateTime(dadosTabela.Rows[i]["DataIni"].ToString()).Day;
                        int mes = Convert.ToDateTime(dadosTabela.Rows[i]["DataIni"].ToString()).Month;
                        int ano = Convert.ToDateTime(dadosTabela.Rows[i]["DataIni"].ToString()).Year;

                        if (e.Day.Date == new DateTime(ano, mes, dia))
                        {
                            DateTime data1;
                            DateTime data2;

                            data1 = DateTime.Parse(dadosTabela.Rows[i]["DataIni"].ToString());
                            data2 = DateTime.Parse(DateTime.Now.Date.ToString());

                            int comp = data1.CompareTo(data2);

                            if (comp == 1)
                            {
                                e.Cell.BackColor = System.Drawing.Color.Green;
                            }
                            else if (comp == 0)
                            {
                                e.Cell.BackColor = System.Drawing.Color.Yellow;
                            }
                            else
                            {
                                e.Cell.BackColor = System.Drawing.Color.Red;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            LimparVariaveis();
            lblData.Text = data = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
            Calendar1.SelectedDayStyle.BackColor = System.Drawing.Color.Blue;
            PesquisarDatas();
        }

        public void LimparVariaveis()
        {
            data = "";
        }

        public void PesquisarDatas()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                agendaRegraNegocios = new AgendaRegraNegocios();

                dadosTabela = agendaRegraNegocios.PesquisaAgendaData(Convert.ToDateTime(data));

                if (dadosTabela.Rows.Count > 0)
                {
                    gdvEventos.DataSource = null;
                    gdvEventos.DataSource = dadosTabela;
                    gdvEventos.DataBind();
                }
                else
                {
                    gdvEventos.DataSource = null;
                    gdvEventos.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        public void btnPesquisar_onclick()
        {
            string x = "";
        }
    }
}