using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Net.Mail;

namespace SGVersaoBeta
{
    public partial class enviarrelatorioProjetos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginUsuario"] == null)
            {
                Response.Redirect("login.aspx");
            }

            OleDbConnection conn = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            conn.ConnectionString = Conexao.ConexaoStr;
            cmd.Connection = conn;
            cmd.CommandText = "select NomeProjeto from Projetos";
            cmd.CommandType = CommandType.Text;
            conn.Open();
            da.SelectCommand = cmd;
            da.Fill(ds, "NomeProjeto");
            dropProjetos.DataSource = ds.Tables["NomeProjeto"];
            dropProjetos.DataValueField = "NomeProjeto";
            dropProjetos.DataBind();
            conn.Close();
            conn.Dispose();

        }

        protected void btnEnviarRelatorio_Click(object sender, EventArgs e)
        {
            OleDbConnection conn5 = new OleDbConnection();
            OleDbCommand cmd5 = new OleDbCommand();
            string usuario = Session["LoginUsuario"].ToString();
            conn5.ConnectionString = Conexao.ConexaoStr;
            cmd5.Connection = conn5;
            cmd5.CommandText = "update Projetos set Relatorio = '" + txtRelatorio.Text + "', RedatorRelatorio = '" + usuario + "' where NomeProjeto = '" + dropProjetos.Text + "'";
            cmd5.CommandType = CommandType.Text;
            conn5.Open();
            cmd5.ExecuteNonQuery();
            conn5.Close();
            conn5.Dispose();
            string data = DateTime.Now.ToString();
            string nome = Session["LoginUsuario"].ToString();
            OleDbConnection conn2 = new OleDbConnection();
            OleDbCommand cmd2 = new OleDbCommand();
            conn2.ConnectionString = Conexao.ConexaoStr;
            cmd2.Connection = conn2;
            cmd2.CommandText = "insert into HistoricoSistema(NomeAutor, AcaoEfetuada, DataAcao) values ('" + nome + "', 'Enviou um relatório referente ao projeto " + dropProjetos.Text + "', '" + data + "')";
            cmd2.CommandType = CommandType.Text;
            conn2.Open();
            cmd2.ExecuteScalar();
            conn2.Close();
            conn2.Dispose();
            lblRespostaServer.Text = "Relatório registrado";
            /*System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            client.Host = "smtp.articulandocomunicacao.com";
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("jornalismo@articulandocomunicacao.com", "ddg252");
            MailMessage mail = new MailMessage();
            mail.Sender = new System.Net.Mail.MailAddress("jornalismo@articulandocomunicacao.com", "Sistema Articulando");
            mail.From = new MailAddress("jornalismo@articulandocomunicacao.com", "Sistema Articulando");
            mail.To.Add(new MailAddress("jornalismo@articulandocomunicacao.com", "Roseane Costa Neres"));
            mail.Subject = "Feedback do projeto" + dropProjetos.Text;
            mail.Body = "O colaborador(a) " + nome + "enviou um relatório referente ao projeto " + dropProjetos.Text + ", confira.<br><br><strong>Relatório enviado: </strong>" + txtRelatorio.Text;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            try
            {
                client.Send(mail);
                lblRespostaServer.Text = "Relatório enviado e registrado.";
            }
            catch (System.Exception)
            {
                lblRespostaServer.Text = "Relatório registrado, mas o envio de e-mail falhou.";
            }
            finally
            {
                mail = null;
            }*/
        }
    }
}