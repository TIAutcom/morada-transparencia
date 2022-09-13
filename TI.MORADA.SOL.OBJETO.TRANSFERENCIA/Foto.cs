using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.MORADA.SOL.OBJETO.TRANSFERENCIA
{
    public class Foto
    {
        public int Id { get; set; }
        public int IdTipo { get; set; }
        public string Url { get; set; }
        public string Titulo { get; set; }
        public string DEscricao { get; set; }
        public DateTime Data { get; set; }
        public int IdUsuario { get; set; }
    }
}
