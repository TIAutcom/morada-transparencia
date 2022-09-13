using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.REGRA.NEGOCIOS;

namespace TI.MORADA.SOL.UI.Forms.Views
{
    public partial class Calendario : System.Web.UI.Page
    {
        DataTable dadosTabela = new DataTable();
        AgendaRegraNegocios agendaRegraNegocios;

        protected void Page_Load(object sender, EventArgs e)
        {
            PesquisarData();
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            //lblData.Text = datas = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
            Calendar1.SelectedDayStyle.BackColor = System.Drawing.Color.Blue;



            //PesquisarDatas();
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            try
            {
                Literal litFeriado = new Literal();
                StringBuilder sbHtml = new StringBuilder();

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

                            if (data1.CompareTo(data2) == 1)
                            {
                                e.Cell.BackColor = System.Drawing.Color.Green;
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

        public void PesquisarData()
        {
            dadosTabela = new DataTable();
            agendaRegraNegocios = new AgendaRegraNegocios();
            dadosTabela = agendaRegraNegocios.ListarAgendaAll();
        }
    }
}