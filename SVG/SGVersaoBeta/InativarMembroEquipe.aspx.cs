using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

namespace SGVersaoBeta
{
    public partial class InativarMembroEquipe : System.Web.UI.Page
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
            cmd.CommandText = "select Nome from DadosEquipeArticulando";
            cmd.CommandType = CommandType.Text;
            conn.Open();
            da.SelectCommand = cmd;
            da.Fill(ds, "Nome");
            dropInativarColaborador.DataSource = ds.Tables["Nome"];
            dropInativarColaborador.DataValueField = "Nome";
            dropInativarColaborador.DataBind();
            conn.Close();
            conn.Dispose();

        }

        protected void btnInativarColaborador_Click(object sender, EventArgs e)
        {
            string statusColaborador = "Inativo";
            OleDbConnection conn5 = new OleDbConnection();
            OleDbCommand cmd5 = new OleDbCommand();
            conn5.ConnectionString = Conexao.ConexaoStr;
            cmd5.Connection = conn5;
            cmd5.CommandText = "update DadosEquipeArticulando set  StatusColaborador = '" + statusColaborador + "' where Nome = '" + dropInativarColaborador.Text + "'";
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
            cmd2.CommandText = "insert into HistoricoSistema(NomeAutor, AcaoEfetuada, DataAcao) values ('" + nome + "', 'Inativou o colaborador " + dropInativarColaborador.Text + "', '" + data + "')";
            cmd2.CommandType = CommandType.Text;
            conn2.Open();
            cmd2.ExecuteScalar();
            conn2.Close();
            conn2.Dispose();

            lblRespostaServer.Text = "Agora o colaborador está inativo no sistema";
        }
    }
}