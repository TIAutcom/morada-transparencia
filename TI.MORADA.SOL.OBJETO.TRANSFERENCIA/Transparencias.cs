using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.MORADA.SOL.OBJETO.TRANSFERENCIA
{
    public class Transparencias
    {
        public int Id { get; set; }
        public int IdLai { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public int Ordem { get; set; }
        public int IdUsuario { get; set; }
    }
}
