using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.MORADA.SOL.OBJETO.TRANSFERENCIA;
using TI.MORADA.SOL.REGRA.NEGOCIOS;

namespace TI.MORADA.SOL.UI.Cadastros
{
    public partial class Diretoria : System.Web.UI.Page
    {
        #region VARIAVEIS

        int idUsuario, idNivel = 0;
        string subDiretorio = "";

        #endregion

        #region CLASSES E OBJETOS

        Diretorias diretoria;
        DiretoriaRegraNegocios diretoriaRegraNegocios;

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
                diretoria = new Diretorias();
                diretoriaRegraNegocios = new DiretoriaRegraNegocios();

                diretoria.Nome = Nome.Text.Trim();
                diretoria.Cargo = Cargo.Text.Trim();
                diretoria.Url = @"~/Arquivos/Imagem/Diretoria/" + fupImagem.FileName;
                diretoria.Descricao = Descricao.Text.Trim();
                diretoria.IdUsuario = idUsuario;

                int idRet = diretoriaRegraNegocios.SalvarDiretoria(diretoria);

                if (idRet > 0)
                {
                    Response.Write("<script>alert('Diretor Cadastrado com Sucesso.'); window.location.href = window.location.href;</script>");
                    GerarDiretorioSalvar();
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Erro ao Cadastrar um Novo Diretor.')</script>");
                }
            }
            catch (Exception ex)
            {
                Session.Clear();
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        public void GerarDiretorioSalvar()
        {
            try
            {
                Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\"));
                Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Imagem\\"));
                Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Imagem\\Diretoria\\"));
                Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Imagem\\Diretoria\\" + subDiretorio));

                string filepath = Server.MapPath("~\\Arquivos\\Imagem\\Diretoria\\" + subDiretorio);

                fupImagem.PostedFile.SaveAs(filepath + "\\" + fupImagem.FileName);
            }
            catch (Exception ex)
            {
                Session.Clear();
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        protected void Unnamed7_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}