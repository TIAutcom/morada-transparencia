using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.OBJETO.TRANSFERENCIA;

namespace TI.MORADA.SOL.UI.UpLoads
{
    public partial class Transparencia : System.Web.UI.Page
    {
        #region VARIAVEIS

        public int idUsuario, idNivel = 0;
        public int idTransp, idLai = 0;
        public string _login, _transparencia, anoCad = "";
        public string folder = "";
        public string street = "";
        public string[] arquivo;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            GetDados();

            idLai = Convert.ToInt32(Page.Request.QueryString["idLai"]);
            idTransp = Convert.ToInt32(Page.Request.QueryString["idTransp"]);
            anoCad = Page.Request.QueryString["Ano"];
            lblDescricaLai.Text = Page.Request.QueryString["Transparencia"];
            _transparencia = Page.Request.QueryString["Transparencia"];

            LoadPagina();
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

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Forms/LeiAcessoInformacao", true);
        }

        protected void gdvTranparencia_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("View"))
                {
                    string url = e.CommandArgument.ToString();

                    StringBuilder sb = new StringBuilder(url);

                    if ((_transparencia == "2.2.4 - Despesas Mensais") || (_transparencia == "2.2.2 - Receitas Mensais") || (_transparencia.Trim().Substring(0, 5).Equals("2.4.4")) || (_transparencia.Trim().Substring(0, 5).Equals("2.4.5")))
                    {
                        sb.Insert(26, idLai + "/" + idTransp + "/" + ddlAno.Text.Trim() + "/");
                    }
                    else
                    {
                        sb.Insert(26, idLai + "/" + idTransp + "/");
                    }

                    string path = Server.MapPath(sb.ToString());

                    var file = new FileInfo(path);

                    string extensao = System.IO.Path.GetExtension(path);

                    if (extensao.Trim().Equals(".pdf"))
                    {
                        String end = "http://moradaturismoeventos.com.br" + sb.ToString().Replace("~", "").Trim();

                        ScriptManager.RegisterStartupScript(this, typeof(string), "New_Window", "window.open('" + end + "', null, 'height=800,width=1370,status=yes,toolbar=yes,menubar=yes,location=no' );", true);
                    }

                    else if (extensao.Trim().Equals(".docx") || (extensao.Trim().Equals(".doc")))
                    {
                        FileInfo flarquivo = new FileInfo(path);

                        Response.Clear();
                        Response.AddHeader("Content-Disposition", "attachment; filename=" + url.Substring(url.LastIndexOf("/")));
                        Response.AddHeader("Content-Length", flarquivo.Length.ToString());
                        Response.ContentType = "application/octet-stream";
                        Response.WriteFile(flarquivo.FullName);
                        Response.End();
                    }
                    else if (extensao.Trim().Equals(".xlsx") || (extensao.Trim().Equals(".xls")))
                    {
                        Response.Clear();
                        Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(file.Name));
                        Response.AddHeader("Content-Length", file.Length.ToString(CultureInfo.InvariantCulture));
                        Response.ContentType = "application/octet-stream";
                        Response.WriteFile(file.FullName);
                        Response.Flush();
                        Response.End();
                    }
                    else
                    {
                        Response.Clear();
                        Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(file.Name));
                        Response.AddHeader("Content-Length", file.Length.ToString(CultureInfo.InvariantCulture));
                        Response.Flush();
                        Response.ContentType = "application/octet-stream";
                        Response.WriteFile(file.FullName);
                        Response.Flush();
                        Response.Write("<script>alert('Dowload do Arquivo com sucesso.'); window.location.href = window.location.href;</script>");
                        Response.Close();
                    }
                }

                if (e.CommandName.Equals("Deletar"))
                {
                    string url = e.CommandArgument.ToString();

                    StringBuilder sb = new StringBuilder(url);

                    if ((_transparencia.Trim().Substring(0, 5).Equals("2.1.5")) || (_transparencia.Trim().Substring(0, 5) == "2.2.4") || (_transparencia.Trim().Substring(0, 5) == "2.2.2") || (_transparencia.Trim().Substring(0, 5).Equals("2.2.6")))
                    {
                        sb.Insert(26, idLai + "/" + idTransp + "/" + ddlAno.Text.Trim() + "/");
                    }
                    else if (_transparencia.Trim().Substring(0, 6).Equals("2.2.13") || (_transparencia.Trim().Substring(0, 5).Equals("2.4.4") || (_transparencia.Trim().Substring(0, 5).Equals("2.4.5"))))
                    {
                        sb.Insert(26, idLai + "/" + idTransp + "/" + ddlAno.Text.Trim() + "/");
                    }
                    else
                    {
                        sb.Insert(26, idLai + "/" + idTransp + "/");
                    }

                    string path = Server.MapPath(sb.ToString());
                    FileInfo flarquivo = new FileInfo(path);

                    System.IO.File.Delete(flarquivo.FullName);

                    Response.Write("<script>alert('Arquivo Deletado com sucesso.'); window.location.href = window.location.href;</script>");
                }

                if (e.CommandName.Equals("Downloads"))
                {
                    string url = e.CommandArgument.ToString();

                    StringBuilder sb = new StringBuilder(url);

                    if ((_transparencia == "2.2.4 - Despesas Mensais") || (_transparencia == "2.2.2 - Receitas Mensais") || (_transparencia.Trim().Substring(0, 5).Equals("2.4.4")))
                    {
                        sb.Insert(26, idLai + "/" + idTransp + "/" + ddlAno.Text.Trim() + "/");
                    }
                    else
                    {
                        sb.Insert(26, idLai + "/" + idTransp + "/");
                    }

                    string path = Server.MapPath(sb.ToString());

                    var file = new FileInfo(path);

                    string extensao = System.IO.Path.GetExtension(path);

                    if (extensao.Trim().Equals(".pdf"))
                    {
                        System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                        byte[] ar = new byte[(int)fs.Length];
                        fs.Read(ar, 0, (int)fs.Length);
                        fs.Close();
                        Response.AddHeader("content-disposition", "attachment;filename=" + file + ".pdf");
                        Response.ContentType = "application/pdf";
                        Response.BinaryWrite(ar);
                        Response.End();
                    }
                    else if (extensao.Trim().Equals(".xls"))
                    {
                        System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read);

                        AbrirDocumento(path);
                    }
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", true);
            }
        }

        public void AbrirDocumento(string path)
        {
            Response.Clear();
            //Nome do arquivo que será visto no momento do download
            Response.AddHeader("content-disposition", "attachment;filename=MeuExcel.xls");
            Response.ContentType = "application/ms-excel";
            //Ira escrever o conteudo do arquivo no buffer do response
            Response.WriteFile("<" + path + ">");
            Response.End();
        }

        protected void btnupLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (flUpFile.HasFile)
                {
                    string url = flUpFile.PostedFile.FileName;

                    if (flUpFile.PostedFile != null)
                    {
                        string extensao = Path.GetExtension(flUpFile.FileName);

                        url = Path.GetFileName(url);
                        url.Replace(" ", "_");
                        String pasta = "\\";

                        string[] ext_image = new string[] { ".jpg", ".jpeg", ".gif", ".png", ".JPG", ".JPEG", ".GIF", ".PNG", "" };//foto
                        string[] ext_video = new string[] { ".3gp", ".wmv", ".mp4", ".ogg", ".flv", ".3GP", ".WMV", ".MP4", ".OGG", ".FLV", "" };//video

                        //Verifica a pasta onde será salvo o arquivo
                        foreach (string s in ext_image)
                        {
                            if (s == extensao)
                            {
                                pasta += "Imagens\\";
                            }
                        }
                        foreach (string s in ext_video)
                        {
                            if (s == extensao)
                            {
                                pasta += "Videos\\";
                            }
                        }

                        GerarDiretorio(idLai, idTransp, ddlAno.Text.Trim());

                        hfId.Value = idTransp.ToString();

                        if (ddlAno.Text.Trim().Equals(""))
                        {
                            street = this.Server.MapPath("~\\Arquivos\\Transparencias\\" + idLai + "\\" + hfId.Value + pasta + url);
                        }
                        else
                        {
                            street = this.Server.MapPath("~\\Arquivos\\Transparencias\\" + idLai + "\\" + hfId.Value + "\\" + ddlAno.Text.Trim() + pasta + url);
                        }

                        if (!File.Exists(street))
                        {
                            flUpFile.PostedFile.SaveAs(street);
                            Response.Write("<script>alert('Arquivo salvo com sucesso.'); window.location.href = window.location.href;</script>");
                        }
                        else
                        {
                            lblResponse.Text = "Existe um arquivo com o mesmo nome.";

                            Response.Write("<script>alert('Existe um arquivo com o mesmo nome.'); window.location.href = window.location.href;</script>");
                        }
                    }
                }
            }
            catch
            {
                Response.Redirect("~/Error.aspx");
            }
            finally
            {
            }
        }

        [WebMethod]
        public void GerarDiretorio(int idLai, int idTransp, string ano)
        {
            try
            {
                if (ano == "")
                {
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Transparencias\\"));
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Transparencias\\" + "\\" + idLai));
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Transparencias\\" + "\\" + idLai + "\\" + idTransp));
                }
                else
                {
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Transparencias\\"));
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Transparencias\\" + "\\" + idLai));
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Transparencias\\" + "\\" + idLai + "\\" + idTransp));
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Transparencias\\" + "\\" + idLai + "\\" + idTransp + "\\" + ano));
                }
            }
            catch
            {
                Response.Redirect("~/Error.aspx");
            }
        }

        public void LoadPagina()
        {
            try
            {
                try
                {
                    string anoCad = "";
                    string folder = Server.MapPath("~\\Arquivos\\Transparencias\\" + idLai + "\\" + idTransp);

                    if ((_transparencia.Trim().Substring(0, 5).Equals("2.1.5")) || (_transparencia.Trim().Substring(0, 5).Equals("2.2.2")) || (_transparencia.Trim().Substring(0, 5).Equals("2.2.4")) || (_transparencia.Trim().Substring(0, 5).Equals("2.2.7")) || (_transparencia.Trim().Substring(0, 5).Equals("2.4.4")) || (_transparencia.Trim().Substring(0, 5).Equals("2.4.5")))
                    {
                        lblDescricao.Text = "Selecione Ano Desejado para Realizar UpLoad";

                        if (!IsPostBack)
                        {
                            ddlAno.Items.Insert(1, new ListItem("2022", "2022"));
                            ddlAno.Items.Insert(2, new ListItem("2021", "2021"));
                            ddlAno.Items.Insert(3, new ListItem("2020", "2020"));
                            ddlAno.Items.Insert(4, new ListItem("2019", "2019"));
                            ddlAno.Items.Insert(5, new ListItem("2018", "2018"));
                            ddlAno.Items.Insert(6, new ListItem("2017", "2017"));
                        }

                        anoCad = ddlAno.SelectedValue;

                        if (anoCad.Trim() == "")
                        {
                            arquivo = Directory.GetFiles(Server.MapPath("~\\Arquivos\\Transparencias\\" + idLai + "\\" + idTransp + "\\"), "*");
                        }
                        else
                        {
                            arquivo = Directory.GetFiles(Server.MapPath("~\\Arquivos\\Transparencias\\" + idLai + "\\" + idTransp + "\\" + anoCad.Trim() + "\\"), "*");
                        }
                    }
                    else if (_transparencia.Trim().Substring(0, 5).Equals("2.2.6"))
                    {
                        lblDescricao.Text = "Selecione Tipo de Balanço Desejado para Realizar UpLoad";

                        if (!IsPostBack)
                        {
                            ddlAno.Items.Insert(1, new ListItem("Balanço Anual - Orçamentário", "Balanço Anual - Orçamentario"));
                            ddlAno.Items.Insert(2, new ListItem("Balanço Anual - Financeiro", "Balanço Anual - Financeiro"));
                            ddlAno.Items.Insert(3, new ListItem("Balanço Anual - Patrimonial", "Balanço Anual - Patrimonial"));
                        }

                        anoCad = ddlAno.SelectedValue;

                        folder = Server.MapPath("~\\Arquivos\\Transparencias\\" + idLai + "\\" + idTransp);
                        arquivo = Directory.GetFiles(Server.MapPath("~\\Arquivos\\Transparencias\\" + idLai + "\\" + idTransp + "\\" + anoCad.Trim() + "\\"), "*");
                    }
                    else if (_transparencia.Trim().Substring(0, 6).Equals("2.2.13"))
                    {
                        lblDescricao.Text = "Selecione Tipo de Contrato Desejado para Realizar UpLoad";

                        if (!IsPostBack)
                        {
                            ddlAno.Items.Insert(1, new ListItem("Contrato de Locação 2022", "Contrato de Locação 2022"));
                            ddlAno.Items.Insert(2, new ListItem("Contrato de Locação 2021", "Contrato de Locação 2021"));
                            ddlAno.Items.Insert(3, new ListItem("Contrato de Locação 2020", "Contrato de Locação 2020"));
                            ddlAno.Items.Insert(4, new ListItem("Contrato de Locação 2019", "Contrato de Locação 2019"));
                            ddlAno.Items.Insert(5, new ListItem("Contrato de Locação 2018", "Contrato de Locação 2018"));
                            ddlAno.Items.Insert(6, new ListItem("Contrato de Locação 2017", "Contrato de Locação 2017"));
                            ddlAno.Items.Insert(7, new ListItem("Contrato de Prestadores de Serviços 2022", "Contrato de Prestadores de Serviços 2022"));
                            ddlAno.Items.Insert(8, new ListItem("Contrato de Prestadores de Serviços 2021", "Contrato de Prestadores de Serviços 2021"));
                            ddlAno.Items.Insert(9, new ListItem("Contrato de Prestadores de Serviços 2020", "Contrato de Prestadores de Serviços 2020"));
                            ddlAno.Items.Insert(10, new ListItem("Contrato de Prestadores de Serviços 2019", "Contrato de Prestadores de Serviços 2019"));
                            ddlAno.Items.Insert(11, new ListItem("Contrato de Prestadores de Serviços 2018", "Contrato de Prestadores de Serviços 2018"));
                            ddlAno.Items.Insert(12, new ListItem("Contrato de Prestadores de Serviços 2017", "Contrato de Prestadores de Serviços 2017"));
                        }

                        anoCad = ddlAno.SelectedValue;

                        folder = Server.MapPath("~\\Arquivos\\Transparencias\\" + idLai + "\\" + idTransp);
                        arquivo = Directory.GetFiles(Server.MapPath("~\\Arquivos\\Transparencias\\" + idLai + "\\" + idTransp + "\\" + anoCad.Trim() + "\\"), "*");
                    }
                    else
                    {
                        folder = Server.MapPath("~\\Arquivos\\Transparencias\\" + idLai + "\\" + idTransp);
                        arquivo = Directory.GetFiles(Server.MapPath("~\\Arquivos\\Transparencias\\" + idLai + "\\" + idTransp), "*");
                    }

                    hfId.Value = idTransp.ToString();

                    if (arquivo.Length > 0)
                    {
                        List<DFileUploadProjeto> Larquivos = new List<DFileUploadProjeto>();

                        for (int i = 0; i < arquivo.Length; i++)
                        {
                            int lastposition = arquivo[i].LastIndexOf("\\");

                            string nome = arquivo[i].Substring(lastposition + 1);

                            Larquivos.Add(new DFileUploadProjeto(nome, idTransp));
                        }

                        gdvTranparencia.DataSource = null;
                        gdvTranparencia.DataSource = Larquivos;
                        gdvTranparencia.DataBind();
                    }
                    else
                    {
                        gdvTranparencia.DataSource = null;
                        gdvTranparencia.DataBind();
                    }
                }
                catch
                {
                    gdvTranparencia.DataSource = null;
                    gdvTranparencia.DataBind();
                }
            }
            catch
            {
                Response.Redirect("~/Error.aspx");
            }
        }
    }
}