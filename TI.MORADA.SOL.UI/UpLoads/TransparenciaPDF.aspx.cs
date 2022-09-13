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
using TI.MORADA.SOL.REGRA.NEGOCIOS;

namespace TI.MORADA.SOL.UI.UpLoads
{
    public partial class TransparenciaPDF : System.Web.UI.Page
    {
        #region VARIAVEIS

        public int idUsuario, idNivel = 0;
        public int idTransp, idLai = 0;
        public string[] arquivo;
        public string _login, _transparencia, _ano = "";
        public string extensao = "";
        string anoCad, folder, endereco = "";

        // static variable
        static string prevPage = String.Empty;

        #endregion

        #region CLASSES E OBJETOS

        TransparenciaRegraNegocios transparenciaRegraNegocios;

        #endregion

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect(prevPage);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            GetDados();

            idLai = Convert.ToInt32(Page.Request.QueryString["idLai"]);
            idTransp = Convert.ToInt32(Page.Request.QueryString["idTransp"]);
            _transparencia = Page.Request.QueryString["Transparencia"];
            lblDescricaLai.Text = Page.Request.QueryString["Transparencia"];

            LoadPagina();

            if (!IsPostBack)
            {
                prevPage = Request.UrlReferrer.ToString();
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

        public void LoadPagina()
        {
            try
            {
                try
                {
                    if ((_transparencia.Trim().Substring(0, 5).Equals("2.1.5")) || (_transparencia.Trim().Substring(0, 5).Equals("2.2.2")) || (_transparencia.Trim().Substring(0, 5).Equals("2.2.4")) || (_transparencia.Trim().Substring(0, 5).Equals("2.2.7")) || (_transparencia.Trim().Substring(0, 5).Equals("2.4.4")))
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
                            arquivo = Directory.GetFiles(Server.MapPath("~\\Arquivos\\Transparencias\\" + idLai + "\\" + idTransp + "\\" + anoCad.Trim() + "\\PDF\\"), "*");
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
                            ddlAno.Items.Insert(1, new ListItem("Contrato de Locação 2021", "Contrato de Locação 2021"));
                            ddlAno.Items.Insert(2, new ListItem("Contrato de Locação 2020", "Contrato de Locação 2020"));
                            ddlAno.Items.Insert(3, new ListItem("Contrato de Locação 2019", "Contrato de Locação 2019"));
                            ddlAno.Items.Insert(4, new ListItem("Contrato de Locação 2018", "Contrato de Locação 2018"));
                            ddlAno.Items.Insert(5, new ListItem("Contrato de Locação 2017", "Contrato de Locação 2017"));
                            ddlAno.Items.Insert(6, new ListItem("Contrato de Prestadores de Serviços 2022", "Contrato de Prestadores de Serviços 2022"));
                            ddlAno.Items.Insert(6, new ListItem("Contrato de Prestadores de Serviços 2021", "Contrato de Prestadores de Serviços 2021"));
                            ddlAno.Items.Insert(7, new ListItem("Contrato de Prestadores de Serviços 2020", "Contrato de Prestadores de Serviços 2020"));
                            ddlAno.Items.Insert(8, new ListItem("Contrato de Prestadores de Serviços 2019", "Contrato de Prestadores de Serviços 2019"));
                            ddlAno.Items.Insert(9, new ListItem("Contrato de Prestadores de Serviços 2018", "Contrato de Prestadores de Serviços 2018"));
                            ddlAno.Items.Insert(10, new ListItem("Contrato de Prestadores de Serviços 2019", "Contrato de Prestadores de Serviços 2017"));
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

                        lblQtde.Text = "Qtde de Dados: " + gdvTranparencia.Rows.Count.ToString().PadLeft(5, '0');
                    }
                    else
                    {
                        gdvTranparencia.DataSource = null;
                        gdvTranparencia.DataBind();

                        lblQtde.Text = "Qtde de Dados: " + gdvTranparencia.Rows.Count.ToString().PadLeft(5, '0');
                    }
                }
                catch
                {
                    gdvTranparencia.DataSource = null;
                    gdvTranparencia.DataBind();

                    lblQtde.Text = "Qtde de Dados: " + gdvTranparencia.Rows.Count.ToString().PadLeft(5, '0');
                }
            }
            catch
            {
                Response.Redirect("~/Error.aspx");
            }
        }

        protected void btnupLoad_Click(object sender, EventArgs e)
        {
            GerarDiretorio(idLai, idTransp, ddlAno.Text);

            string filepath = Server.MapPath(endereco);
            HttpFileCollection uploadedFiles = Request.Files;

            for (int i = 0; i < uploadedFiles.Count; i++)
            {
                HttpPostedFile userPostedFile = uploadedFiles[i];

                try
                {
                    if (userPostedFile.ContentLength > 0)
                    {
                        string caminho = Path.Combine(filepath + "\\" + Path.GetFileName(userPostedFile.FileName));
                        userPostedFile.SaveAs(filepath + "\\" + Path.GetFileName(userPostedFile.FileName));
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "'); window.location.href = window.location.href;</script>");
                }
            }

            Response.Write("<script>alert('Arquivo Cadastrado com Sucesso.'); window.location.href = window.location.href;</script>");
        }

        [WebMethod]
        public void GerarDiretorio(int idLai, int idTransp, string ano)
        {
            try
            {
                idTransp = Convert.ToInt32(Page.Request.QueryString["idTransp"]);

                if (ano != "")
                {
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Transparencias\\"));
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Transparencias\\" + "\\" + idLai));
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Transparencias\\" + "\\" + idLai + "\\" + idTransp));
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Transparencias\\" + "\\" + idLai + "\\" + idTransp + "\\" + ano));
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Transparencias\\" + "\\" + idLai + "\\" + idTransp + "\\" + ano + "\\PDF\\"));

                    endereco = "\\Arquivos\\Transparencias\\" + idLai + "\\" + idTransp + "\\" + ddlAno.Text.Trim() + "\\PDF";
                }
                else
                {
                    Response.Write("<script>alert('Informe o Ano Desejado !!.'); window.location.href = window.location.href;</script>");
                }
            }
            catch
            {
                Response.Redirect("~/Error.aspx");
            }
        }

        protected void gdvTranparencia_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("Downloads"))
                {
                    string url = e.CommandArgument.ToString();

                    StringBuilder sb = new StringBuilder(url);

                    if ((_transparencia == "2.2.4 - Despesas Mensais") || (_transparencia == "2.2.2 - Receitas Mensais"))
                    {
                        sb.Insert(26, idLai + "/" + idTransp + "/" + ddlAno.Text.Trim() + "/PDF/");
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

                if (e.CommandName.Equals("View"))
                {
                    string url = e.CommandArgument.ToString();

                    StringBuilder sb = new StringBuilder(url);

                    if ((_transparencia == "2.2.4 - Despesas Mensais") || (_transparencia == "2.2.2 - Receitas Mensais"))
                    {
                        sb.Insert(26, idLai + "/" + idTransp + "/" + ddlAno.Text.Trim() + "/PDF/");
                    }
                    else
                    {
                        sb.Insert(26, idLai + "/" + idTransp + "/");
                    }

                    String end = "http://transparencia.moradaturismoeventos.com.br" + sb.ToString().Replace("~", "").Trim();

                    ScriptManager.RegisterStartupScript(this, typeof(string), "New_Window", "window.open('" + end + "', null, 'height=800,width=1370,status=yes,toolbar=yes,menubar=yes,location=no' );", true);
                }

                if (e.CommandName.Equals("Deletar"))
                {
                    string url = e.CommandArgument.ToString();

                    StringBuilder sb = new StringBuilder(url);

                    if ((_transparencia.Trim().Substring(0, 5).Equals("2.1.5")) || (_transparencia.Trim().Substring(0, 5) == "2.2.4") || (_transparencia.Trim().Substring(0, 5) == "2.2.2") || (_transparencia.Trim().Substring(0, 5).Equals("2.2.6")))
                    {
                        sb.Insert(26, idLai + "/" + idTransp + "/" + ddlAno.Text.Trim() + "/PDF/");
                    }
                    else if (_transparencia.Trim().Substring(0, 6).Equals("2.2.13"))
                    {
                        sb.Insert(26, idLai + "/" + idTransp + "/" + ddlAno.Text.Trim() + "/PDF/");
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
            }
            catch (Exception ex)
            {
                lblResponse.Text = ex.Message;
            }
            finally
            {
            }
        }
    }
}