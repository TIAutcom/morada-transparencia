using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TI.MORADA.SOL.OBJETO.TRANSFERENCIA;

namespace TI.MORADA.SOL.REGRA.NEGOCIOS
{
    public class GerararXmlRegraNegocios
    {

        XmlDocument xml = new XmlDocument();
        StringBuilder sb;
        XmlDocument xmldoc;

        public string PagamentoFolhaOrdinariaAgentePublico(string path)
        {
            try
            {
                sb = new StringBuilder();
                xml = new XmlDocument();

                sb.Append("<PagamentoFolhaOrdinariaAgentePublico>");

                #region DESCRITOR

                //PRECISA PEGAR ESSAS INFORMAÇÃO DA ENTIDADE 
                sb.Append("<Descritor>");
                sb.Append("<AnoExercicio>2020</AnoExercicio>");
                sb.Append("<TipoDocumento> Pagamento de Folha Ordinária </TipoDocumento>");
                sb.Append("<Entidade>10048</Entidade>");
                sb.Append("<Municipio>7107</Municipio>");
                sb.Append("<DataCriacaoXML> 2020 - 01 - 17 </DataCriacaoXML>");
                sb.Append("<MesExercicio> 1 </MesExercicio>");
                sb.Append("</Descritor>");

                #endregion;

                //ANO QUE A FOLHA FOI PAGA
                sb.Append("<AnoPagamento>2020</AnoPagamento>");
                //MES QUE A FOLHA FOI PAGA
                sb.Append("<MesPagamento>1</MesPagamento>");
                sb.Append("<!-- :PagamentoAtrasado/> --> <!-- opcional: apenas para pagamento relativo a períodos anteriores -->");

                #region INDENTIFICACAO AGENTE PUBLICO

                sb.Append("<IdentificacaoAgentePublico>");

                #region CPF

                sb.Append("<CPF Tipo=\"02\">");
                //Número do CPF do Agente Público (formato 11 dígitos)
                sb.Append("<Numero> 00000000191</Numero>");
                sb.Append("</CPF>");

                #endregion

                //Código do município em que o agente público está lotado
                sb.Append("<MunicipioLotacao> 7107 </MunicipioLotacao>");

                //Código da entidade em que o agente público está lotado
                sb.Append("<EntidadeLotacao> 10048 </EntidadeLotacao>");

                //Código do cargo ocupado pelo agente público
                sb.Append("<CodigoCargo> 1 </CodigoCargo>");

                // Código da função ocupada pelo agente público(esta tag deve ser usada apenas se a tag CodigoCargo não for preenchida)
                sb.Append("<CodigoFuncao> 1 </CodigoFuncao>");

                //Forma de Pagamento (1 – Conta corrente; 2 – Demais; 3 – Ambas)
                sb.Append("<formaPagamento> 1 </formaPagamento>");

                //Número do Banco. Tag a ser preenchida se  pagamento em conta corrente.
                sb.Append("<numeroBanco> 123 </numeroBanco>");
                //Número do Banco. Tag a ser preenchida se  pagamento em conta corrente pagamento em conta corrente..
                sb.Append("<agencia> 456 </agencia>");

                //Número da Conta Corrente. Tag a ser preenchida se pagamento em conta corrente.
                sb.Append("<ContaCorrente> 7890 </ContaCorrente>");

                #region VALORES

                sb.Append("<Valores>");
                sb.Append("<valorPagoContaCorrente> 5000 </valorPagoContaCorrente>");
                sb.Append("<valorPagoOutrasFormas> 0 </valorPagoOutrasFormas>");
                sb.Append("</Valores>");

                #endregion

                sb.Append("</IdentificacaoAgentePublico>");

                #endregion

                sb.Append("<IdentificacaoPensionista>");

                sb.Append("<CPF Tipo=\"02\">");
                sb.Append("<Numero > 00000000272 </Numero>");
                sb.Append("</CPF>");
                sb.Append("<MunicipioLotacaoAgentePublico>7107</MunicipioLotacaoAgentePublico>");
                sb.Append("<EntidadeLotacaoAgentePublico>10048</EntidadeLotacaoAgentePublico>");
                sb.Append("<formaPagamento>1</formaPagamento>");
                sb.Append("<numeroBanco>123</numeroBanco>");
                sb.Append("<agencia>456</agencia>");
                sb.Append("<ContaCorrente>789X</ContaCorrente>");
                sb.Append("<Valores>");
                sb.Append("<valorPagoContaCorrente>3332.32 </valorPagoContaCorrente>");
                sb.Append("<valorPagoOutrasFormas> 0 </valorPagoOutrasFormas>");
                sb.Append("</Valores>");
                sb.Append("</IdentificacaoPensionista>");

                sb.Append("</PagamentoFolhaOrdinariaAgentePublico>");

                string xm = sb.ToString();

                xml.LoadXml(sb.ToString());
                xml.Save(path + "\\SERVIÇOS\\XMLs\\FOLHA_PAGAMENTO_ORDINARIA_AGENTE_PUBLICO\\DOCUMENTO.xml");

                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GerarXmlResumoMensalFolhaPagamentoEnvelope(string xmlResumoMensalFolhaPagamento, string pathConfiguracao)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                "<rem:ResumoMensalFolhaPagamento xmlns=\"http://www.tce.sp.gov.br/audesp/xml/generico" +
                "xmlns:ap =\"http://www.tce.sp.gov.br/audesp/xml/atospessoal" +
                "xmlns:aux =\"http://www.tce.sp.gov.br/audesp/xml/auxiliar" +
                "xmlns:rem =\"http://www.tce.sp.gov.br/audesp/xml/remuneracao" +
                "xmlns:xsi =\"http://www.w3.org/2001/XMLSchema-instance" +
                "xsi: schemaLocation =\"http://www.tce.sp.gov.br/audesp/xml/remuneracao ../remuneracao/AUDESP_RESUMO_MENSAL_FOLHA_PAGAMENTO_2020_A.XSD\">" +
                xmlResumoMensalFolhaPagamento

                );

                return sb.ToString();

                xmldoc = new XmlDocument();

                xmldoc.LoadXml(sb.ToString());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GerarXmlResumoMensalFolhaPagamento(ResumoMensalFolhaPagamento resumoMensalFolhaPagamento, string pathConfiguracao)
        {
            try
            {
                sb = new StringBuilder();
                xml = new XmlDocument();

                sb.Append("<?xml version=\"1.0\" encoding=\"ISO-8859-1\"?>");

                sb.Append("<rem:ResumoMensalFolhaPagamento xmlns:gen=\"http://www.tce.sp.gov.br/audesp/xml/generico\" xmlns:ap=\"http://www.tce.sp.gov.br/audesp/xml/atospessoal\" xmlns:aux=\"http://www.tce.sp.gov.br/audesp/xml/auxiliar\" xmlns:rem=\"http://www.tce.sp.gov.br/audesp/xml/remuneracao\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:schemaLocation=\"http://www.tce.sp.gov.br/audesp/xml/remuneracao../remuneracao/AUDESP_RESUMO_MENSAL_FOLHA_PAGAMENTO_2020_A.XSD\">");

                #region DESCRITOR

                sb.Append("<rem:Descritor>");

                sb.Append("<gen:anoExercicio>" + resumoMensalFolhaPagamento.AnoExercicio + "</gen:anoExercicio>");
                sb.Append("<gen:TipoDocumento>" + resumoMensalFolhaPagamento.TipoDocumento + "</gen:TipoDocumento>");
                sb.Append("<gen:Entidade>" + resumoMensalFolhaPagamento.Entidade + "</gen:Entidade>");
                sb.Append("<gen:Municipio>" + resumoMensalFolhaPagamento.Municipio + "</gen:Municipio>");
                sb.Append("<gen:DataCriacaoXML>" + resumoMensalFolhaPagamento.DataCriacaoXML + "</gen:DataCriacaoXML>");
                sb.Append("<gen:MesExercicio>" + resumoMensalFolhaPagamento.MesExercicio + "</gen:MesExercicio>");

                sb.Append("</rem:Descritor>");

                #endregion


                #region LISTA RESUMO FOLHA PAGAMENTO

                sb.Append("<rem:ListaResumoFolhaPagamento>");

                #region MUNICIPIO ENTIDADE LOTACAO

                sb.Append("<rem:MunicipioEntidadeLotacao>");

                sb.Append("<rem:codigoMunicipio>" + resumoMensalFolhaPagamento.codigoMunicipio + "</rem:codigoMunicipio>");
                sb.Append("<rem:codigoEntidade>" + resumoMensalFolhaPagamento.codigoEntidade + "</rem:codigoEntidade>");

                sb.Append("</rem:MunicipioEntidadeLotacao>");

                #endregion

                sb.Append("<gen:VlFGTS>" + resumoMensalFolhaPagamento.VlFGTS + "</gen:VlFGTS>");
                sb.Append("<gen:VlContribPrevGeralAgPolitico>" + resumoMensalFolhaPagamento.VlContribPrevGeralAgPolitico + "</gen:VlContribPrevGeralAgPolitico>");
                sb.Append("<gen:VlContribPrevProprioAgPolitico>" + resumoMensalFolhaPagamento.VlContribPrevProprioAgPolitico + "</gen:VlContribPrevProprioAgPolitico>");
                sb.Append("<gen:VlContribPrevGeralAgNaoPolitico>" + resumoMensalFolhaPagamento.VlContribPrevGeralAgNaoPolitico + "</gen:VlContribPrevGeralAgNaoPolitico>");
                sb.Append("<gen:VlContribPrevProprioAgNaoPolitico>" + resumoMensalFolhaPagamento.VlContribPrevProprioAgNaoPolitico + "</gen:VlContribPrevProprioAgNaoPolitico>");

                sb.Append("</rem:ListaResumoFolhaPagamento>");

                #endregion

                sb.Append("</rem:ResumoMensalFolhaPagamento>");

                string xm = sb.ToString();

                xml.LoadXml(sb.ToString());
                xml.Save(pathConfiguracao + "\\SERVIÇOS\\XMLs\\AUDESP_RESUMO_MENSAL_FOLHA_PAGAMENTO\\RESUMO.xml");

                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}