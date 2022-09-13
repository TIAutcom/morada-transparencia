using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.MORADA.SOL.OBJETO.TRANSFERENCIA
{
    public class Administracao
    {
        public int Id { get; set; }
        public int IdLocal { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataCad { get; set; }
        public DateTime DataEvento { get; set; }
        public string Descricao { get; set; }
        public int IdTipoEvento { get; set; }
        public string HoraEvento { get; set; }
        public int PubEstimado { get; set; }
        public int PubPresente { get; set; }
        public string PercPubFamilia { get; set; }
        public string PercPublicoJovem { get; set; }
        public string PercPublicoCasal { get; set; }
        public int Regiao { get; set; }
        public int Cidade { get; set; }
        public string Obs { get; set; }
        public string UrlImagem { get; set; }
    }
}
