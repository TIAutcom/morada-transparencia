using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.MORADA.SOL.REGRA.NEGOCIOS
{
    public class ImproperCalendarEvent
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public bool allDay { get; set; }
        public string status { get; set; }
        public string local { get; set; }
    }
}
