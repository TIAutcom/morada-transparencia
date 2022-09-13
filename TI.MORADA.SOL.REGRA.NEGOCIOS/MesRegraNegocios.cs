using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.MORADA.SOL.OBJETO.TRANSFERENCIA;

namespace TI.MORADA.SOL.REGRA.NEGOCIOS
{
    public class MesRegraNegocios
    {
        public List<Meses> ListarMes()
        {
            List<Meses> lista = new List<Meses>();

            Meses mes0 = new Meses();
            mes0.Id = DateTime.Now.Month;
            mes0.Mes = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Date.Month).ToUpper().ToString();
            lista.Add(mes0);

            Meses mes1 = new Meses();
            mes1.Id = 1;
            mes1.Mes = "JANEIRO";
            lista.Add(mes1);

            Meses mes2 = new Meses();
            mes2.Id = 2;
            mes2.Mes = "FEVEREIRO";
            lista.Add(mes2);

            Meses mes3 = new Meses();
            mes3.Id = 3;
            mes3.Mes = "MARÇO";
            lista.Add(mes3);

            Meses mes4 = new Meses();
            mes4.Id = 4;
            mes4.Mes = "ABRIL";
            lista.Add(mes4);

            Meses mes5 = new Meses();
            mes5.Id = 5;
            mes5.Mes = "MAIO";
            lista.Add(mes5);

            Meses mes6 = new Meses();
            mes6.Id = 6;
            mes6.Mes = "JUNHO";
            lista.Add(mes6);

            Meses mes7 = new Meses();
            mes7.Id = 7;
            mes7.Mes = "JULHO";
            lista.Add(mes7);

            Meses mes8 = new Meses();
            mes8.Mes = "AGOSTO";
            mes8.Id = 8;
            lista.Add(mes8);

            Meses mes9 = new Meses();
            mes9.Mes = "SETEMBRO";
            mes9.Id = 9;
            lista.Add(mes9);

            Meses mes10 = new Meses();
            mes10.Mes = "OUTUBRO";
            mes10.Id = 10;
            lista.Add(mes10);

            Meses mes11 = new Meses();
            mes11.Mes = "NOVEMBRO";
            mes11.Id = 11;
            lista.Add(mes11);

            Meses mes12 = new Meses();
            mes12.Mes = "DEZEMBRO";
            mes12.Id = 12;
            lista.Add(mes12);

            Meses mes13 = new Meses();
            mes13.Mes = "ANO TODO";
            mes13.Id = 13;
            lista.Add(mes13);

            return lista;
        }
    }
}
