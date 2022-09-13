using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.MORADA.SOL.OBJETO.TRANSFERENCIA
{
    public class Agendas
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdUsuario { get; set; }
        public int IdTipoImovel { get; set; }
        public string Local { get; set; }
        public string Datas { get; set; }
        public int Postagem { get; set; }
        public string UrlImagem { get; set; }
        public string Contato { get; set; }
        public DateTime DataInicio { get; set; }
        public int PublicoEstimado { get; set; }
        public int PublicoPresente { get; set; }
        public string Observacao { get; set; }
        public int Ordem { get; set; }
        public string SiteCliente { get; set; }
        public string Sessao { get; set; }
        public int Status { get; set; }

        public Imagem Imagem { get; set; }
    }
}
