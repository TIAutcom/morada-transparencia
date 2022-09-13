using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.MORADA.SOL.OBJETO.TRANSFERENCIA
{
    public class Diretorias
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Url { get; set; }
        public string Descricao { get; set; }
        public int IdUsuario { get; set; }

        public string Cpf { get; set; }
        public string PisPasep { get; set; }
        public string Genero { get; set; }
        public string Nascionalidade { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Especialidade { get; set; }
        public decimal Salario { get; set; }
        public string Escolaridade { get; set; }
        public bool Status { get; set; }
        public bool AltSite { get; set; }

        public Cargo Cargos { get; set; }
    }
}
