using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.MORADA.SOL.OBJETO.TRANSFERENCIA
{
    public class Cargo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdDiretor { get; set; }
        public string TipoCargo { get; set; }
        public string CodCargo { get; set; }
        public string RegimeJuridico { get; set; }
        public string Escolaridade { get; set; }
        public string ExercicioAtividade { get; set; }
        public string FormaProvidencia { get; set; }
        public string HrMensalTrabalho { get; set; }
        public bool CargoPolitico { get; set; }
        public bool RespEntidade { get; set; }
    }
}
