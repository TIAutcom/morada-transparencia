using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.REGRA.NEGOCIOS;
using TI.MORADA.SOL.OBJETO.TRANSFERENCIA;
using System.IO;
using System.Threading;

namespace TI.MORADA.SOL.UI.Cadastros
{
    public partial class Fotos : System.Web.UI.Page
    {
        #region VARIAVEIS

        public int idUsuario, idNivel = 0;
        int idTipo = 0;
        string urlEndereco = "";
        public string folder = "";
        public string[] arquivo;
        public string subDiretorio = "";

        int idRet = 0;

        //FTP
        string login = "ftpmoradatur";
        string senha = "0909morada";
        string endFtp = "ftp://moradaturismoeventos.com.br/";

        #endregion

        #region CLASSES E OBJETOS

        Foto foto;
        FotoRegraNegocios fotoRegraNegocios;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["IdUsuario"] == null)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Voltar", "history.back();", true);
                return;
            }
            else
            {
                GetDados();
            }
        }

        public void GetDados()
        {
            idUsuario = Convert.ToInt32(Session["IdUsuario"]);
            idNivel = Convert.ToInt32(Session["IdNivel"]);

            if (idUsuario != 0)
            {
                lblLogin.Text = "OPERADOR(A): " + "[ " + Session["Usuario"].ToString().ToUpper() + " ] - N: " + idNivel.ToString().PadLeft(2, '0');
                lblLogin.Visible = true;
            }
            else
            {
                lblLogin.Visible = false;
            }
        }

        public void Salvar()
        {
            try
            {
                if (SalvarFotoArquivo() == true)
                {
                    foto = new Foto();
                    fotoRegraNegocios = new FotoRegraNegocios();

                    foto.Id = 0;
                    idTipo = Convert.ToInt32(ddlGaleria.SelectedValue);
                    foto.Titulo = Titulo.Text.Trim().ToUpper();
                    foto.DEscricao = Descricao.Text.Trim();
                    foto.Data = DateTime.Now.Date;
                    foto.IdUsuario = idUsuario;
                    foto.Url = @"http://transparencia.moradaturismoeventos.com.br/Arquivos/Portifolios/" + subDiretorio + "/" + fupImagem.FileName;
                    foto.IdTipo = idTipo;

                    string idRetorno = fotoRegraNegocios.Salvar(foto);

                    try
                    {
                        idRet = Convert.ToInt32(idRetorno);

                        Response.Write("<script>alert('Cadastro de Foto para Portifolio foi Reealizado com Sucesso.'); window.location.href = window.location.href;</script>");
                    }
                    catch
                    {
                        Response.Write("<script>alert('Erro ao Cadastrar Foto para Portifolio.'); window.location.href = window.location.href;</script>");
                    }
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", true);
            }
        }

        public bool SalvarFotoArquivo()
        {
            try
            {
                if (ddlGaleria.SelectedIndex <= 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção, Informe Tipo de Galeria Desejado.')</script>");
                    return false;
                }
                else if (fupImagem.FileName == null)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção, Informe Foto Desejado.')</script>");
                    return false;
                }
                else if (fupImagem.FileName.ToString().Trim().Equals(""))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção, Informe Foto Desejado.')</script>");
                    return false;
                }
                else
                {
                    idTipo = Convert.ToInt32(ddlGaleria.SelectedValue);

                    if (idTipo == 1)
                        subDiretorio = "Obras";
                    else if (idTipo == 2)
                        subDiretorio = "Eventos";
                    else if (idTipo == 3)
                        subDiretorio = "Sala";
                    else if (idTipo == 4)
                        subDiretorio = "Auditorio";
                    else if (idTipo == 5)
                        subDiretorio = "Foyer";
                    else if (idTipo == 6)
                        subDiretorio = "Pavilhao";
                    else if (idTipo == 7)
                        subDiretorio = "AreaExterna";
                    else if (idTipo == 8)
                        subDiretorio = "Arena";

                    GerarDiretorio();

                    string filepath = Server.MapPath(urlEndereco);

                    fupImagem.PostedFile.SaveAs(filepath + "\\" + fupImagem.FileName);

                    return true;
                }

            }
            catch (IndexOutOfRangeException ex)
            {
                Session["Error"] = ex.Message;
                return false;
            }
            finally
            {
            }
        }

        public void PortaFTP(string arquivo)
        {
            try
            {
                if (validaInformacaoServidorFTP())
                {
                    if (!string.IsNullOrEmpty(arquivo.ToString()))
                    {
                        string urlArquivoEnviar = (arquivo + subDiretorio + "/" + fupImagem.FileName);

                        try
                        {
                            FTP.EnviarArquivoFTP(arquivo, urlArquivoEnviar, login, senha);
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    //MessageBox.Show("Informações do sevidor incompletas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        private bool validaInformacaoServidorFTP()
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(endFtp))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void GerarDiretorio()
        {
            try
            {
                Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\"));
                Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Portifolios\\"));
                Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Portifolios\\" + subDiretorio));

                urlEndereco = "~\\Arquivos\\Portifolios\\" + subDiretorio + "\\";
            }
            catch (IndexOutOfRangeException ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        protected void Unnamed6_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}