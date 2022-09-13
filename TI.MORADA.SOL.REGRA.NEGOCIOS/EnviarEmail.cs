using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TI.MORADA.SOL.OBJETO.TRANSFERENCIA;

namespace TI.MORADA.SOL.REGRA.NEGOCIOS
{
    public class EnviarEmail
    {

        public string senhaCript = "contact0909";
        public string emails = "contato@cearararaquara.com.br";

        public string EnviarMesagemEmail(Emails email)
        {
            try
            {
                string CorpoEmail = email.Mensagem;
                MailMessage mailMessage = new MailMessage();

                //Endereço que irá aparecer no e-mail do usuário
                mailMessage.From = new MailAddress(email.Remetente, email.Pagina);

                //destinatarios do e-mail, para incluir mais de um basta separar por ponto e virgula
                mailMessage.To.Add(email.Remetente);
                mailMessage.Subject = email.Assunto;
                mailMessage.IsBodyHtml = true;

                //conteudo do corpo do e-mail
                mailMessage.Body = CorpoEmail.ToString();

                mailMessage.Priority = MailPriority.High;
                //smtp do e-mail que irá enviar
                SmtpClient smtpClient = new SmtpClient("mail.cearararaquara.com.br", 587);
                smtpClient.EnableSsl = false;

               // CalculateMD5Hash(senhaCript);

                //credenciais da conta que utilizará para enviar o e-mail
                smtpClient.Credentials = new NetworkCredential(emails, senhaCript);
                smtpClient.Send(mailMessage);

                return "Sua Mensagem Enviado com Sucesso para lista de E-mails  " + " às " + DateTime.Now.ToString() + ".";
            }
            catch (Exception ex)
            {
                string erro = ex.InnerException.ToString();
                return ex.Message.ToString() + erro;
            }
        }

        public string CalculateMD5Hash(string input)
        {
            // Calcular o Hash
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // Converter byte array para string hexadecimal
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            senhaCript = sb.ToString();

            return sb.ToString();
        }

        public bool EnviarMesagemEmailresposta(Emails email)
        {
            try
            {
                string CorpoEmail = "CEAR - Centro de Evento de Araraquara e Região";
                MailMessage mailMessage = new MailMessage();

                //Endereço que irá aparecer no e-mail do usuário
                mailMessage.From = new MailAddress(email.Remetente, "Contato - Morada do Sol Turismo Eventos e Participações S/A");

                //destinatarios do e-mail, para incluir mais de um basta separar por ponto e virgula
                mailMessage.To.Add(email.Destinatario);
                mailMessage.Subject = "Seu E-mail foi Enviado com Sucesso, em breve Retornaremos sua Mensagem.";
                mailMessage.IsBodyHtml = true;

                //conteudo do corpo do e-mail
                mailMessage.Body = CorpoEmail.ToString();

                mailMessage.Priority = MailPriority.High;
                //smtp do e-mail que irá enviar
                SmtpClient smtpClient = new SmtpClient("mail.cearararaquara.com.br", 587);
                smtpClient.EnableSsl = false;

                //credenciais da conta que utilizará para enviar o e-mail
                smtpClient.Credentials = new NetworkCredential(emails, senhaCript);
                smtpClient.Send(mailMessage);

                return true;
            }
            catch (Exception ex)
            {
                string erro = ex.InnerException.ToString();
                return false;
            }
        }

        private static bool ValidaEnderecoEmail(string email)
        {
            bool validEmail = false;
            int indexArr = email.IndexOf('@');
            if (indexArr > 0)
            {
                int indexDot = email.IndexOf('.', indexArr);
                if (indexDot - 1 > indexArr)
                {
                    if (indexDot + 1 < email.Length)
                    {
                        string indexDot2 = email.Substring(indexDot + 1, 1);
                        if (indexDot2 != ".")
                        {
                            validEmail = true;
                        }
                    }
                }
            }

            return validEmail;
        }
    }
}
