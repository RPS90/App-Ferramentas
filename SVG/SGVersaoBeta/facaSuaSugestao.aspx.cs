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
    public partial class facaSuaSugestao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginUsuario"] == null)
            {
                Response.Redirect("login.aspx");
            }

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            conn.ConnectionString = Conexao.ConexaoStr;
            cmd.Connection = conn;
            cmd.CommandText = "select * from Sugestoes where TituloSugestao = '" + txtTituloSugestao.Text + "'";
            cmd.CommandType = CommandType.Text;
            conn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                lblRespostaServer.Text = "Sugestão já efetuada, aguarde retorno do administrador Mike Figueiredo";
            }
            else
            {
                string nomeUsuario = Session["LoginUsuario"].ToString();
                OleDbConnection conn2 = new OleDbConnection();
                OleDbCommand cmd2 = new OleDbCommand();
                conn2.ConnectionString = Conexao.ConexaoStr;
                cmd2.Connection = conn2;
                cmd2.CommandText = "insert into Sugestoes (TituloSugestao, Sugestao, NomeAutor) values('" + txtTituloSugestao.Text + "', '" + txtSugestao.Text + "', '" + nomeUsuario + "')";
                cmd2.CommandType = CommandType.Text;
                conn2.Open();
                cmd2.ExecuteScalar();
                conn2.Close();
                conn2.Dispose();

                string data = DateTime.Now.ToString();
                string nome = Session["LoginUsuario"].ToString();
                OleDbConnection conn3 = new OleDbConnection();
                OleDbCommand cmd3 = new OleDbCommand();
                conn3.ConnectionString = Conexao.ConexaoStr;
                cmd3.Connection = conn3;
                cmd3.CommandText = "insert into HistoricoSistema(NomeAutor, AcaoEfetuada, DataAcao) values ('" + nome + "', 'Enviou a sugestão " + txtTituloSugestao.Text + "', '" + data + "')";
                cmd3.CommandType = CommandType.Text;
                conn3.Open();
                cmd3.ExecuteScalar();
                conn3.Close();
                conn3.Dispose();

                lblRespostaServer.Text = "Sugestão enviada com sucesso!";
                
            }

        }
    }
}