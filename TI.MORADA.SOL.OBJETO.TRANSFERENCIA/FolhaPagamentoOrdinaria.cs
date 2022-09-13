using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.MORADA.SOL.OBJETO.TRANSFERENCIA
{
    public class FolhaPagamentoOrdinaria
    {
        public string AnoExercicio { get; set; }
        public string TipoDocumento { get; set; }
        public string Entidade { get; set; }
        public string Municipio { get; set; }
        public string DataCriacaoXML { get; set; }
        public string MesExercicio { get; set; }
        public string AnoPagamento { get; set; }
        public string MesPagamento { get; set; }
        public string NumeroIAP { get; set; }
        public string MunicipioLotacao { get; set; }
        public string EntidadeLotacao { get; set; }
        public string formaPagamentoIAP { get; set; }
        public string numeroBancoIAP { get; set; }
        public string agenciaIAP { get; set; }
        public string ContaCorrenteIAP { get; set; }
        public string valorPagoContaCorrenteIAP { get; set; }
        public string valorPagoOutrasFormasIAP { get; set; }
        public string MunicipioLotacaoAgentePublico { get; set; }
        public string EntidadeLotacaoAgentePublico { get; set; }
        public string numeroIP { get; set; }
        public string formaPagamentoIP { get; set; }
        public string numeroBancoIP { get; set; }
        public string agenciaIP { get; set; }
        public string ContaCorrenteIP { get; set; }
        public string valorPagoContaCorrenteIP { get; set; }
        public string valorPagoOutrasFormasIP { get; set; }
    }
}
