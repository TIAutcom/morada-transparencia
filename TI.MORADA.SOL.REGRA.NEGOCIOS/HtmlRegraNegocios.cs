using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.MORADA.SOL.REGRA.NEGOCIOS
{
    public class HtmlRegraNegocios
    {

        public string GerarHtmlAgenda(string imagem, string titulo, string descricao, string siteCliente, string local, string data, int id, string sessao)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("<div class='col -lg-3 col-md-4 col-sm-6 portfolio-item'>");
                sb.Append("<div class='card h-100'>");
                sb.Append("<a>");
                sb.Append("<a href='#" + id + "'><img class='card-img-top' src='" + imagem + "' style='height:200px;' class='img-responsive' alt='Traffic' data-placement='right' title='Detalhes do Evento'></a>");
                sb.Append("<div class='card-body'>");
                sb.Append("<h5 class='card-title'>");
                sb.Append("<a href='#" + id + "'>" + titulo + "</a>");
                sb.Append("</h5>");
                sb.Append("<b>");
                sb.Append("<p class='card-text'>" + "LOCAL: CEAR - Centro de Convenção/" + local + "</p>");
                sb.Append("<p class='card-text'>" + "DATA: " + data.Replace(",", " ") + "</p>");

                sb.Append("<hr/>");
                sb.Append("</b>");
                sb.Append("<p class='card-text'>Evento: " + descricao + "</p>");
                sb.Append("</a>");
                sb.Append("</div>");
                sb.Append("</div>");
                sb.Append("</div>");

                //---------------------------------------------------------------------------------------

                sb.Append("<div id='" + id + "' class='modalDialog'>");
                sb.Append("<div class='col -lg-3 col-md-4 col-sm-6 portfolio-item'>");
                sb.Append("<a href='#close' title='Close' class='close'>X</a>");

                sb.Append("<div>");
                //sb.Append("<p>CEAR - Eventos</p>");
                sb.Append("<br/>");
                sb.Append("<br/>");

                sb.Append("<div class='card h-100'>");
                sb.Append("<a>");

                if (siteCliente.Trim().Equals(""))
                {
                    sb.Append("<a href='#" + id + "'><img class='card-img-top' src='" + imagem + "' style='height:200px;' class='img-responsive' alt='Traffic' data-placement='right' title='Site do Eventos'></a>");
                }
                else
                {
                    sb.Append("<a href='" + siteCliente + " 'target='_blank'><img class='card-img-top' src='" + imagem + "' style='height:200px;' class='img-responsive' alt='Traffic' data-placement='right' title='Site do Eventos' href='" + siteCliente + " 'target='_blank'></a>");
                }

                sb.Append("<div class='card-body'>");
                sb.Append("<h4 class='card-title'>");

                if (siteCliente.Trim().Equals(""))
                {
                    sb.Append("<a href='#" + id + "'>" + titulo + "</a>");
                }
                else
                {
                    sb.Append("<a href='" + siteCliente + " 'target='_blank'>" + titulo + "</a>");
                }

                sb.Append("</h4>");
                sb.Append("<b>");
                sb.Append("<p class='card-text'>" + "LOCAL: CEAR - Centro de Convenção/" + local + "</p>");
                sb.Append("<p class='card-text'>" + "DATA: " + data.Replace(",", " ") + "</p>");

                sb.Append("</b>");
                sb.Append("<p class='card-text'>Horario: " + sessao + "</p>");
                sb.Append("</a>");

                sb.Append("<div class='card-footer'>");
                sb.Append("<small class='text-muted'>&#9733; &#9733; &#9733; &#9733; &#9734;</small>");
                sb.Append("</div>");



                sb.Append("</div>");
                sb.Append("</div>");
                sb.Append("</div>");


                sb.Append("</div>");
                sb.Append("</div>");


                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GerarHtmlDetalhesDiretor(string nome, string cargo, string curriculo, string imagem, string desc)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("<div class='col-sm-6 col-md-8'>");
                sb.Append("<div class='thumbnail'>");
                sb.Append("<div class='col-md-0'>");
                sb.Append("<img class='img-fluid' src=' " + imagem + "' alt=''>");
                sb.Append("</div>");
                sb.Append("<div class='col-md-8'>");
                sb.Append("<h3 class='my-3'>");
                sb.Append("<a href='" + curriculo + "' target='_blank'> " + nome + " </a>");
                sb.Append("</h3>");
                sb.Append("<h4>" + cargo + "</h4>");
                sb.Append("<p>" + desc + "</p>");


                if (curriculo.Trim().Equals(""))
                {
                    sb.Append("<a href=''>Ver Curriculo PDF</a>");
                }
                else
                {
                    sb.Append("<a href='" + curriculo + "' target='_blank'>Ver Curriculo PDF</a>");
                }

                sb.Append("</div>");
                sb.Append("</div>");
                sb.Append("</div>");

                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GerarHtmlObras(string url, string titulo, string descricao)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("<div class='col-sm-6 col-md-4'>");
                sb.Append("<div class='thumbnail'>");
                sb.Append("<a class='lightbox ' href='" + url + "' border='0'>");
                sb.Append("<img src='" + url + "'style='height:200px;' class='img-responsive' alt='Traffic'>");
                sb.Append("</a>");
                sb.Append("<div class='caption'>");
                sb.Append("<b>");
                sb.Append("<center>");
                sb.Append("<h4>" + titulo + "</h4>");
                sb.Append("</b>");
                sb.Append("<p>" + descricao + "</p>");
                sb.Append("</center>");
                sb.Append("</div>");
                sb.Append("</div>");
                sb.Append("</div>");

                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GerarHtmlDiretoria(string url, string nome, string cargo, string descricao, int id, string curriculo)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("<div class='col-sm-6 col-md-4'>");
                sb.Append("<div class='thumbnail'>");
                //sb.Append("<a class='lightbox' href='" + url + "' border='0'>");
                sb.Append("<a href='#" + id + "'>");
                sb.Append("<img class='card-img-top' src='" + url + "' style='height:200px; width:100%;' class='img-responsive' alt='Traffic' data-placement='right' title='Detalhes do Evento'></a>");
                //sb.Append("<img src='" + url + "' style='width:100%'>");
                //sb.Append("</a>");
                sb.Append("<div class='caption'>");
                sb.Append("<b>");
                sb.Append("<center>");
                sb.Append("<a href='#" + id + "'>");
                sb.Append("<h4>" + nome + "</h4>");
                sb.Append("</a>");
                sb.Append("</b>");
                sb.Append("<p>" + cargo + ".</p>");
                sb.Append("<p>" + descricao + ".</p>");
                sb.Append("</center>");
                sb.Append("</div>");


                //////////////////////////////////////////////////////////


                sb.Append("<div id='" + id + "' class='modalDialog'>");
                sb.Append("<div class='col -lg-3 col-md-4 col-sm-6 portfolio-item'>");
                sb.Append("<a href='#close' title='Close' class='close'>X</a>");

                sb.Append("<h4 class='card-title'>");
                sb.Append("Informações Pessoais");
                sb.Append("</h4>");
                sb.Append("<hr/>");

                sb.Append("<div class='card h-90'>");

                if (curriculo.Trim().Equals(""))
                {
                    sb.Append("<a href=''>");
                }
                else
                {
                    sb.Append("<a href='" + curriculo + "' target='_blank'>");
                }

                sb.Append("<img class='card-img-top' src='" + url + "' style='height:200px;' class='img-responsive' alt='Traffic' data-placement='right' title='Ver Curriculo Pessoal PDF'></a>");

                sb.Append("<div class='card-body'>");

                sb.Append("<hr/>");
                sb.Append("<b>");
                sb.Append("<h4 class='card-text'>" + cargo + "</h4>");
                sb.Append("</b>");

                sb.Append("<p class='card-text'>" + nome + "</p>");

                sb.Append("<hr/>");

                if (curriculo.Trim().Equals(""))
                {
                    sb.Append("<a href=''>Ver Curriculo PDF</a>");
                }
                else
                {
                    sb.Append("<a href='" + curriculo + "' target='_blank'>Ver Curriculo PDF</a>");
                }

                sb.Append("</div>");

                sb.Append("</div>");


                sb.Append("</div>");
                sb.Append("</div>");


                sb.Append("</div>");
                sb.Append("</div>");


                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
