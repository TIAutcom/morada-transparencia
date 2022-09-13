using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.MORADA.SOL.OBJETO.TRANSFERENCIA
{
    public class ResumoMensalFolhaPagamento
    {
        public string AnoExercicio { get; set; }
        public string TipoDocumento { get; set; }
        public string Entidade { get; set; }
        public string Municipio { get; set; }
        public string DataCriacaoXML { get; set; }
        public string MesExercicio { get; set; }

        public string codigoEntidade { get; set; }
        public string codigoMunicipio { get; set; }

        public string VlFGTS { get; set; }
        public string VlContribPrevGeralAgPolitico { get; set; }
        public string VlContribPrevProprioAgPolitico { get; set; }
        public string VlContribPrevGeralAgNaoPolitico { get; set; }
        public string VlContribPrevProprioAgNaoPolitico { get; set; }
    }
}
