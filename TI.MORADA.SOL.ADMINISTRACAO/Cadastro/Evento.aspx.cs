using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.OBJETO.TRANSFERENCIA;
using TI.MORADA.SOL.REGRA.NEGOCIOS;

namespace TI.MORADA.SOL.ADMINISTRACAO.Cadastro
{
    public partial class Evento : System.Web.UI.Page
    {
        #region VARIAVEIS

        int idUsuario, idNivel, erro = 0;
        public int idAgenda, idRetorno = 0;
        public string[] arquivo;
        public string dataInicial;
        string nomeArquivo, diretorio, navegador = "";

        #endregion

        #region CLASSES E OBJETOS

        Administracao adm;
        AgendaRegraNegocios agendaRegraNegocios;
        TipoImovelRegraNegocios tipoImovelRegraNegocios;
        FotoRegraNegocios fotoRegraNegocios;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Convert.ToInt32(Session["IdUsuario"]) == 0)
                {
                    Session["IdUsuario"] = 0;

                    Response.Redirect("~/Default.aspx", false);
                }

                else
                {
                    GetDados();

                    ListarLocalEvento();
                    ListarTipoEvento();
                }
            }
        }

        public void GetDados()
        {
            idUsuario = Convert.ToInt32(Session["IdUsuario"]);
            idNivel = Convert.ToInt32(Session["IdNivel"]);
        }

        public void ListarLocalEvento()
        {
            try
            {
                idUsuario = Convert.ToInt32(Session["IdUsuario"]);

                if (idUsuario > 0)
                {
                    tipoImovelRegraNegocios = new TipoImovelRegraNegocios();
                    DataTable dadosTabela = new DataTable();

                    dadosTabela = tipoImovelRegraNegocios.PesquisarLocalEvento();

                    if (dadosTabela.Rows.Count > 0)
                    {
                        ddlLocalEvento.DataSource = null;
                        ddlLocalEvento.DataSource = dadosTabela;
                        ddlLocalEvento.DataTextField = "DESCRICAO";
                        ddlLocalEvento.DataValueField = "ID";
                        ddlLocalEvento.DataBind();
                    }
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Voltar", "history.back();", true);
                    return;
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        public void ListarTipoEvento()
        {
            try
            {
                idUsuario = Convert.ToInt32(Session["IdUsuario"]);

                if (idUsuario > 0)
                {
                    tipoImovelRegraNegocios = new TipoImovelRegraNegocios();
                    DataTable dadosTabela = new DataTable();

                    dadosTabela = tipoImovelRegraNegocios.PesquisarTipoEvento();

                    if (dadosTabela.Rows.Count > 0)
                    {
                        ddlTipoEvento.DataSource = null;
                        ddlTipoEvento.DataSource = dadosTabela;
                        ddlTipoEvento.DataTextField = "DESCRICAO";
                        ddlTipoEvento.DataValueField = "ID";
                        ddlTipoEvento.DataBind();
                    }
                    else
                    {
                        ddlTipoEvento.DataSource = null;
                        ddlTipoEvento.DataBind();
                    }
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Voltar", "history.back();", true);
                    return;
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        public void Salvar()
        {
            try
            {
                if (Convert.ToInt32(Session["IdUsuario"]) == 0)
                {
                    Response.Redirect("~/Default.aspx", false);
                }
                else if (ddlLocalEvento.SelectedIndex == 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('* Campo Local do Evento é Obrigatório.')</script>");
                    ddlLocalEvento.Focus();
                }
                else if (Data.Text.Trim().Equals(""))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('* Data do Evento é Campo Obrigatório.')</script>");
                }
                //else if (Eventos.Text.Trim().Equals(""))
                //{
                //    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('* Campo Descrição do Evento é Obrigatório.')</script>");
                //    Eventos.Focus();
                //}
                //else if (DropDownList1.SelectedIndex == 0)
                //{
                //    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('* Campo Postagem do Evento é Obrigatório.')</script>");
                //}
                //else if (fupImagem.FileName.Trim().Equals(""))
                //{
                //    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('* Imagem Evento é Obrigatório.')</script>");
                //}
                else
                {
                    adm = new Administracao();

                    //agenda.Descricao = Eventos.Text.Trim();
                    adm.IdLocal = Convert.ToInt32(ddlLocalEvento.SelectedValue);
                    adm.IdUsuario = Convert.ToInt32(Session["IdUsuario"]);
                    adm.DataCad = DateTime.Now;
                    adm.DataEvento = Convert.ToDateTime(Data.Text.Trim());
                    adm.Descricao = Descricao.Text.Trim();
                    adm.IdTipoEvento = Convert.ToInt32(ddlTipoEvento.SelectedValue);
                    adm.HoraEvento = Hora.Text.Trim();
                    //adm.PubEstimado = Convert.ToInt32(PubEstimado.Text.Trim());
                    //adm.PubPresente = Convert.ToInt32(PubPresente.Text);
                    adm.PercPublicoCasal = PercCasal.Text.Trim();
                    adm.PercPubFamilia = PercFamilia.Text.Trim();
                    adm.PercPublicoJovem = PercJovem.Text.Trim();
                    adm.Regiao = Convert.ToInt32(PublicoRegiao.Text);
                    adm.Cidade = Convert.ToInt32(PublicoCidade.Text);
                    adm.Obs = Observacao.Text.Trim();
                    adm.UrlImagem = "";


                    if ((PubEstimado.Text.Trim() == null) || (PubEstimado.Text.Trim().Equals("")))
                    {
                        adm.PubEstimado = 0;
                    }
                    else
                    {
                        adm.PubEstimado = Convert.ToInt32(PubEstimado.Text.Trim());
                    }

                    if ((PubPresente.Text.Trim() == null) || (PubPresente.Text.Trim().Equals("")))
                    {
                        adm.PubPresente = 0;
                    }
                    else
                    {
                        adm.PubPresente = Convert.ToInt32(PubPresente.Text.Trim());
                    }

                    adm.Obs = Observacao.Text.Trim();

                    agendaRegraNegocios = new AgendaRegraNegocios();

                    idAgenda = agendaRegraNegocios.Salvar(adm);

                    if (idAgenda > 0)
                    {
                        Response.Write("<script>alert('Evento Inserido com Sucesso.'); window.location.href = window.location.href;</script>");
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Erro ao Inserir Dados do Evento.')</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        private void SalvarFotoGaleriaPlus()
        {
            try
            {
                HttpFileCollection uploadedFiles = Request.Files;

                for (int i = 0; i < uploadedFiles.Count; i++)
                {
                    HttpPostedFile userPostedFile = uploadedFiles[i];

                    navegador = Request.Url.Host;

                    if (navegador == "localhost")
                    {
                        navegador = this.Server.MapPath("~\\Arquivos\\Imagem\\" + Path.GetFileName(userPostedFile.FileName));
                    }
                    else
                    {
                        navegador = ("http://zcondominio.com.br\\Arquivos\\Imagem\\" + Path.GetFileName(userPostedFile.FileName));
                    }


                    idRetorno = fotoRegraNegocios.SalvarFoto(Descricao.Text.Trim(), navegador, idUsuario);

                    if (idRetorno > 0)
                    {
                        if (userPostedFile.ContentLength > 0)
                        {
                            diretorio = this.Server.MapPath("~\\Arquivos\\Imagem\\" + Path.GetFileName(userPostedFile.FileName));

                            userPostedFile.SaveAs(diretorio);
                        }
                    }
                    else
                    {
                        erro = +1;
                    }
                }

                if (erro == 0)
                {
                    Response.Redirect("~/Views/Galeria.aspx", false);
                }
                else
                {
                    Response.Write("<script>alert('Ocorreu um Erro ao Salvar Arquivo(s) Selecionado.'); window.location.href = window.location.href;</script>");
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;

                Response.Redirect("~/Error.aspx", true);
            }
        }

        [WebMethod]
        private void GerarDiretorio()
        {
            Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\"));
            Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Imagem\\"));

            //street = this.Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\IpeAmarelo\\" + hfId.Value + "\\" + url);
            diretorio = this.Server.MapPath("~\\Arquivos\\Imagem\\");
        }
    }
}
